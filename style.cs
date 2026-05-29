* {
    margin: 0;
    padding: 0;
    box-sizing: border-box;
}

:root {
    --azul: #003087;
    --bordo: #800020;
    --preto: #1a1a1a;
    --cinza: #f8f9fa;
}

body {
    font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;
    color: #333;
    line-height: 1.6;
}

/* Container */
.container {
    max-width: 1200px;
    margin: 0 auto;
    padding: 0 20px;
}

/* Top Bar */
.top-bar {
    background: var(--preto);
    color: white;
    padding: 10px 0;
    font-size: 0.95rem;
    text-align: center;
}

.top-bar .container {
    display: flex;
    justify-content: space-between;
    align-items: center;
    flex-wrap: wrap;
    gap: 10px;
}

/* Header */
.main-header {
    background: white;
    box-shadow: 0 3px 10px rgba(0,0,0,0.1);
    padding: 18px 0;
    position: sticky;
    top: 0;
    z-index: 100;
}

.main-header .container {
    display: flex;
    align-items: center;
    justify-content: space-between;
}

.logo {
    display: flex;
    align-items: center;
    text-decoration: none;
    color: var(--azul);
}

.logo-icon {
    width: 55px;
    height: 55px;
    background: linear-gradient(135deg, var(--azul), var(--bordo));
    border-radius: 12px;
    display: flex;
    align-items: center;
    justify-content: center;
    color: white;
    font-size: 32px;
    font-weight: bold;
    margin-right: 12px;
}

.logo-text {
    font-size: 1.8rem;
    font-weight: bold;
}

.corporation {
    font-size: 0.95rem;
    color: var(--bordo);
}

/* Hero */
.hero {
    background: linear-gradient(rgba(0,0,0,0.7), rgba(0,0,0,0.7)), url('https://images.unsplash.com/photo-1592899677977-7c10d0aede2b?ixlib=rb-4.0.3&auto=format&fit=crop&q=80') center/cover no-repeat;
    color: white;
    padding: 140px 0;
    text-align: center;
}

.hero h1 {
    font-size: 3.2rem;
    margin-bottom: 20px;
}

.hero h1 span {
    color: var(--bordo);
}

.hero-buttons {
    margin-top: 30px;
    display: flex;
    justify-content: center;
    gap: 15px;
    flex-wrap: wrap;
}

.btn-blue {
    background: var(--azul);
    color: white;
    padding: 14px 32px;
    border-radius: 50px;
    text-decoration: none;
    font-weight: 600;
    transition: 0.3s;
}

.btn-bordô {
    background: var(--bordo);
    color: white;
    padding: 14px 32px;
    border-radius: 50px;
    text-decoration: none;
    font-weight: 600;
    transition: 0.3s;
}

.btn-blue:hover, .btn-bordô:hover {
    transform: translateY(-5px);
    box-shadow: 0 10px 20px rgba(0,0,0,0.2);
}

/* Seções */
.section-title {
    text-align: center;
    font-size: 2.2rem;
    margin: 60px 0 40px;
    color: var(--azul);
}

.services-grid {
    display: grid;
    grid-template-columns: repeat(auto-fit, minmax(260px, 1fr));
    gap: 25px;
}

.service-card {
    background: white;
    padding: 35px 20px;
    text-align: center;
    border-radius: 12px;
    box-shadow: 0 5px 15px rgba(0,0,0,0.08);
    transition: 0.3s;
}

.service-card:hover {
    transform: translateY(-10px);
    box-shadow: 0 15px 30px rgba(128, 0, 32, 0.15);
}

.service-card i {
    font-size: 3rem;
    color: var(--bordo);
    margin-bottom: 15px;
}

/* Footer */
.footer {
    background: var(--preto);
    color: white;
    padding: 60px 0 20px;
}

.footer-grid {
    display: grid;
    grid-template-columns: repeat(auto-fit, minmax(250px, 1fr));
    gap: 40px;
}

.footer-bottom {
    text-align: center;
    margin-top: 50px;
    padding-top: 20px;
    border-top: 1px solid #333;
    font-size: 0.9rem;
}