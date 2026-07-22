/**
 * AeroWeb — Desktop customization (Settings app).
 * Lets the user pick a preset gradient, build a custom two-color gradient,
 * or upload their own background image. Persisted in localStorage so it
 * survives reloads; applied before login so the sign-in screen matches too.
 */
const AeroSettings = (() => {
  const STORAGE_KEY = "aeroweb.desktop.background";
  const desktopEl = document.getElementById("desktop");

  const PRESETS = [
    { id: "default",  label: "Aero Blue", css: "radial-gradient(ellipse at top, #2c5f8a 0%, #0b2033 70%, #061019 100%)" },
    { id: "sunset",   label: "Sunset",    css: "linear-gradient(160deg, #ff9966 0%, #ff5e62 50%, #42275a 100%)" },
    { id: "ocean",    label: "Ocean",     css: "linear-gradient(160deg, #43cea2 0%, #185a9d 100%)" },
    { id: "forest",   label: "Forest",    css: "linear-gradient(160deg, #56ab2f 0%, #0b3d0b 100%)" },
    { id: "midnight", label: "Midnight",  css: "linear-gradient(160deg, #232526 0%, #000000 100%)" },
  ];

  function loadConfig() {
    try {
      const raw = localStorage.getItem(STORAGE_KEY);
      return raw ? JSON.parse(raw) : { mode: "preset", value: "default" };
    } catch (e) {
      return { mode: "preset", value: "default" };
    }
  }

  function saveConfig(cfg) {
    try {
      localStorage.setItem(STORAGE_KEY, JSON.stringify(cfg));
      return true;
    } catch (e) {
      return false;
    }
  }

  function applyBackground(cfg) {
    cfg = cfg || loadConfig();
    if (cfg.mode === "image" && cfg.value) {
      desktopEl.style.backgroundImage = `url(${cfg.value})`;
      desktopEl.style.backgroundSize = "cover";
      desktopEl.style.backgroundPosition = "center";
      desktopEl.style.backgroundRepeat = "no-repeat";
    } else if (cfg.mode === "custom" && cfg.value) {
      desktopEl.style.backgroundImage = cfg.value;
      desktopEl.style.backgroundSize = "";
      desktopEl.style.backgroundPosition = "";
      desktopEl.style.backgroundRepeat = "";
    } else {
      const preset = PRESETS.find(p => p.id === cfg.value) || PRESETS[0];
      desktopEl.style.backgroundImage = preset.css;
      desktopEl.style.backgroundSize = "";
      desktopEl.style.backgroundPosition = "";
      desktopEl.style.backgroundRepeat = "";
    }
  }

  function renderSettingsApp(bodyEl) {
    const cfg = loadConfig();
    bodyEl.innerHTML = `
      <div class="settings-panel">
        <div class="settings-section">
          <div class="settings-label">Preset gradients</div>
          <div class="preset-grid">
            ${PRESETS.map(p => `
              <div class="preset-swatch${cfg.mode === "preset" && cfg.value === p.id ? " active" : ""}"
                   data-preset="${p.id}" style="background:${p.css}" title="${p.label}"></div>
            `).join("")}
          </div>
        </div>
        <div class="settings-section">
          <div class="settings-label">Custom gradient</div>
          <div class="custom-gradient-row">
            <input type="color" id="grad-color-1" value="#2c5f8a" title="Start color">
            <input type="color" id="grad-color-2" value="#061019" title="End color">
            <button id="apply-custom-gradient" class="settings-btn" type="button">Apply</button>
          </div>
        </div>
        <div class="settings-section">
          <div class="settings-label">Upload image</div>
          <input type="file" id="bg-upload" accept="image/*">
        </div>
        <div class="settings-section">
          <button id="reset-bg" class="settings-btn secondary" type="button">Reset to default</button>
        </div>
      </div>
    `;

    bodyEl.querySelectorAll(".preset-swatch").forEach(sw => {
      sw.addEventListener("click", () => {
        const next = { mode: "preset", value: sw.dataset.preset };
        saveConfig(next);
        applyBackground(next);
        bodyEl.querySelectorAll(".preset-swatch").forEach(s => s.classList.remove("active"));
        sw.classList.add("active");
      });
    });

    bodyEl.querySelector("#apply-custom-gradient").addEventListener("click", () => {
      const c1 = bodyEl.querySelector("#grad-color-1").value;
      const c2 = bodyEl.querySelector("#grad-color-2").value;
      const next = { mode: "custom", value: `linear-gradient(160deg, ${c1} 0%, ${c2} 100%)` };
      saveConfig(next);
      applyBackground(next);
      bodyEl.querySelectorAll(".preset-swatch").forEach(s => s.classList.remove("active"));
    });

    bodyEl.querySelector("#bg-upload").addEventListener("change", (e) => {
      const file = e.target.files[0];
      if (!file) return;
      const reader = new FileReader();
      reader.onload = () => {
        const next = { mode: "image", value: reader.result };
        const ok = saveConfig(next);
        if (!ok) {
          alert("That image is too large to save locally. Try a smaller one.");
          return;
        }
        applyBackground(next);
        bodyEl.querySelectorAll(".preset-swatch").forEach(s => s.classList.remove("active"));
      };
      reader.readAsDataURL(file);
    });

    bodyEl.querySelector("#reset-bg").addEventListener("click", () => {
      const next = { mode: "preset", value: "default" };
      saveConfig(next);
      applyBackground(next);
      renderSettingsApp(bodyEl);
    });
  }

  function init() {
    applyBackground();
    const settingsApp = APP_REGISTRY.find(a => a.id === "settings");
    if (settingsApp) settingsApp.render = renderSettingsApp;
  }

  return { init, applyBackground };
})();
