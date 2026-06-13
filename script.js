/* ============================================================
   TOKI.CO — script.js
   Módulos: Canvas Hero, Navbar, Mobile Menu, Carrinho,
            Filtro de Produtos, Configurador de PC,
            Formulário de Contato, Reveal Animations
   ============================================================ */

'use strict';

/* ============================================================
   1. HERO CANVAS — partículas tecnológicas
   ============================================================ */
(function initHeroCanvas() {
  const canvas = document.getElementById('heroCanvas');
  if (!canvas) return;

  const ctx = canvas.getContext('2d');
  const BLUE = '0, 71, 204';
  let particles = [];
  let animId;
  let W, H;

  /* Redimensiona o canvas com o viewport */
  function resize() {
    W = canvas.width  = canvas.offsetWidth;
    H = canvas.height = canvas.offsetHeight;
  }

  /* Cria uma partícula com posição e velocidade aleatórias */
  function createParticle() {
    return {
      x: Math.random() * W,
      y: Math.random() * H,
      r: Math.random() * 1.5 + 0.3,
      vx: (Math.random() - 0.5) * 0.4,
      vy: (Math.random() - 0.5) * 0.4,
      alpha: Math.random() * 0.5 + 0.1
    };
  }

  /* Inicializa pool de partículas */
  function initParticles(count) {
    particles = [];
    for (let i = 0; i < count; i++) particles.push(createParticle());
  }

  /* Desenha conexões entre partículas próximas */
  function drawConnections() {
    const DIST = 130;
    for (let i = 0; i < particles.length; i++) {
      for (let j = i + 1; j < particles.length; j++) {
        const dx = particles[i].x - particles[j].x;
        const dy = particles[i].y - particles[j].y;
        const d  = Math.sqrt(dx * dx + dy * dy);
        if (d < DIST) {
          const opacity = (1 - d / DIST) * 0.12;
          ctx.beginPath();
          ctx.strokeStyle = `rgba(${BLUE}, ${opacity})`;
          ctx.lineWidth = 0.8;
          ctx.moveTo(particles[i].x, particles[i].y);
          ctx.lineTo(particles[j].x, particles[j].y);
          ctx.stroke();
        }
      }
    }
  }

  /* Loop de animação */
  function animate() {
    ctx.clearRect(0, 0, W, H);
    drawConnections();

    for (const p of particles) {
      /* Atualiza posição */
      p.x += p.vx;
      p.y += p.vy;

      /* Rebote nas bordas */
      if (p.x < 0 || p.x > W) p.vx *= -1;
      if (p.y < 0 || p.y > H) p.vy *= -1;

      /* Desenha ponto */
      ctx.beginPath();
      ctx.arc(p.x, p.y, p.r, 0, Math.PI * 2);
      ctx.fillStyle = `rgba(${BLUE}, ${p.alpha})`;
      ctx.fill();
    }

    animId = requestAnimationFrame(animate);
  }

  /* Pausa quando fora da viewport (performance) */
  const observer = new IntersectionObserver(([entry]) => {
    if (entry.isIntersecting) {
      animId = requestAnimationFrame(animate);
    } else {
      cancelAnimationFrame(animId);
    }
  });
  observer.observe(canvas);

  /* Inicializa */
  resize();
  initParticles(60);
  window.addEventListener('resize', () => {
    resize();
    initParticles(60);
  });
})();


/* ============================================================
   2. NAVBAR — scroll + active link
   ============================================================ */
(function initNavbar() {
  const navbar  = document.getElementById('navbar');
  const navLinks = document.querySelectorAll('.nav-link');

  /* Adiciona classe "scrolled" após rolar */
  window.addEventListener('scroll', () => {
    navbar.classList.toggle('scrolled', window.scrollY > 30);
  }, { passive: true });

  /* Atualiza link ativo conforme seção visível */
  const sections = document.querySelectorAll('section[id]');
  const io = new IntersectionObserver((entries) => {
    for (const entry of entries) {
      if (entry.isIntersecting) {
        navLinks.forEach(l => l.classList.remove('active'));
        const active = document.querySelector(`.nav-link[href="#${entry.target.id}"]`);
        if (active) active.classList.add('active');
      }
    }
  }, { rootMargin: '-45% 0px -45% 0px' });

  sections.forEach(s => io.observe(s));
})();


