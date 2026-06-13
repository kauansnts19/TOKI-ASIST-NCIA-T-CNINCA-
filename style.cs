/* ============================================================
   TOKI.CO — Stylesheet
   Tipografia: Space Grotesk (títulos) + Inter (corpo) + Space Mono (mono)
   Paleta: #0F0F0F / #001F5E / #0047CC / #F0F0F0 / #888
   ============================================================ */

/* ---------- Reset & Base ---------- */
*, *::before, *::after { box-sizing: border-box; margin: 0; padding: 0; }

:root {
  --black:       #0F0F0F;
  --black-soft:  #161616;
  --black-card:  #1A1A1A;
  --blue-deep:   #001F5E;
  --blue-mid:    #0033A0;
  --blue-bright: #0047CC;
  --blue-glow:   rgba(0, 71, 204, 0.18);
  --white:       #F0F0F0;
  --white-off:   #C8C8CC;
  --grey:        #888;
  --grey-dim:    #444;
  --border:      rgba(255,255,255,0.07);
  --border-blue: rgba(0,71,204,0.35);

  --font-display: 'Space Grotesk', sans-serif;
  --font-body:    'Inter', sans-serif;
  --font-mono:    'Space Mono', monospace;

  --nav-h: 68px;
  --radius: 4px;
  --radius-lg: 8px;
  --transition: 0.25s ease;
}

html { scroll-behavior: smooth; font-size: 16px; }

body {
  background-color: var(--black);
  color: var(--white);
  font-family: var(--font-body);
  line-height: 1.65;
  overflow-x: hidden;
  -webkit-font-smoothing: antialiased;
}

a { text-decoration: none; color: inherit; }
img { max-width: 100%; display: block; }
button, select, input, textarea { font-family: var(--font-body); }
ul { list-style: none; }

/* ---------- Scrollbar ---------- */
::-webkit-scrollbar { width: 6px; }
::-webkit-scrollbar-track { background: var(--black); }
::-webkit-scrollbar-thumb { background: var(--blue-mid); border-radius: 3px; }

/* ---------- Container ---------- */
.container {
  max-width: 1200px;
  margin: 0 auto;
  padding: 0 24px;
}

/* ---------- Buttons ---------- */
.btn-primary {
  display: inline-block;
  background: var(--blue-bright);
  color: #fff;
  padding: 13px 28px;
  font-family: var(--font-display);
  font-weight: 600;
  font-size: 0.9rem;
  letter-spacing: 0.02em;
  border: none;
  border-radius: var(--radius);
  cursor: pointer;
  transition: background var(--transition), transform var(--transition), box-shadow var(--transition);
}
.btn-primary:hover {
  background: var(--blue-mid);
  transform: translateY(-1px);
  box-shadow: 0 8px 24px rgba(0,71,204,0.35);
}

.btn-ghost {
  display: inline-block;
  background: transparent;
  color: var(--white);
  padding: 13px 28px;
  font-family: var(--font-display);
  font-weight: 500;
  font-size: 0.9rem;
  border: 1px solid var(--border);
  border-radius: var(--radius);
  cursor: pointer;
  transition: border-color var(--transition), color var(--transition);
}
.btn-ghost:hover { border-color: var(--blue-bright); color: var(--blue-bright); }

