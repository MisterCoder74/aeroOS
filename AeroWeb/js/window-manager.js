/**
 * AeroWeb — Window Manager
 * Vanilla JS windowing: open/close/minimize/maximize/focus, drag, resize,
 * taskbar entry sync. No dependencies.
 */
const WindowManager = (() => {
  const layer = document.getElementById("windows-layer");
  const taskbarApps = document.getElementById("taskbar-apps");

  let windows = {};      // id -> { el, taskbarEl, app, prevRect }
  let zCounter = 10;
  let openCount = 0;

  function nextOffset() {
    const n = openCount % 8;
    return { x: 60 + n * 24, y: 40 + n * 24 };
  }

  function focus(id) {
    Object.values(windows).forEach(w => {
      w.el.classList.remove("focused");
      w.taskbarEl.classList.remove("active");
    });
    const w = windows[id];
    if (!w) return;
    w.el.style.zIndex = ++zCounter;
    w.el.classList.add("focused");
    w.taskbarEl.classList.add("active");
  }

  function open(appId) {
    const app = APP_REGISTRY.find(a => a.id === appId);
    if (!app) return;

    // Already open? just restore + focus.
    const existingId = Object.keys(windows).find(id => windows[id].app.id === appId);
    if (existingId) {
      restore(existingId);
      focus(existingId);
      return;
    }

    const winId = `win-${appId}-${Date.now()}`;
    const { x, y } = nextOffset();
    openCount++;

    const el = document.createElement("div");
    el.className = "app-window";
    el.id = winId;
    el.style.left = x + "px";
    el.style.top = y + "px";
    el.style.width = app.width + "px";
    el.style.height = app.height + "px";

    el.innerHTML = `
      <div class="win-titlebar">
        <span class="win-icon">${app.icon}</span>
        <span class="win-title">${app.name}</span>
        <span class="win-btn min" title="Minimize">–</span>
        <span class="win-btn max" title="Maximize">▢</span>
        <span class="win-btn close" title="Close">✕</span>
      </div>
      <div class="win-body"></div>
      <div class="win-resize-handle"></div>
    `;
    layer.appendChild(el);

    const bodyEl = el.querySelector(".win-body");
    app.render(bodyEl);

    const taskbarEl = document.createElement("div");
    taskbarEl.className = "taskbar-app";
    taskbarEl.innerHTML = `<span>${app.icon}</span><span>${app.name}</span>`;
    taskbarEl.addEventListener("click", () => toggleMinimize(winId));
    taskbarApps.appendChild(taskbarEl);

    windows[winId] = { el, taskbarEl, app, prevRect: null };

    wireWindowControls(winId);
    focus(winId);
  }

  function close(id) {
    const w = windows[id];
    if (!w) return;
    w.el.remove();
    w.taskbarEl.remove();
    delete windows[id];
  }

  function toggleMinimize(id) {
    const w = windows[id];
    if (!w) return;
    if (w.el.classList.contains("minimized")) {
      w.el.classList.remove("minimized");
      focus(id);
    } else {
      w.el.classList.add("minimized");
    }
  }

  function restore(id) {
    const w = windows[id];
    if (!w) return;
    w.el.classList.remove("minimized");
  }

  function toggleMaximize(id) {
    const w = windows[id];
    if (!w) return;
    if (w.el.classList.contains("maximized")) {
      w.el.classList.remove("maximized");
      if (w.prevRect) {
        Object.assign(w.el.style, w.prevRect);
      }
    } else {
      w.prevRect = {
        left: w.el.style.left, top: w.el.style.top,
        width: w.el.style.width, height: w.el.style.height
      };
      w.el.classList.add("maximized");
    }
  }

  function wireWindowControls(id) {
    const w = windows[id];
    const el = w.el;
    const titlebar = el.querySelector(".win-titlebar");
    const resizeHandle = el.querySelector(".win-resize-handle");

    el.addEventListener("mousedown", () => focus(id));

    el.querySelector(".win-btn.close").addEventListener("click", (e) => {
      e.stopPropagation();
      close(id);
    });
    el.querySelector(".win-btn.min").addEventListener("click", (e) => {
      e.stopPropagation();
      toggleMinimize(id);
    });
    el.querySelector(".win-btn.max").addEventListener("click", (e) => {
      e.stopPropagation();
      toggleMaximize(id);
    });
    titlebar.addEventListener("dblclick", () => toggleMaximize(id));

    // --- Drag ---
    let dragging = false, startX = 0, startY = 0, startLeft = 0, startTop = 0;
    titlebar.addEventListener("mousedown", (e) => {
      if (e.target.classList.contains("win-btn")) return;
      if (el.classList.contains("maximized")) return;
      dragging = true;
      startX = e.clientX; startY = e.clientY;
      startLeft = el.offsetLeft; startTop = el.offsetTop;
      e.preventDefault();
    });

    // --- Resize ---
    let resizing = false, startW = 0, startH = 0;
    resizeHandle.addEventListener("mousedown", (e) => {
      if (el.classList.contains("maximized")) return;
      resizing = true;
      startX = e.clientX; startY = e.clientY;
      startW = el.offsetWidth; startH = el.offsetHeight;
      e.preventDefault();
      e.stopPropagation();
    });

    document.addEventListener("mousemove", (e) => {
      if (dragging) {
        el.style.left = (startLeft + (e.clientX - startX)) + "px";
        el.style.top = Math.max(0, startTop + (e.clientY - startY)) + "px";
      }
      if (resizing) {
        el.style.width = Math.max(260, startW + (e.clientX - startX)) + "px";
        el.style.height = Math.max(160, startH + (e.clientY - startY)) + "px";
      }
    });
    document.addEventListener("mouseup", () => {
      dragging = false;
      resizing = false;
    });
  }

  return { open, close, toggleMinimize, toggleMaximize, focus };
})();