/* ============================================================
   3. MENU MOBILE — hamburger
   ============================================================ */
(function initMobileMenu() {
  const hamburger = document.getElementById('hamburger');
  const navLinks  = document.getElementById('navLinks');

  hamburger.addEventListener('click', () => {
    const isOpen = navLinks.classList.toggle('open');
    hamburger.classList.toggle('open', isOpen);
    hamburger.setAttribute('aria-expanded', isOpen);
  });

  /* Fecha ao clicar num link */
  navLinks.querySelectorAll('.nav-link').forEach(link => {
    link.addEventListener('click', () => {
      navLinks.classList.remove('open');
      hamburger.classList.remove('open');
      hamburger.setAttribute('aria-expanded', false);
    });
  });

  /* Fecha ao clicar fora */
  document.addEventListener('click', (e) => {
    if (!navLinks.contains(e.target) && !hamburger.contains(e.target)) {
      navLinks.classList.remove('open');
      hamburger.classList.remove('open');
    }
  });
})();


/* ============================================================
   4. CARRINHO DE COMPRAS
   ============================================================ */
const Cart = (function () {
  /* Estado interno: { "Nome Produto": { name, price, qty } } */
  let items = {};

  /* DOM */
  const sidebar    = document.getElementById('cartSidebar');
  const overlay    = document.getElementById('cartOverlay');
  const cartBtn    = document.getElementById('cartBtn');
  const cartClose  = document.getElementById('cartClose');
  const cartItems  = document.getElementById('cartItems');
  const cartTotal  = document.getElementById('cartTotal');
  const cartCount  = document.getElementById('cartCount');

  /* Abre/fecha sidebar */
  function open()  { sidebar.classList.add('open');  overlay.classList.add('active'); document.body.style.overflow = 'hidden'; }
  function close() { sidebar.classList.remove('open'); overlay.classList.remove('active'); document.body.style.overflow = ''; }

  cartBtn.addEventListener('click', open);
  cartClose.addEventListener('click', close);
  overlay.addEventListener('click', close);

  /* Adiciona produto */
  function add(name, price) {
    if (items[name]) {
      items[name].qty++;
    } else {
      items[name] = { name, price: parseFloat(price), qty: 1 };
    }
    render();
    open();
    /* Mini-feedback no botão */
    const btn = document.querySelector(`.btn-cart[data-name="${name}"]`);
    if (btn) {
      const orig = btn.textContent;
      btn.textContent = '✓ Adicionado';
      btn.style.background = 'rgba(10,138,80,0.2)';
      btn.style.borderColor = '#0a8a50';
      btn.style.color = '#4ade80';
      setTimeout(() => {
        btn.textContent = orig;
        btn.style.background = '';
        btn.style.borderColor = '';
        btn.style.color = '';
      }, 1800);
    }
  }

  /* Remove produto */
  function remove(name) {
    delete items[name];
    render();
  }

  /* Altera quantidade */
  function changeQty(name, delta) {
    if (!items[name]) return;
    items[name].qty += delta;
    if (items[name].qty <= 0) remove(name);
    else render();
  }

  /* Renderiza lista e total */
  function render() {
    const list = Object.values(items);
    let total = 0;
    let count = 0;

    if (list.length === 0) {
      cartItems.innerHTML = '<p class="cart-empty">Seu carrinho está vazio.</p>';
    } else {
      cartItems.innerHTML = list.map(item => {
        total += item.price * item.qty;
        count += item.qty;
        return `
          <div class="cart-item">
            <div class="cart-item-info">
              <p class="cart-item-name">${item.name}</p>
              <p class="cart-item-price">R$ ${(item.price * item.qty).toLocaleString('pt-BR', { minimumFractionDigits: 2 })}</p>
              <div class="cart-item-qty">
                <button class="qty-btn" data-action="dec" data-name="${item.name}">−</button>
                <span class="qty-num">${item.qty}</span>
                <button class="qty-btn" data-action="inc" data-name="${item.name}">+</button>
              </div>
            </div>
            <button class="cart-item-remove" data-name="${item.name}" aria-label="Remover ${item.name}">✕</button>
          </div>`;
      }).join('');

      /* Eventos dos botões de quantidade (delegação) */
      cartItems.querySelectorAll('.qty-btn').forEach(btn => {
        btn.addEventListener('click', () => {
          const delta = btn.dataset.action === 'inc' ? 1 : -1;
          changeQty(btn.dataset.name, delta);
        });
      });
      cartItems.querySelectorAll('.cart-item-remove').forEach(btn => {
        btn.addEventListener('click', () => remove(btn.dataset.name));
      });
    }

    cartTotal.textContent = 'R$ ' + total.toLocaleString('pt-BR', { minimumFractionDigits: 2 });
    cartCount.textContent = count;
    cartCount.style.display = count > 0 ? 'flex' : 'none';
  }

  /* Delegação de clique nos botões "Adicionar ao Carrinho" */
  document.addEventListener('click', (e) => {
    const btn = e.target.closest('.btn-cart');
    if (btn) add(btn.dataset.name, btn.dataset.price);
  });

  render();
  return { add, remove, getItems: () => items };
})();