.btn-outline {
  display: inline-block;
  background: transparent;
  color: var(--blue-bright);
  padding: 10px 22px;
  font-family: var(--font-display);
  font-weight: 600;
  font-size: 0.82rem;
  letter-spacing: 0.04em;
  text-transform: uppercase;
  border: 1px solid var(--blue-bright);
  border-radius: var(--radius);
  cursor: pointer;
  transition: background var(--transition), color var(--transition);
}
.btn-outline:hover { background: var(--blue-bright); color: #fff; }

.btn-full { width: 100%; text-align: center; }

/* ---------- Section Shared ---------- */
.section { padding: 96px 0; }
.section-alt { background: var(--black-soft); }

.section-header {
  text-align: center;
  max-width: 680px;
  margin: 0 auto 64px;
}

.section-tag {
  display: inline-block;
  font-family: var(--font-mono);
  font-size: 0.72rem;
  letter-spacing: 0.14em;
  text-transform: uppercase;
  color: var(--blue-bright);
  border: 1px solid var(--border-blue);
  padding: 4px 12px;
  border-radius: 20px;
  margin-bottom: 20px;
}

.section-title {
  font-family: var(--font-display);
  font-size: clamp(1.8rem, 4vw, 2.8rem);
  font-weight: 700;
  line-height: 1.2;
  letter-spacing: -0.02em;
  color: var(--white);
  margin-bottom: 18px;
}

.section-desc {
  font-size: 1.0rem;
  color: var(--grey);
  line-height: 1.75;
}

/* ---------- Reveal Animations ---------- */
.reveal {
  opacity: 0;
  transform: translateY(28px);
  transition: opacity 0.6s ease, transform 0.6s ease;
}
.reveal.visible {
  opacity: 1;
  transform: translateY(0);
}
@media (prefers-reduced-motion: reduce) {
  .reveal { opacity: 1; transform: none; transition: none; }
}

/* ============================================================
   NAVBAR
   ============================================================ */
.navbar {
  position: fixed;
  top: 0; left: 0; right: 0;
  z-index: 1000;
  height: var(--nav-h);
  background: rgba(15,15,15,0.82);
  backdrop-filter: blur(16px);
  -webkit-backdrop-filter: blur(16px);
  border-bottom: 1px solid var(--border);
  transition: background var(--transition), box-shadow var(--transition);
}
.navbar.scrolled {
  background: rgba(15,15,15,0.97);
  box-shadow: 0 2px 30px rgba(0,0,0,0.5);
}

.nav-container {
  max-width: 1200px;
  margin: 0 auto;
  padding: 0 24px;
  height: 100%;
  display: flex;
  align-items: center;
  justify-content: space-between;
  gap: 24px;
}

.nav-logo {
  font-family: var(--font-display);
  font-size: 1.5rem;
  font-weight: 700;
  letter-spacing: -0.04em;
  color: var(--white);
  flex-shrink: 0;
}
.logo-dot { color: var(--blue-bright); }

.nav-links {
  display: flex;
  align-items: center;
  gap: 2px;
}
.nav-link {
  font-family: var(--font-display);
  font-size: 0.88rem;
  font-weight: 500;
  color: var(--grey);
  padding: 8px 14px;
  border-radius: var(--radius);
  transition: color var(--transition), background var(--transition);
}
.nav-link:hover, .nav-link.active {
  color: var(--white);
  background: rgba(255,255,255,0.05);
}

.nav-actions { display: flex; align-items: center; gap: 12px; flex-shrink: 0; }

/* Cart Button */
.cart-btn {
  position: relative;
  background: transparent;
  border: 1px solid var(--border);
  color: var(--white);
  width: 40px;
  height: 40px;
  border-radius: var(--radius);
  cursor: pointer;
  display: flex;
  align-items: center;
  justify-content: center;
  transition: border-color var(--transition), background var(--transition);
}
.cart-btn:hover { border-color: var(--blue-bright); background: var(--blue-glow); }
.cart-count {
  position: absolute;
  top: -7px; right: -7px;
  background: var(--blue-bright);
  color: #fff;
  font-size: 0.62rem;
  font-weight: 700;
  min-width: 18px;
  height: 18px;
  border-radius: 9px;
  display: flex;
  align-items: center;
  justify-content: center;
  padding: 0 4px;
  line-height: 1;
}

/* Hamburger */
.hamburger {
  display: none;
  flex-direction: column;
  gap: 5px;
  background: none;
  border: none;
  cursor: pointer;
  padding: 6px;
}
.hamburger span {
  display: block;
  width: 22px;
  height: 2px;
  background: var(--white);
  border-radius: 2px;
  transition: transform var(--transition), opacity var(--transition);
}
.hamburger.open span:nth-child(1) { transform: translateY(7px) rotate(45deg); }
.hamburger.open span:nth-child(2) { opacity: 0; }
.hamburger.open span:nth-child(3) { transform: translateY(-7px) rotate(-45deg); }

/* ============================================================
   CART SIDEBAR
   ============================================================ */
.cart-overlay {
  position: fixed;
  inset: 0;
  background: rgba(0,0,0,0.6);
  z-index: 1100;
  opacity: 0;
  pointer-events: none;
  transition: opacity var(--transition);
}
.cart-overlay.active { opacity: 1; pointer-events: all; }

.cart-sidebar {
  position: fixed;
  top: 0; right: 0; bottom: 0;
  width: min(380px, 92vw);
  background: #111;
  border-left: 1px solid var(--border);
  z-index: 1200;
  transform: translateX(100%);
  transition: transform 0.35s cubic-bezier(0.4,0,0.2,1);
  display: flex;
  flex-direction: column;
}
.cart-sidebar.open { transform: translateX(0); }

.cart-header {
  display: flex;
  align-items: center;
  justify-content: space-between;
  padding: 20px 24px;
  border-bottom: 1px solid var(--border);
}
.cart-title {
  font-family: var(--font-display);
  font-weight: 700;
  font-size: 1.1rem;
}
.cart-close {
  background: none;
  border: none;
  color: var(--grey);
  font-size: 1.1rem;
  cursor: pointer;
  padding: 4px 8px;
  transition: color var(--transition);
}
.cart-close:hover { color: var(--white); }

.cart-items { flex: 1; overflow-y: auto; padding: 16px 24px; }
.cart-empty { color: var(--grey); font-size: 0.9rem; padding: 20px 0; }

.cart-item {
  display: flex;
  gap: 12px;
  align-items: flex-start;
  padding: 14px 0;
  border-bottom: 1px solid var(--border);
}
.cart-item-info { flex: 1; }
.cart-item-name { font-size: 0.88rem; font-weight: 500; margin-bottom: 4px; }
.cart-item-price { font-size: 0.82rem; color: var(--blue-bright); }
.cart-item-qty { display: flex; align-items: center; gap: 8px; margin-top: 8px; }
.qty-btn {
  background: var(--black-card);
  border: 1px solid var(--border);
  color: var(--white);
  width: 24px;
  height: 24px;
  border-radius: 2px;
  cursor: pointer;
  font-size: 0.9rem;
  display: flex;
  align-items: center;
  justify-content: center;
  transition: background var(--transition);
}
.qty-btn:hover { background: var(--blue-glow); border-color: var(--blue-bright); }
.qty-num { font-size: 0.82rem; min-width: 20px; text-align: center; }
.cart-item-remove { background: none; border: none; color: var(--grey); cursor: pointer; font-size: 1rem; padding: 0; transition: color var(--transition); }
.cart-item-remove:hover { color: #e05; }

.cart-footer {
  padding: 20px 24px;
  border-top: 1px solid var(--border);
  display: flex;
  flex-direction: column;
  gap: 14px;
}
.cart-total {
  display: flex;
  justify-content: space-between;
  align-items: center;
  font-family: var(--font-display);
  font-weight: 600;
}
#cartTotal { font-size: 1.25rem; color: var(--white); }

/* ============================================================
   HERO
   ============================================================ */
.hero {
  position: relative;
  min-height: 100vh;
  display: flex;
  align-items: center;
  overflow: hidden;
  background: var(--black);
  padding-top: var(--nav-h);
}

.hero-canvas {
  position: absolute;
  inset: 0;
  width: 100%;
  height: 100%;
  pointer-events: none;
}

/* Diagonal scan-line grid overlay — the signature element */
.hero-grid-overlay {
  position: absolute;
  inset: 0;
  pointer-events: none;
  background-image:
    linear-gradient(rgba(0,71,204,0.04) 1px, transparent 1px),
    linear-gradient(90deg, rgba(0,71,204,0.04) 1px, transparent 1px);
  background-size: 44px 44px;
  mask-image: radial-gradient(ellipse 70% 70% at 60% 50%, rgba(0,0,0,0.8) 0%, transparent 100%);
}

.hero-content {
  position: relative;
  z-index: 2;
  padding-top: 60px;
  padding-bottom: 60px;
  max-width: 820px;
}

.hero-eyebrow {
  display: flex;
  align-items: center;
  gap: 10px;
  font-family: var(--font-mono);
  font-size: 0.72rem;
  letter-spacing: 0.1em;
  text-transform: uppercase;
  color: var(--grey);
  margin-bottom: 28px;
}
.eyebrow-dot {
  width: 7px;
  height: 7px;
  border-radius: 50%;
  background: var(--blue-bright);
  animation: pulse 2s ease-in-out infinite;
}
@keyframes pulse {
  0%, 100% { box-shadow: 0 0 0 0 rgba(0,71,204,0.6); }
  50% { box-shadow: 0 0 0 6px rgba(0,71,204,0); }
}

.hero-title {
  font-family: var(--font-display);
  font-size: clamp(2.4rem, 7vw, 5rem);
  font-weight: 700;
  line-height: 1.07;
  letter-spacing: -0.04em;
  color: var(--white);
  margin-bottom: 26px;
}
.hero-title em {
  font-style: normal;
  color: var(--blue-bright);
  position: relative;
}

.hero-subtitle {
  font-size: clamp(0.95rem, 1.5vw, 1.1rem);
  color: var(--grey);
  line-height: 1.75;
  max-width: 540px;
  margin-bottom: 40px;
}
.br-desktop { display: block; }

.hero-cta {
  display: flex;
  gap: 14px;
  flex-wrap: wrap;
  margin-bottom: 64px;
}

.hero-stats {
  display: flex;
  align-items: center;
  gap: 32px;
  flex-wrap: wrap;
}
.stat { display: flex; flex-direction: column; gap: 3px; }
.stat-num {
  font-family: var(--font-display);
  font-size: 1.5rem;
  font-weight: 700;
  color: var(--white);
  letter-spacing: -0.03em;
}
.stat-label { font-size: 0.78rem; color: var(--grey); }
.stat-divider { width: 1px; height: 36px; background: var(--border); }

.hero-scroll {
  position: absolute;
  bottom: 36px;
  left: 24px;
  display: flex;
  flex-direction: column;
  align-items: center;
  gap: 8px;
  z-index: 2;
}
.hero-scroll span {
  font-family: var(--font-mono);
  font-size: 0.65rem;
  letter-spacing: 0.15em;
  text-transform: uppercase;
  color: var(--grey-dim);
  writing-mode: vertical-rl;
}
.scroll-line {
  width: 1px;
  height: 48px;
  background: linear-gradient(to bottom, var(--grey-dim), transparent);
  animation: scrollDown 2s ease-in-out infinite;
}
@keyframes scrollDown {
  0%, 100% { transform: scaleY(1); opacity: 0.5; }
  50% { transform: scaleY(0.5); opacity: 1; }
}

/* ============================================================
   REPAROS
   ============================================================ */
.repair-grid {
  display: grid;
  grid-template-columns: repeat(auto-fit, minmax(250px, 1fr));
  gap: 24px;
}

.repair-card {
  position: relative;
  background: var(--black-card);
  border: 1px solid var(--border);
  border-radius: var(--radius-lg);
  padding: 32px 28px;
  display: flex;
  flex-direction: column;
  gap: 0;
  overflow: hidden;
  transition: border-color var(--transition), box-shadow var(--transition), transform var(--transition);
}
.repair-card:hover {
  border-color: var(--blue-bright);
  box-shadow: 0 0 32px rgba(0,71,204,0.12), 0 8px 24px rgba(0,0,0,0.4);
  transform: translateY(-3px);
}

/* Left border accent line */
.repair-card-accent {
  position: absolute;
  left: 0; top: 20%; bottom: 20%;
  width: 3px;
  background: var(--blue-bright);
  border-radius: 0 2px 2px 0;
  opacity: 0;
  transition: opacity var(--transition), top var(--transition), bottom var(--transition);
}
.repair-card:hover .repair-card-accent { opacity: 1; top: 10%; bottom: 10%; }

.repair-icon {
  width: 52px;
  height: 52px;
  background: var(--blue-glow);
  border: 1px solid var(--border-blue);
  border-radius: var(--radius);
  display: flex;
  align-items: center;
  justify-content: center;
  color: var(--blue-bright);
  margin-bottom: 20px;
}

.repair-title {
  font-family: var(--font-display);
  font-size: 1.15rem;
  font-weight: 700;
  margin-bottom: 10px;
}

.repair-desc {
  font-size: 0.88rem;
  color: var(--grey);
  line-height: 1.65;
  margin-bottom: 20px;
}

.repair-list {
  display: flex;
  flex-direction: column;
  gap: 7px;
  margin-bottom: 28px;
  flex: 1;
}
.repair-list li {
  font-size: 0.82rem;
  color: var(--white-off);
  padding-left: 16px;
  position: relative;
}
.repair-list li::before {
  content: '';
  position: absolute;
  left: 0;
  top: 50%;
  transform: translateY(-50%);
  width: 5px;
  height: 5px;
  border-radius: 50%;
  background: var(--blue-bright);
  opacity: 0.7;
}

/* ============================================================
   PRODUTOS
   ============================================================ */
.product-filters {
  display: flex;
  gap: 8px;
  flex-wrap: wrap;
  justify-content: center;
  margin-bottom: 40px;
}
.filter-btn {
  background: transparent;
  border: 1px solid var(--border);
  color: var(--grey);
  padding: 8px 20px;
  font-family: var(--font-display);
  font-size: 0.82rem;
  font-weight: 500;
  border-radius: 20px;
  cursor: pointer;
  transition: all var(--transition);
}
.filter-btn:hover, .filter-btn.active {
  background: var(--blue-bright);
  border-color: var(--blue-bright);
  color: #fff;
}

.products-grid {
  display: grid;
  grid-template-columns: repeat(auto-fill, minmax(280px, 1fr));
  gap: 24px;
}

.product-card {
  background: var(--black-card);
  border: 1px solid var(--border);
  border-radius: var(--radius-lg);
  overflow: hidden;
  position: relative;
  display: flex;
  flex-direction: column;
  transition: border-color var(--transition), box-shadow var(--transition), transform var(--transition);
}
.product-card:hover {
  border-color: var(--blue-bright);
  box-shadow: 0 8px 32px rgba(0,71,204,0.15);
  transform: translateY(-4px);
}
.product-card.hidden { display: none; }

.product-badge {
  position: absolute;
  top: 12px;
  left: 12px;
  background: var(--blue-bright);
  color: #fff;
  font-family: var(--font-mono);
  font-size: 0.65rem;
  letter-spacing: 0.06em;
  text-transform: uppercase;
  padding: 3px 10px;
  border-radius: 3px;
  z-index: 1;
}
.product-badge.new { background: #0a8a50; }

.product-img {
  background: #111;
  padding: 30px;
  border-bottom: 1px solid var(--border);
}
.product-img svg { width: 100%; height: auto; }

.product-info {
  padding: 20px;
  display: flex;
  flex-direction: column;
  gap: 6px;
  flex: 1;
}
.product-cat {
  font-family: var(--font-mono);
  font-size: 0.68rem;
  letter-spacing: 0.1em;
  text-transform: uppercase;
  color: var(--blue-bright);
}
.product-name {
  font-family: var(--font-display);
  font-size: 0.98rem;
  font-weight: 700;
  line-height: 1.3;
}
.product-desc { font-size: 0.8rem; color: var(--grey); line-height: 1.55; }
.product-footer {
  display: flex;
  align-items: center;
  justify-content: space-between;
  gap: 12px;
  margin-top: auto;
  padding-top: 16px;
}
.product-price {
  font-family: var(--font-display);
  font-size: 1.1rem;
  font-weight: 700;
  color: var(--white);
}
.btn-cart {
  background: var(--blue-glow);
  border: 1px solid var(--border-blue);
  color: var(--blue-bright);
  padding: 8px 14px;
  font-family: var(--font-display);
  font-size: 0.78rem;
  font-weight: 600;
  border-radius: var(--radius);
  cursor: pointer;
  white-space: nowrap;
  transition: background var(--transition), color var(--transition);
}
.btn-cart:hover { background: var(--blue-bright); color: #fff; }

/* ============================================================
   CONFIGURADOR DE PC
   ============================================================ */
.builder-layout {
  display: grid;
  grid-template-columns: 1fr 340px;
  gap: 32px;
  align-items: start;
}

.builder-components { display: flex; flex-direction: column; gap: 12px; }

.builder-category {
  background: var(--black-card);
  border: 1px solid var(--border);
  border-radius: var(--radius-lg);
  padding: 18px 22px;
  display: grid;
  grid-template-columns: 1fr;
  gap: 14px;
  transition: border-color var(--transition);
}
.builder-category:has(.builder-select:focus),
.builder-category:has(.builder-select:not([value=""])) {
  border-color: var(--border-blue);
}

.builder-cat-header {
  display: flex;
  align-items: center;
  gap: 12px;
}
.builder-icon {
  width: 36px;
  height: 36px;
  background: var(--blue-glow);
  border: 1px solid var(--border-blue);
  border-radius: var(--radius);
  display: flex;
  align-items: center;
  justify-content: center;
  color: var(--blue-bright);
  flex-shrink: 0;
}
.builder-cat-name {
  font-family: var(--font-display);
  font-size: 0.92rem;
  font-weight: 600;
}

.builder-select {
  width: 100%;
  background: var(--black);
  border: 1px solid var(--border);
  color: var(--white);
  padding: 10px 14px;
  font-size: 0.86rem;
  border-radius: var(--radius);
  appearance: none;
  background-image: url("data:image/svg+xml,%3Csvg xmlns='http://www.w3.org/2000/svg' width='14' height='14' viewBox='0 0 24 24' fill='none' stroke='%23888' stroke-width='2'%3E%3Cpath d='M6 9l6 6 6-6'/%3E%3C/svg%3E");
  background-repeat: no-repeat;
  background-position: right 12px center;
  cursor: pointer;
  transition: border-color var(--transition);
}
.builder-select:focus {
  outline: none;
  border-color: var(--blue-bright);
}
.builder-select option { background: #1a1a1a; }

/* Summary card */
.builder-summary { position: sticky; top: calc(var(--nav-h) + 24px); }
.summary-card {
  background: var(--black-card);
  border: 1px solid var(--border);
  border-radius: var(--radius-lg);
  padding: 24px;
  display: flex;
  flex-direction: column;
  gap: 16px;
}
.summary-title {
  font-family: var(--font-display);
  font-size: 1.0rem;
  font-weight: 700;
  padding-bottom: 14px;
  border-bottom: 1px solid var(--border);
}

.summary-list { display: flex; flex-direction: column; gap: 8px; }
.summary-empty { font-size: 0.82rem; color: var(--grey); }
.summary-item {
  display: flex;
  flex-direction: column;
  gap: 2px;
  padding: 8px 0;
  border-bottom: 1px solid var(--border);
}
.si-cat {
  font-family: var(--font-mono);
  font-size: 0.64rem;
  letter-spacing: 0.08em;
  text-transform: uppercase;
  color: var(--grey);
}
.si-name { font-size: 0.82rem; color: var(--white-off); }
.si-price { font-size: 0.85rem; font-weight: 600; color: var(--blue-bright); }

.summary-divider { height: 1px; background: var(--border); }
.summary-total-row {
  display: flex;
  justify-content: space-between;
  align-items: center;
  font-family: var(--font-display);
  font-size: 0.88rem;
  font-weight: 500;
}
.summary-total {
  font-size: 1.4rem;
  font-weight: 700;
  color: var(--blue-bright);
  letter-spacing: -0.02em;
}
.summary-note {
  font-size: 0.72rem;
  color: var(--grey-dim);
  line-height: 1.5;
}

#limparBuild {
  border-color: var(--grey-dim);
  color: var(--grey);
  font-size: 0.82rem;
  padding: 10px;
}
#limparBuild:hover { border-color: #e05; color: #e05; }

/* ============================================================
   DEPOIMENTOS
   ============================================================ */
.testimonials-grid {
  display: grid;
  grid-template-columns: repeat(auto-fit, minmax(300px, 1fr));
  gap: 24px;
}
.testimonial-card {
  background: var(--black-card);
  border: 1px solid var(--border);
  border-radius: var(--radius-lg);
  padding: 32px;
  display: flex;
  flex-direction: column;
  gap: 16px;
  transition: border-color var(--transition), transform var(--transition);
}
.testimonial-card:hover { border-color: var(--border-blue); transform: translateY(-3px); }
.testimonial-stars { color: var(--blue-bright); font-size: 0.9rem; letter-spacing: 2px; }
.testimonial-text {
  font-size: 0.92rem;
  color: var(--white-off);
  line-height: 1.75;
  flex: 1;
  font-style: italic;
}
.testimonial-author { display: flex; align-items: center; gap: 14px; }
.author-avatar {
  width: 40px;
  height: 40px;
  border-radius: 50%;
  background: var(--blue-deep);
  border: 1px solid var(--border-blue);
  display: flex;
  align-items: center;
  justify-content: center;
  font-family: var(--font-display);
  font-size: 0.72rem;
  font-weight: 700;
  color: var(--blue-bright);
  flex-shrink: 0;
}
.author-name { display: block; font-size: 0.88rem; font-weight: 600; }
.author-role { display: block; font-size: 0.75rem; color: var(--grey); }

/* ============================================================
   SOBRE
   ============================================================ */
.about-layout {
  display: grid;
  grid-template-columns: 1fr 1fr;
  gap: 80px;
  align-items: center;
}
.about-text {
  font-size: 0.95rem;
  color: var(--grey);
  line-height: 1.8;
  margin-bottom: 18px;
}
.about-pillars { display: flex; gap: 24px; margin-top: 32px; flex-wrap: wrap; }
.pillar {
  display: flex;
  flex-direction: column;
  align-items: center;
  gap: 6px;
  padding: 14px 20px;
  border: 1px solid var(--border);
  border-radius: var(--radius);
  font-size: 0.82rem;
  font-weight: 500;
  transition: border-color var(--transition);
}
.pillar:hover { border-color: var(--blue-bright); }
.pillar-icon { font-size: 1.2rem; }

.about-card-stack {
  display: grid;
  grid-template-columns: 1fr 1fr;
  gap: 16px;
}
.about-stat-card {
  background: var(--black-card);
  border: 1px solid var(--border);
  border-radius: var(--radius-lg);
  padding: 24px;
  display: flex;
  flex-direction: column;
  gap: 6px;
  transition: border-color var(--transition), transform var(--transition);
}
.about-stat-card:hover { border-color: var(--border-blue); transform: translateY(-3px); }
.asc-number {
  font-family: var(--font-display);
  font-size: 1.8rem;
  font-weight: 700;
  color: var(--blue-bright);
  letter-spacing: -0.04em;
}
.asc-label { font-size: 0.8rem; color: var(--grey); }

/* ============================================================
   CONTATO
   ============================================================ */
.contact-layout {
  display: grid;
  grid-template-columns: 1fr 1.4fr;
  gap: 64px;
  align-items: start;
}

.contact-info { display: flex; flex-direction: column; gap: 28px; padding-top: 8px; }
.contact-item { display: flex; align-items: flex-start; gap: 16px; }
.contact-icon {
  width: 40px;
  height: 40px;
  background: var(--blue-glow);
  border: 1px solid var(--border-blue);
  border-radius: var(--radius);
  display: flex;
  align-items: center;
  justify-content: center;
  color: var(--blue-bright);
  flex-shrink: 0;
  margin-top: 2px;
}
.ci-label { display: block; font-size: 0.72rem; font-family: var(--font-mono); text-transform: uppercase; letter-spacing: 0.08em; color: var(--grey); margin-bottom: 4px; }
.ci-value { display: block; font-size: 0.92rem; color: var(--white-off); }

/* Form */
.contact-form { display: flex; flex-direction: column; gap: 16px; }
.form-row { display: grid; grid-template-columns: 1fr 1fr; gap: 16px; }
.form-group { display: flex; flex-direction: column; gap: 6px; }
label { font-size: 0.8rem; font-weight: 500; color: var(--grey); }
input, select, textarea {
  background: var(--black-card);
  border: 1px solid var(--border);
  color: var(--white);
  padding: 11px 14px;
  font-size: 0.88rem;
  border-radius: var(--radius);
  transition: border-color var(--transition), box-shadow var(--transition);
  width: 100%;
}
input::placeholder, textarea::placeholder { color: var(--grey-dim); }
input:focus, select:focus, textarea:focus {
  outline: none;
  border-color: var(--blue-bright);
  box-shadow: 0 0 0 3px rgba(0,71,204,0.12);
}
textarea { resize: vertical; min-height: 120px; }
select { appearance: none; cursor: pointer; }

.form-success {
  background: rgba(10,138,80,0.15);
  border: 1px solid rgba(10,138,80,0.4);
  border-radius: var(--radius);
  padding: 12px 16px;
  font-size: 0.88rem;
  color: #4ade80;
  text-align: center;
}

/* ============================================================
   FOOTER
   ============================================================ */
.footer {
  background: #0A0A0A;
  border-top: 1px solid var(--border);
  padding: 64px 0 32px;
}
.footer-grid {
  display: grid;
  grid-template-columns: 1.6fr repeat(3, 1fr);
  gap: 48px;
  margin-bottom: 48px;
}
.footer-logo { font-size: 1.6rem; display: inline-block; margin-bottom: 14px; }
.footer-tagline { font-size: 0.85rem; color: var(--grey); line-height: 1.7; max-width: 280px; margin-bottom: 24px; }

.social-links { display: flex; gap: 10px; }
.social-link {
  width: 36px;
  height: 36px;
  border: 1px solid var(--border);
  border-radius: var(--radius);
  display: flex;
  align-items: center;
  justify-content: center;
  color: var(--grey);
  transition: border-color var(--transition), color var(--transition), background var(--transition);
}
.social-link:hover { border-color: var(--blue-bright); color: var(--blue-bright); background: var(--blue-glow); }

.footer-col-title {
  font-family: var(--font-display);
  font-size: 0.82rem;
  font-weight: 700;
  letter-spacing: 0.06em;
  text-transform: uppercase;
  color: var(--white);
  margin-bottom: 18px;
}
.footer-links { display: flex; flex-direction: column; gap: 10px; }
.footer-links a {
  font-size: 0.85rem;
  color: var(--grey);
  transition: color var(--transition);
}
.footer-links a:hover { color: var(--blue-bright); }

.footer-bottom {
  padding-top: 24px;
  border-top: 1px solid var(--border);
  display: flex;
  justify-content: space-between;
  align-items: center;
  gap: 16px;
  flex-wrap: wrap;
  font-size: 0.78rem;
  color: var(--grey-dim);
}

/* ============================================================
   MODAL
   ============================================================ */
.modal-overlay {
  position: fixed;
  inset: 0;
  background: rgba(0,0,0,0.75);
  z-index: 2000;
  display: flex;
  align-items: center;
  justify-content: center;
  padding: 24px;
  animation: fadeIn 0.2s ease;
}
@keyframes fadeIn { from { opacity: 0; } to { opacity: 1; } }

.modal-box {
  background: #1A1A1A;
  border: 1px solid var(--border-blue);
  border-radius: var(--radius-lg);
  padding: 40px;
  max-width: 480px;
  width: 100%;
  position: relative;
  animation: slideUp 0.3s ease;
}
@keyframes slideUp { from { transform: translateY(20px); opacity: 0; } to { transform: translateY(0); opacity: 1; } }

.modal-close {
  position: absolute;
  top: 16px; right: 16px;
  background: none;
  border: none;
  color: var(--grey);
  cursor: pointer;
  font-size: 1rem;
  padding: 4px 8px;
  transition: color var(--transition);
}
.modal-close:hover { color: var(--white); }

.modal-title {
  font-family: var(--font-display);
  font-size: 1.4rem;
  font-weight: 700;
  margin-bottom: 12px;
}
.modal-text { font-size: 0.9rem; color: var(--grey); line-height: 1.65; margin-bottom: 20px; }
.modal-build {
  background: var(--black);
  border: 1px solid var(--border);
  border-radius: var(--radius);
  padding: 14px 16px;
  font-size: 0.8rem;
  color: var(--white-off);
  line-height: 1.8;
  margin-bottom: 20px;
  max-height: 200px;
  overflow-y: auto;
}

/* ============================================================
   RESPONSIVE
   ============================================================ */

/* Tablet */
@media (max-width: 1024px) {
  .builder-layout { grid-template-columns: 1fr; }
  .builder-summary { position: static; }

  .footer-grid { grid-template-columns: 1fr 1fr; }

  .about-layout { grid-template-columns: 1fr; gap: 40px; }
  .about-visual { order: -1; }
}

/* Mobile L */
@media (max-width: 768px) {
  .section { padding: 64px 0; }
  .section-header { margin-bottom: 40px; }

  /* Nav mobile */
  .nav-links {
    position: fixed;
    top: var(--nav-h);
    left: 0; right: 0;
    background: rgba(15,15,15,0.98);
    backdrop-filter: blur(16px);
    flex-direction: column;
    align-items: stretch;
    padding: 16px 24px 24px;
    gap: 4px;
    border-bottom: 1px solid var(--border);
    transform: translateY(-120%);
    transition: transform 0.3s ease;
    z-index: 999;
  }
  .nav-links.open { transform: translateY(0); }
  .nav-link { padding: 12px 16px; font-size: 1rem; }

  .hamburger { display: flex; }

  /* Hero */
  .hero-title { font-size: 2.2rem; }
  .hero-stats { gap: 20px; }
  .stat-divider { display: none; }
  .hero-scroll { display: none; }
  .br-desktop { display: none; }

  /* Cards */
  .repair-grid { grid-template-columns: 1fr; }
  .products-grid { grid-template-columns: 1fr; }
  .testimonials-grid { grid-template-columns: 1fr; }

  /* Form */
  .form-row { grid-template-columns: 1fr; }
  .contact-layout { grid-template-columns: 1fr; gap: 40px; }

  /* About */
  .about-card-stack { grid-template-columns: 1fr 1fr; }

  /* Footer */
  .footer-grid { grid-template-columns: 1fr; gap: 32px; }
  .footer-bottom { flex-direction: column; text-align: center; }
}

/* Mobile S */
@media (max-width: 480px) {
  .hero-cta { flex-direction: column; }
  .btn-primary, .btn-ghost { width: 100%; text-align: center; }
  .about-card-stack { grid-template-columns: 1fr; }
  .product-footer { flex-direction: column; align-items: flex-start; }
  .btn-cart { width: 100%; text-align: center; }
}