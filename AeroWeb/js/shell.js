/**
 * AeroWeb — Desktop shell bootstrap.
 * Renders desktop icons + start menu from APP_REGISTRY, wires taskbar clock
 * and start menu toggling. Window behavior lives in window-manager.js.
 */
(function () {
  const iconsEl = document.getElementById("icons");
  const startMenuEl = document.getElementById("start-menu");
  const startBtn = document.getElementById("start-btn");
  const clockEl = document.getElementById("clock");
  const desktopEl = document.getElementById("desktop");

  // --- Desktop icons ---
  APP_REGISTRY.forEach(app => {
    const iconEl = document.createElement("div");
    iconEl.className = "desktop-icon";
    iconEl.innerHTML = `
      <div class="icon-glyph">${app.icon}</div>
      <div class="icon-label">${app.name}</div>
    `;
    iconEl.addEventListener("click", (e) => {
      document.querySelectorAll(".desktop-icon.selected").forEach(i => i.classList.remove("selected"));
      iconEl.classList.add("selected");
      e.stopPropagation();
    });
    iconEl.addEventListener("dblclick", () => WindowManager.open(app.id));
    iconsEl.appendChild(iconEl);
  });

  desktopEl.addEventListener("click", () => {
    document.querySelectorAll(".desktop-icon.selected").forEach(i => i.classList.remove("selected"));
  });

  // --- Start menu ---
  APP_REGISTRY.forEach(app => {
    const item = document.createElement("div");
    item.className = "start-menu-item";
    item.innerHTML = `<span class="icon-glyph">${app.icon}</span><span>${app.name}</span>`;
    item.addEventListener("click", () => {
      WindowManager.open(app.id);
      startMenuEl.classList.add("hidden");
    });
    startMenuEl.appendChild(item);
  });

  startBtn.addEventListener("click", (e) => {
    startMenuEl.classList.toggle("hidden");
    e.stopPropagation();
  });
  document.addEventListener("click", (e) => {
    if (!startMenuEl.contains(e.target) && e.target !== startBtn) {
      startMenuEl.classList.add("hidden");
    }
  });

  // --- Clock ---
  function tickClock() {
    const now = new Date();
    clockEl.textContent = now.toLocaleTimeString([], { hour: "2-digit", minute: "2-digit" });
  }
  tickClock();
  setInterval(tickClock, 1000 * 15);
})();
