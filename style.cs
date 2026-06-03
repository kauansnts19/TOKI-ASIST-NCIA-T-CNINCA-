/* ====================== style.css ====================== */

:root {
  --bordo: #8B1E3F;
  --bordo-hover: #a6244a;
  --azul: #2563EB;
  --cinza-escuro: #18181b;
  --cinza-medio: #27272a;
}

.bordo {
  color: var(--bordo);
}

/* ==================== CONFIGURAÇÕES GERAIS ==================== */

body {
  font-family: 'Inter', system-ui, sans-serif;
  scroll-behavior: smooth;
}

h1, h2, h3 {
  letter-spacing: -0.5px;
}

/* Header */
header {
  backdrop-filter: blur(12px);
}

nav a {
  position: relative;
  transition: all 0.3s ease;
}

nav a:hover {
  color: var(--bordo);
}

nav a:after {
  content: '';
  position: absolute;
  width: 0;
  height: 2px;
  bottom: -4px;
  left: 0;
  background: var(--bordo);
  transition: width 0.3s ease;
}

nav a:hover:after {
  width: 100%;
}

/* Hero Section */
.hero-bg {
  background-image: linear-gradient(rgba(0, 0, 0, 0.75), rgba(0, 0, 0, 0.85)), 
                    url('https://images.unsplash.com/photo-1519389950473-47ba0277781c?q=80&w=2070&auto=format&fit=crop');
  background-size: cover;
  background-position: center;
  background-attachment: fixed;
}

.hero-bg h2 {
  text-shadow: 0 4px 20px rgba(0, 0, 0, 0.6);
}

/* Cards de Serviços */
#servicos .bg-zinc-900 {
  transition: all 0.4s cubic-bezier(0.4, 0, 0.2, 1);
}

#servicos .bg-zinc-900:hover {
  transform: translateY(-12px);
  border-color: var(--bordo);
  box-shadow: 0 20px 25px -5px rgb(139 30 63 / 0.15);
  background-color: var(--cinza-medio);
}

/* Carrossel de Produtos */
#carousel-track {
  display: flex;
  gap: 24px;
  padding-bottom: 20px;
}

#produtos .min-w-\[280px\] {
  transition: all 0.4s ease;
}

#produtos .min-w-\[280px\]:hover {
  transform: scale(1.04);
  box-shadow: 0 25px 50px -12px rgb(139 30 63 / 0.25);
}

/* Botões do Carrossel */
button[onclick*="moveCarousel"] {
  transition: all 0.3s ease;
}

button[onclick*="moveCarousel"]:hover {
  background-color: var(--bordo);
  color: white;
  transform: scale(1.1);
}

/* Efeitos Gerais */
.card-hover {
  transition: all 0.4s cubic-bezier(0.4, 0, 0.2, 1);
}

.card-hover:hover {
  transform: translateY(-10px);
}

/* Scrollbar Personalizada */
::-webkit-scrollbar {
  width: 8px;
  height: 8px;
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

/* Responsividade */
@media (max-width: 768px) {
  .hero-bg h2 {
    font-size: 2.8rem;
    line-height: 1.1;
  }
  
  #servicos .grid-cols-4 {
    grid-template-columns: repeat(2, 1fr);
  }
}

@media (max-width: 640px) {
  .hero-bg h2 {
    font-size: 2.4rem;
  }
  
  #servicos .grid-cols-4 {
    grid-template-columns: 1fr;
  }
}

/* Animações de Entrada */
@keyframes fadeUp {
  from {
    opacity: 0;
    transform: translateY(40px);
  }
  to {
    opacity: 1;
    transform: translateY(0);
  }
}

.section-animate {
  animation: fadeUp 0.8s ease forwards;
}

/* Melhorias Visuais */
.rounded-3xl {
  border-radius: 1.5rem;
}

.text-shadow {
  text-shadow: 0 2px 10px rgba(139, 30, 63, 0.3);
}