/* ============================================================
   5. FILTRO DE PRODUTOS
   ============================================================ */
(function initProductFilter() {
  const filterBtns = document.querySelectorAll('.filter-btn');
  const cards      = document.querySelectorAll('.product-card[data-category]');

  filterBtns.forEach(btn => {
    btn.addEventListener('click', () => {
      filterBtns.forEach(b => b.classList.remove('active'));
      btn.classList.add('active');

      const filter = btn.dataset.filter;
      cards.forEach(card => {
        const show = filter === 'all' || card.dataset.category === filter;
        card.classList.toggle('hidden', !show);
      });
    });
  });
})();


/* ============================================================
   6. CONFIGURADOR DE PC — preço em tempo real
   ============================================================ */
(function initBuilder() {
  const selects     = document.querySelectorAll('.builder-select');
  const summaryList = document.getElementById('summaryList');
  const buildTotal  = document.getElementById('buildTotal');
  const btnFinalizar = document.getElementById('finalizarBuild');
  const btnLimpar    = document.getElementById('limparBuild');

  /* Mapa de categorias para labels legíveis */
  const CATEGORY_LABELS = {
    gabinete:    'Gabinete',
    processador: 'Processador',
    'placa-mae': 'Placa-Mãe',
    ram:         'Memória RAM',
    gpu:         'Placa de Vídeo',
    storage:     'Armazenamento',
    fonte:       'Fonte',
  };

  /* Recalcula total e atualiza painel de resumo */
  function updateSummary() {
    let total = 0;
    const chosen = [];

    selects.forEach(select => {
      const value = parseFloat(select.value);
      if (!isNaN(value) && select.value !== '') {
        const cat   = select.dataset.category;
        const label = select.options[select.selectedIndex].dataset.label || select.options[select.selectedIndex].text.split('—')[0].trim();
        total += value;
        chosen.push({ cat: CATEGORY_LABELS[cat] || cat, label, price: value });
      }
    });

    /* Renderiza lista de componentes */
    if (chosen.length === 0) {
      summaryList.innerHTML = '<li class="summary-empty">Nenhum componente selecionado.</li>';
    } else {
      summaryList.innerHTML = chosen.map(c => `
        <li class="summary-item">
          <span class="si-cat">${c.cat}</span>
          <span class="si-name">${c.label}</span>
          <span class="si-price">R$ ${c.price.toLocaleString('pt-BR', { minimumFractionDigits: 2 })}</span>
        </li>`).join('');
    }

    /* Atualiza total com animação de contagem */
    animateTotal(total);
  }

  /* Animação suave do valor total */
  let currentTotal = 0;
  let rafId = null;
  function animateTotal(target) {
    cancelAnimationFrame(rafId);
    const start = currentTotal;
    const diff  = target - start;
    const duration = 350;
    const startTime = performance.now();

    function step(now) {
      const elapsed = now - startTime;
      const t = Math.min(elapsed / duration, 1);
      /* easeOutCubic */
      const eased = 1 - Math.pow(1 - t, 3);
      currentTotal = start + diff * eased;
      buildTotal.textContent = 'R$ ' + currentTotal.toLocaleString('pt-BR', { minimumFractionDigits: 2 });
      if (t < 1) rafId = requestAnimationFrame(step);
      else currentTotal = target;
    }
    rafId = requestAnimationFrame(step);
  }

  /* Destaca a categoria ao selecionar */
  selects.forEach(select => {
    select.addEventListener('change', () => {
      updateSummary();
      /* Adiciona borda na categoria selecionada */
      const category = select.closest('.builder-category');
      if (select.value) {
        category.style.borderColor = 'rgba(0,71,204,0.5)';
      } else {
        category.style.borderColor = '';
      }
    });
  });

  /* Finalizar orçamento */
  btnFinalizar.addEventListener('click', () => {
    const chosen = [];
    selects.forEach(select => {
      if (select.value) {
        const cat   = select.dataset.category;
        const label = select.options[select.selectedIndex].dataset.label || select.options[select.selectedIndex].text.split('—')[0].trim();
        const price = parseFloat(select.value);
        chosen.push({ cat: CATEGORY_LABELS[cat] || cat, label, price });
      }
    });

    if (chosen.length === 0) {
      /* Shake de feedback visual */
      const summaryCard = document.querySelector('.summary-card');
      summaryCard.style.animation = 'none';
      summaryCard.offsetHeight; /* reflow */
      summaryCard.style.animation = 'shake 0.4s ease';
      /* Injeta keyframe dinamicamente se necessário */
      if (!document.getElementById('shakeKF')) {
        const style = document.createElement('style');
        style.id = 'shakeKF';
        style.textContent = '@keyframes shake { 0%,100%{transform:translateX(0)} 25%{transform:translateX(-6px)} 75%{transform:translateX(6px)} }';
        document.head.appendChild(style);
      }
      return;
    }

    /* Exibe modal */
    const modal = document.getElementById('budgetModal');
    const summary = document.getElementById('modalBuildSummary');
    const total = chosen.reduce((s, c) => s + c.price, 0);

    summary.innerHTML = chosen.map(c =>
      `<div><strong>${c.cat}:</strong> ${c.label} — R$ ${c.price.toLocaleString('pt-BR', { minimumFractionDigits: 2 })}</div>`
    ).join('') + `<hr style="border-color:rgba(255,255,255,.1);margin:10px 0"><strong>Total: R$ ${total.toLocaleString('pt-BR', { minimumFractionDigits: 2 })}</strong>`;

    modal.style.display = 'flex';
  });

  /* Limpar seleção */
  btnLimpar.addEventListener('click', () => {
    selects.forEach(s => {
      s.value = '';
      const category = s.closest('.builder-category');
      if (category) category.style.borderColor = '';
    });
    updateSummary();
  });

  /* Modal: fechar */
  document.getElementById('modalClose').addEventListener('click', () => {
    document.getElementById('budgetModal').style.display = 'none';
  });
  document.getElementById('modalOk').addEventListener('click', () => {
    document.getElementById('budgetModal').style.display = 'none';
  });
  document.getElementById('budgetModal').addEventListener('click', (e) => {
    if (e.target === e.currentTarget) e.currentTarget.style.display = 'none';
  });

  updateSummary();
})();


