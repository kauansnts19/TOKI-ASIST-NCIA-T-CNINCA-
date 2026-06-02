// script.js
document.addEventListener('DOMContentLoaded', () => {

  // Mobile Menu
  const header = document.querySelector('header');
  const nav = document.querySelector('nav');
  
  const hamburger = document.createElement('button');
  hamburger.className = 'md:hidden text-3xl p-2';
  hamburger.innerHTML = '<i class="fa-solid fa-bars"></i>';
  header.querySelector('div').appendChild(hamburger);

  hamburger.addEventListener('click', () => {
    nav.classList.toggle('hidden');
    const icon = hamburger.querySelector('i');
    icon.classList.toggle('fa-bars');
    icon.classList.toggle('fa-xmark');
  });

  // Smooth Scroll
  document.querySelectorAll('a[href^="#"]').forEach(anchor => {
    anchor.addEventListener('click', function(e) {
      if (this.getAttribute('href') !== '#') {
        e.preventDefault();
        document.querySelector(this.getAttribute('href')).scrollIntoView({
          behavior: 'smooth'
        });
      }
    });
  });

  // Scroll Animations
  const observer = new IntersectionObserver((entries) => {
    entries.forEach(entry => {
      if (entry.isIntersecting) {
        entry.target.style.opacity = '1';
        entry.target.style.transform = 'translateY(0)';
      }
    });
  }, { threshold: 0.15 });

  document.querySelectorAll('.section-animate').forEach(el => {
    observer.observe(el);
  });

  // Navbar Scroll Effect
  window.addEventListener('scroll', () => {
    if (window.scrollY > 80) {
      header.style.backgroundColor = 'rgba(0, 0, 0, 0.97)';
      header.style.backdropFilter = 'blur(12px)';
    } else {
      header.style.backgroundColor = 'black';
      header.style.backdropFilter = 'none';
    }
  });

  // Back to Top Button
  const backToTop = document.getElementById('back-to-top');
  window.addEventListener('scroll', () => {
    backToTop.style.opacity = window.scrollY > 600 ? '1' : '0';
  });

  backToTop.addEventListener('click', () => {
    window.scrollTo({ top: 0, behavior: 'smooth' });
  });

  console.log('%c✅ Toki.Co carregado com sucesso!', 'color: #8B1E3F; font-size: 16px; font-weight: bold;');
});