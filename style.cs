@tailwind base;
@tailwind components;
@tailwind utilities;

body {
  font-family: 'Segoe UI', system-ui, sans-serif;
}

.header-top {
  background: linear-gradient(to right, #1a1a1a, #2d2d2d);
}

.main-header {
  background-color: #0f172a; /* Azul escuro */
}

.bordô {
  color: #8b2a2a;
}

/* Hover effects */
.group:hover .fa-mobile-alt,
.group:hover .fa-headphones,
.group:hover .fa-battery-full,
.group:hover .fa-microchip,
.group:hover .fa-tools,
.group:hover .fa-desktop,
.group:hover .fa-gamepad,
.group:hover .fa-tablet-alt {
  color: #1e40af;
  transform: scale(1.1);
}