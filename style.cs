/* ====================== style.css ====================== */

:root {
  --bordo: #8B1E3F;
  --bordo-hover: #a6244a;
  --azul: #2563EB;
}

.bordo {
  color: var(--bordo);
}

.hero-bg {
  background-image: linear-gradient(rgba(0, 0, 0, 0.75), rgba(0, 0, 0, 0.85)), 
                    url('https://images.unsplash.com/photo-1519389950473-47ba0277781c?q=80&w=2070&auto=format&fit=crop');
  background-size: cover;
  background-position: center;
  background-attachment: fixed;
}

.card-hover {
  transition: all 0.4s cubic-bezier(0.4, 0, 0.2, 1);
}

.card-hover:hover {
  transform: translateY(-12px);
  box-shadow: 0 25px 50px -12px rgb(139 30 63 / 0.25);
}

.section-animate {
  opacity: 0;
  transform: translateY(30px);
  transition: all 0.8s ease;
}

nav a:hover {
  position: relative;
}

nav a:hover:after {
  content: '';
  position: absolute;
  width: 100%;
  height: 2px;
  bottom: -4px;
  left: 0;
  background: var(--bordo);
}

::-webkit-scrollbar {
  width: 8px;
}

::-webkit-scrollbar-track {
  background: #111;
}

::-webkit-scrollbar-thumb {
  background: var(--bordo);
  border-radius: 20px;
}

::-webkit-scrollbar-thumb:hover {
  background: var(--bordo-hover);
}

@media (max-width: 768px) {
  .hero-bg h2 {
    font-size: 2.75rem;
    line-height: 1.1;
  }
}