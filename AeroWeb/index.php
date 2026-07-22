<!DOCTYPE html>
<html lang="en">
<head>
<meta charset="UTF-8">
<meta name="viewport" content="width=device-width, initial-scale=1.0">
<title>AeroWeb</title>
<link rel="stylesheet" href="css/style.css?v=<?php echo time(); ?>">
</head>
<body>

  <div id="desktop">

    <div id="icons"></div>

    <div id="windows-layer"></div>

    <div id="taskbar">
      <button id="start-btn">
        <span class="logo">◆</span> Aero
      </button>
      <div id="taskbar-apps"></div>
      <div id="status-icons">
        <span id="network-status" class="status-icon">📶</span>
        <span id="battery-status" class="status-icon">🔋</span>
      </div>
      <div id="clock"></div>
      <div id="user-chip"></div>
    </div>

    <div id="start-menu" class="hidden"></div>

  </div>

  <script src="js/apps-registry.js?v=<?php echo time(); ?>"></script>
  <script src="js/window-manager.js?v=<?php echo time(); ?>"></script>
  <script src="js/settings.js?v=<?php echo time(); ?>"></script>
  <script src="js/auth.js?v=<?php echo time(); ?>"></script>
  <script src="js/shell.js?v=<?php echo time(); ?>"></script>
  <script>
    AeroSettings.init();
    AeroAuth.init(function (username) {
      AeroShell.init(username);
    });
  </script>
</body>
</html>
