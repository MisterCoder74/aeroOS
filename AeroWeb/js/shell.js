/**
 * AeroWeb — Desktop shell bootstrap.
 * Renders desktop icons + categorized start menu from APP_REGISTRY, wires
 * taskbar clock (with seconds), battery/network status, and the logged-in
 * user chip. Window behavior lives in window-manager.js. Call
 * AeroShell.init(username) once a session is confirmed (see auth.js).
 */
const AeroShell = (() => {
  function init(username) {
    const iconsEl = document.getElementById("icons");
    const startMenuEl = document.getElementById("start-menu");
    const startBtn = document.getElementById("start-btn");
    const clockEl = document.getElementById("clock");
    const desktopEl = document.getElementById("desktop");
    const userChipEl = document.getElementById("user-chip");

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

    // --- Start menu, grouped by category with <hr> separators ---
    const byCategory = {};
    APP_REGISTRY.forEach(app => {
      const cat = app.category || "Other";
      (byCategory[cat] = byCategory[cat] || []).push(app);
    });
    const orderedCats = [
      ...APP_CATEGORY_ORDER.filter(c => byCategory[c]),
      ...Object.keys(byCategory).filter(c => !APP_CATEGORY_ORDER.includes(c)),
    ];

    orderedCats.forEach((cat, idx) => {
      if (idx > 0) startMenuEl.appendChild(document.createElement("hr"));
      const header = document.createElement("div");
      header.className = "start-menu-category";
      header.textContent = cat;
      startMenuEl.appendChild(header);

      byCategory[cat].forEach(app => {
        const item = document.createElement("div");
        item.className = "start-menu-item";
        item.innerHTML = `<span class="icon-glyph">${app.icon}</span><span>${app.name}</span>`;
        item.addEventListener("click", () => {
          WindowManager.open(app.id);
          startMenuEl.classList.add("hidden");
        });
        startMenuEl.appendChild(item);
      });
    });

    startMenuEl.appendChild(document.createElement("hr"));
    const logoutItem = document.createElement("div");
    logoutItem.className = "start-menu-item";
    logoutItem.innerHTML = `<span class="icon-glyph">🚪</span><span>Sign out</span>`;
    logoutItem.addEventListener("click", () => AeroAuth.logout());
    startMenuEl.appendChild(logoutItem);

    startBtn.addEventListener("click", (e) => {
      startMenuEl.classList.toggle("hidden");
      e.stopPropagation();
    });
    document.addEventListener("click", (e) => {
      if (!startMenuEl.contains(e.target) && e.target !== startBtn) {
        startMenuEl.classList.add("hidden");
      }
    });

    // --- User chip ---
    if (userChipEl) {
      userChipEl.textContent = `👤 ${username}`;
      userChipEl.title = "Signed in as " + username + " — click to sign out";
      userChipEl.addEventListener("click", () => AeroAuth.logout());
    }

    // --- Clock (with seconds) ---
    function tickClock() {
      const now = new Date();
      clockEl.textContent = now.toLocaleTimeString([], {
        hour: "2-digit", minute: "2-digit", second: "2-digit"
      });
    }
    tickClock();
    setInterval(tickClock, 1000);

    // --- Battery status ---
    initBatteryStatus();

    // --- Network status ---
    initNetworkStatus();
  }

  function initBatteryStatus() {
    const el = document.getElementById("battery-status");
    if (!el) return;
    if (!navigator.getBattery) {
      el.textContent = "🔋";
      el.title = "Battery status not supported in this browser";
      return;
    }
    navigator.getBattery().then(battery => {
      function update() {
        const pct = Math.round(battery.level * 100);
        el.textContent = battery.charging ? "⚡" : (pct <= 20 ? "🪫" : "🔋");
        el.title = `Battery: ${pct}%${battery.charging ? " (charging)" : ""}`;
      }
      update();
      battery.addEventListener("levelchange", update);
      battery.addEventListener("chargingchange", update);
    }).catch(() => {
      el.textContent = "🔋";
      el.title = "Battery status unavailable";
    });
  }

  function initNetworkStatus() {
    const el = document.getElementById("network-status");
    if (!el) return;

    async function probe() {
      if (!navigator.onLine) return false;
      try {
        const ctrl = new AbortController();
        const timer = setTimeout(() => ctrl.abort(), 2500);
        await fetch(location.href, { method: "HEAD", cache: "no-store", signal: ctrl.signal });
        clearTimeout(timer);
        return true;
      } catch (e) {
        return false;
      }
    }

    async function update() {
      const online = await probe();
      el.textContent = online ? "📶" : "📴";
      el.title = online ? "Connected" : "Offline";
    }

    update();
    window.addEventListener("online", update);
    window.addEventListener("offline", update);
    setInterval(update, 30000);
  }

  return { init };
})();
