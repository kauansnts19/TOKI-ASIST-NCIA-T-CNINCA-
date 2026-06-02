/* style.css */
@import url('https://fonts.googleapis.com/css2?family=Inter:wght@400;500;600;700&display=swap');

body {
  font-family: 'Inter', system-ui, sans-serif;
}

.hero-bg {
  background: linear-gradient(rgba(0,0,0,0.85), rgba(0,0,0,0.85)), 
              url('https://images.unsplash.com/photo-1519389950473-47ba0277781c?ixlib=rb-4.0.3&auto=format&fit=crop&q=80');
  background-size: cover;
  background-position: center;
}

.bordo {
  color: #8B1E3F;
}

.azul {
  color: #0A2540;
}

/* Efeitos adicionais */
.card-hover:hover {
  transform: translateY(-8px);
  transition: all 0.3s ease;
}

.btn-bordo {
  background-color: #8B1E3F;
  transition: all 0.3s ease;
}

.btn-bordo:hover {
  background-color: #6F182F;
  transform: scale(1.03);
}