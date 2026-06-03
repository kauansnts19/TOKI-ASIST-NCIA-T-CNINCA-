/* ====================== style.css ====================== */

:root {
  --bordo: #8B1E3F;
  --bordo-hover: #a6244a;
  --azul: #2563EB;
  --cinza-escuro: #18181b;
}

.bordo {
  color: var(--bordo);
}

/* Hero Background */
.hero-bg {
  background-image: linear-gradient(rgba(0, 0, 0, 0.78), rgba(0, 0, 0, 0.85)), 
                    url('https://images.unsplash.com/photo-1519389950473-47ba0277781c?q=80&w=2070&auto=format&fit=crop');
  background-size: cover;
  background-position: center;
  background-attachment: fixed;
}

/* Cards Gerais */
.card-hover {
  transition: all 0.4s cubic-bezier(0.4, 0, 0.2, 1);
}

.card-hover:hover {
  transform: translateY(-12px);
  box-shadow: 0 25px 50px -12px rgb(139 30 63 / 0.3);
}

/* Animação de entrada das seções */
.section-animate {
  opacity: 0;
  transform: translateY(40px);
  transition: all 0.8s ease;
}

.section-animate.visible {
  opacity: 1;
  transform: translateY(0);
}

/* Navegação */
nav a {
  position: relative;
  transition: color 0.3s ease;
}

nav a:hover {
  color: var(--bordo);
}

nav a:hover:after {
  content: '';
  position: absolute;
  width: 100%;
  height: 2px;
  bottom: -4px;
  left: 0;
  background: var(--bordo);
  transform: scaleX(1);
}

/* Scrollbar Personalizada */
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

/* ==================== ESTILOS ESPECÍFICOS PARA SERVIÇOS ==================== */

#conserto .bg-zinc-900 {
  transition: all 0.4s ease;
}

#conserto .bg-zinc-900:hover {
  border-color: var(--bordo);
  background-color: #27272a;
  transform: translateY(-6px);
}

/* Cards de Marcas de Celulares */
#conserto h4 {
  font-size: 1.1rem;
  margin-bottom: 6px;
  color: white;
}

#conserto p {
  font-size: 0.9rem;
  line-height: 1.4;
}

/* Destaque nos preços */
#conserto .text-\\[\\#8B1E3F\\] {
  font-size: 1.05rem;
  letter-spacing: 0.5px;
}

/* Responsividade */
@media (max-width: 768px) {
  .hero-bg h2 {
    font-size: 2.75rem;
    line-height: 1.1;
  }

  #conserto .grid-cols-2 {
    grid-template-columns: 1fr;
  }
}

@media (max-width: 640px) {
  .hero-bg h2 {
    font-size: 2.4rem;
  }
}

/* Melhorias visuais extras */
h2, h3 {
  letter-spacing: -0.5px;
}

/* Efeito suave no botão Voltar ao Topo */
#back-to-top {
  transition: all 0.4s ease;
}

#back-to-top:hover {
  transform: scale(1.15) rotate(360deg);
}