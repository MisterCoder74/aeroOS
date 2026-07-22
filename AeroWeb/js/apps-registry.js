/**
 * AeroWeb — App registry.
 *
 * This is the ONLY place that lists the "apps" shown on the desktop / start
 * menu. For now every entry just opens a placeholder window — real app logic
 * gets wired in later (see plan doc). To add a real app later: replace
 * `render` with the app's actual UI-mounting function.
 *
 * id       : unique string, also used as the window id prefix
 * name     : label shown under the icon / in the start menu / titlebar
 * icon     : any glyph/emoji (swap for real icon assets later)
 * category : group used to organize the Start menu (Office, Media, Internet,
 *            Tools, Games, Management, System)
 * width/height : default window size
 * render   : function(bodyEl) -> void, mounts the app UI into the window body
 *
 * NOTE: "settings" has no default render below — settings.js finds it by id
 * and installs the real desktop-customization UI on top of it.
 */
const APP_REGISTRY = [
  { id: "notepad",   name: "Notepad",      icon: "📝", category: "Office",     width: 480, height: 360 },
  { id: "calc",      name: "Calculator",   icon: "🧮", category: "Tools",      width: 300, height: 380 },
  { id: "painter",   name: "Paint",        icon: "🎨", category: "Media",      width: 560, height: 420 },
  { id: "notes",     name: "Notes",        icon: "🗒️", category: "Office",     width: 420, height: 360 },
  { id: "addbook",   name: "Address Book", icon: "📇", category: "Management", width: 420, height: 400 },
  { id: "alarm",     name: "Alarm Clock",  icon: "⏰", category: "Tools",      width: 320, height: 280 },
  { id: "dict",      name: "Dictionary",   icon: "📖", category: "Tools",      width: 460, height: 380 },
  { id: "weather",   name: "Weather",      icon: "⛅", category: "Tools",      width: 360, height: 340 },
  { id: "rss",       name: "RSS Reader",   icon: "📰", category: "Media",      width: 520, height: 420 },
  { id: "imgview",   name: "Image Viewer", icon: "🖼️", category: "Media",      width: 520, height: 400 },
  { id: "browser",   name: "Web Browser",  icon: "🌐", category: "Internet",   width: 640, height: 480 },
  { id: "media",     name: "Media Player", icon: "🎵", category: "Media",      width: 420, height: 300 },
  { id: "radio",     name: "Web Radio",    icon: "📻", category: "Media",      width: 360, height: 280 },
  { id: "files",     name: "File Manager", icon: "🗂️", category: "Management", width: 560, height: 420 },
  { id: "games",     name: "Games",        icon: "🎮", category: "Games",      width: 480, height: 420 },
  { id: "settings",  name: "Settings",     icon: "⚙️", category: "System",     width: 460, height: 480 },
].map(app => ({
  ...app,
  render(bodyEl) {
    bodyEl.innerHTML = `
      <div style="display:flex;flex-direction:column;align-items:center;
                  justify-content:center;height:100%;color:#667;gap:8px;">
        <div style="font-size:40px;">${app.icon}</div>
        <div style="font-weight:600;">${app.name}</div>
        <div style="font-size:12px;">Coming soon — shell only for now.</div>
      </div>`;
  }
}));

/** Start-menu category display order. Anything not listed falls back to the end. */
const APP_CATEGORY_ORDER = ["Office", "Media", "Internet", "Tools", "Games", "Management", "System"];
