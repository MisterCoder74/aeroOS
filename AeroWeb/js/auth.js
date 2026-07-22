/**
 * AeroWeb — Login & session recognition.
 * DEMO-GRADE ONLY: usernames/passwords are stored in localStorage in plain
 * text (no hashing yet, per explicit instruction) — this is a placeholder
 * until a real backend with proper auth exists. Do not reuse real passwords.
 */
const AeroAuth = (() => {
  const USERS_KEY = "aeroweb.users";
  const SESSION_KEY = "aeroweb.session";
  let onAuthCallback = null;

  function loadUsers() {
    try {
      return JSON.parse(localStorage.getItem(USERS_KEY)) || [];
    } catch (e) {
      return [];
    }
  }

  function saveUsers(users) {
    localStorage.setItem(USERS_KEY, JSON.stringify(users));
  }

  function currentUser() {
    return localStorage.getItem(SESSION_KEY);
  }

  function logout() {
    localStorage.removeItem(SESSION_KEY);
    location.reload();
  }

  function renderLoginForm(mode) {
    let overlay = document.getElementById("login-overlay");
    if (!overlay) {
      overlay = document.createElement("div");
      overlay.id = "login-overlay";
      document.body.appendChild(overlay);
    }

    overlay.innerHTML = `
      <div class="login-box">
        <div class="login-logo">◆ AeroWeb</div>
        <h2>${mode === "register" ? "Create account" : "Sign in"}</h2>
        <form id="login-form" autocomplete="off">
          <input type="text" id="login-username" placeholder="Username" autocomplete="username" required>
          <input type="password" id="login-password" placeholder="Password"
                 autocomplete="${mode === "register" ? "new-password" : "current-password"}" required>
          <div id="login-error" class="login-error hidden"></div>
          <button type="submit" class="settings-btn">${mode === "register" ? "Create account" : "Sign in"}</button>
        </form>
        <div class="login-switch">
          ${mode === "register"
            ? `Already have an account? <a href="#" id="switch-auth-mode">Sign in</a>`
            : `No account yet? <a href="#" id="switch-auth-mode">Create one</a>`}
        </div>
        <div class="login-note">Demo login — stored locally in plain text, no password hashing yet.</div>
      </div>
    `;

    overlay.querySelector("#login-form").addEventListener("submit", (e) => {
      e.preventDefault();
      const username = overlay.querySelector("#login-username").value.trim();
      const password = overlay.querySelector("#login-password").value;
      const errorEl = overlay.querySelector("#login-error");
      errorEl.classList.add("hidden");
      if (!username || !password) return;

      const users = loadUsers();
      if (mode === "register") {
        if (users.some(u => u.username.toLowerCase() === username.toLowerCase())) {
          errorEl.textContent = "That username is already taken.";
          errorEl.classList.remove("hidden");
          return;
        }
        users.push({ username, password });
        saveUsers(users);
        localStorage.setItem(SESSION_KEY, username);
        overlay.remove();
        onAuthCallback(username);
      } else {
        const match = users.find(u =>
          u.username.toLowerCase() === username.toLowerCase() && u.password === password
        );
        if (!match) {
          errorEl.textContent = "Incorrect username or password.";
          errorEl.classList.remove("hidden");
          return;
        }
        localStorage.setItem(SESSION_KEY, match.username);
        overlay.remove();
        onAuthCallback(match.username);
      }
    });

    overlay.querySelector("#switch-auth-mode").addEventListener("click", (e) => {
      e.preventDefault();
      renderLoginForm(mode === "register" ? "login" : "register");
    });
  }

  function init(onAuth) {
    onAuthCallback = onAuth;
    const existing = currentUser();
    if (existing) {
      onAuthCallback(existing);
      return;
    }
    renderLoginForm(loadUsers().length === 0 ? "register" : "login");
  }

  return { init, logout, currentUser };
})();
