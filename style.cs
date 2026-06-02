/* ====================== style.css ====================== */

/* Cores principais */
:root {
  --bordo: #8B1E3F;
  --bordo-hover: #a6244a;
}

/* Classe personalizada "bordo" */
.bordo {
  color: var(--bordo);
}

/* Background do Hero */
.hero-bg {
  background-image: linear-gradient(rgba(0, 0, 0, 0.75), rgba(0, 0, 0, 0.85)), 
                    url('https://images.unsplash.com/photo-1519389950473-47ba0277781c?q=80&w=2070&auto=format&fit=crop');
  background-size: cover;
  background-position: center;
  background-attachment: fixed;
}

/* Efeito de hover nos cards */
.card-hover {
  transition: all 0.3s ease;
}

.card-hover:hover {
  transform: translateY(-8px);
  box-shadow: 0 20px 25px -5px rgb(139 30 63 / 0.1), 
              0 8px 10px -6px rgb(139 30 63 / 0.1);
}

/* Botões e interações */
button, a {
  transition: all 0.3s ease;
}

/* Estilo do logo no header */
h1 span.bordo {
  color: var(--bordo);
}

/* Melhorias visuais gerais */
section {
  scroll-margin-top: 80px;
}

/* Responsividade adicional */
@media (max-width: 768px) {
  .hero-bg h2 {
    font-size: 2.75rem;
    line-height: 1.1;
  }
}

/* Efeito de brilho no hover dos links do menu */
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
  opacity: 0.7;
}

/* Custom scroll */
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