/**
 * AeroWeb — App registry.
 *
 * This is the ONLY place that lists the "apps" shown on the desktop / start
 * menu. For now every entry just opens a placeholder window — real app logic
 * gets wired in later (see plan doc). To add a real app later: replace
 * `render` with the app's actual UI-mounting function.
 *
 * id     : unique string, also used as the window id prefix
 * name   : label shown under the icon / in the start menu / titlebar
 * icon   : any glyph/emoji (swap for real icon assets later)
 * width/height : default window size
 * render : function(bodyEl) -> void, mounts the app UI into the window body
 */
const APP_REGISTRY = [
  { id: "notepad",   name: "Notepad",      icon: "📝", width: 480, height: 360 },
  { id: "calc",      name: "Calculator",   icon: "🧮", width: 300, height: 380 },
  { id: "painter",   name: "Paint",        icon: "🎨", width: 560, height: 420 },
  { id: "notes",     name: "Notes",        icon: "🗒️", width: 420, height: 360 },
  { id: "addbook",   name: "Address Book", icon: "📇", width: 420, height: 400 },
  { id: "alarm",     name: "Alarm Clock",  icon: "⏰", width: 320, height: 280 },
  { id: "dict",      name: "Dictionary",   icon: "📖", width: 460, height: 380 },
  { id: "weather",   name: "Weather",      icon: "⛅", width: 360, height: 340 },
  { id: "rss",       name: "RSS Reader",   icon: "📰", width: 520, height: 420 },
  { id: "imgview",   name: "Image Viewer", icon: "🖼️", width: 520, height: 400 },
  { id: "browser",   name: "Web Browser",  icon: "🌐", width: 640, height: 480 },
  { id: "media",     name: "Media Player", icon: "🎵", width: 420, height: 300 },
  { id: "radio",     name: "Web Radio",    icon: "📻", width: 360, height: 280 },
  { id: "files",     name: "File Manager", icon: "🗂️", width: 560, height: 420 },
  { id: "games",     name: "Games",        icon: "🎮", width: 480, height: 420 },
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