/* ============================================================
   7. FORMULÁRIO DE CONTATO — validação simples
   ============================================================ */
(function initContactForm() {
  const form    = document.getElementById('contactForm');
  const success = document.getElementById('formSuccess');

  if (!form) return;

  form.addEventListener('submit', (e) => {
    e.preventDefault();

    /* Validação básica */
    const nome     = form.querySelector('#nome').value.trim();
    const email    = form.querySelector('#email').value.trim();
    const mensagem = form.querySelector('#mensagem').value.trim();

    if (!nome || !email || !mensagem) {
      /* Destaca campos inválidos */
      [form.querySelector('#nome'), form.querySelector('#email'), form.querySelector('#mensagem')].forEach(field => {
        if (!field.value.trim()) {
          field.style.borderColor = '#e05';
          field.addEventListener('input', () => { field.style.borderColor = ''; }, { once: true });
        }
      });
      return;
    }

    /* Simula envio (aqui viria uma requisição fetch real) */
    const btn = form.querySelector('button[type="submit"]');
    btn.textContent = 'Enviando...';
    btn.disabled = true;

    setTimeout(() => {
      success.style.display = 'block';
      form.reset();
      btn.textContent = 'Enviar Mensagem';
      btn.disabled = false;
      setTimeout(() => { success.style.display = 'none'; }, 5000);
    }, 1200);
  });
})();


/* ============================================================
   8. REVEAL ANIMATIONS — IntersectionObserver
   ============================================================ */
(function initReveal() {
  const elements = document.querySelectorAll('.reveal');
  if (!elements.length) return;

  /* Respeita preferência por movimento reduzido */
  if (window.matchMedia('(prefers-reduced-motion: reduce)').matches) {
    elements.forEach(el => el.classList.add('visible'));
    return;
  }

  const io = new IntersectionObserver((entries) => {
    entries.forEach((entry, i) => {
      if (entry.isIntersecting) {
        /* Delay escalonado para cards irmãos */
        const siblings = [...entry.target.parentElement.children].filter(c => c.classList.contains('reveal'));
        const idx = siblings.indexOf(entry.target);
        const delay = idx * 80;
        setTimeout(() => entry.target.classList.add('visible'), delay);
        io.unobserve(entry.target);
      }
    });
  }, { threshold: 0.12 });

  elements.forEach(el => io.observe(el));
})();


/* ============================================================
   9. SMOOTH SCROLL para browsers mais antigos (segurança)
   ============================================================ */
(function initSmoothScroll() {
  document.querySelectorAll('a[href^="#"]').forEach(anchor => {
    anchor.addEventListener('click', (e) => {
      const targetId = anchor.getAttribute('href');
      if (targetId === '#') return;

      const target = document.querySelector(targetId);
      if (!target) return;

      e.preventDefault();
      const navH = parseInt(getComputedStyle(document.documentElement).getPropertyValue('--nav-h'));
      const top  = target.getBoundingClientRect().top + window.scrollY - navH - 8;

      window.scrollTo({ top, behavior: 'smooth' });
    });
  });
})();


/* ============================================================
   10. MÁSCARAS — telefone no formulário
   ============================================================ */
(function initPhoneMask() {
  const tel = document.getElementById('telefone');
  if (!tel) return;

  tel.addEventListener('input', () => {
    let v = tel.value.replace(/\D/g, '').slice(0, 11);
    if (v.length > 6) v = `(${v.slice(0,2)}) ${v.slice(2,7)}-${v.slice(7)}`;
    else if (v.length > 2) v = `(${v.slice(0,2)}) ${v.slice(2)}`;
    tel.value = v;
  });
})();