* {
    margin: 0;
    padding: 0;
    box-sizing: border-box;
}

body {
    font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;
    color: #333;
}

/* ========= CORES TOKI ========= */
:root {
    --azul: #003087;
    --bordo: #800020;
    --preto: #1a1a1a;
}

/* Container */
.container {
    max-width: 1200px;
    margin: 0 auto;
    padding: 0 15px;
}

/* Top Bar */
.top-bar {
    background: var(--preto);
    color: white;
    padding: 10px 0;
    font-size: 0.95rem;
}

.top-bar .container {
    display: flex;
    align-items: center;
    justify-content: space-between;
    flex-wrap: wrap;
    gap: 15px;
}

.top-bar a {
    color: white;
    text-decoration: none;
}

.top-bar a:hover {
    color: var(--bordo);
}

/* Main Header */
.main-header {
    background: white;
    box-shadow: 0 3px 12px rgba(0,0,0,0.1);
    padding: 15px 0;
}

.main-header .container {
    display: flex;
    align-items: center;
    justify-content: space-between;
    gap: 20px;
}

/* Logo */
.logo {
    display: flex;
    align-items: center;
    text-decoration: none;
    color: var(--azul);
}

.logo-icon {
    width: 52px;
    height: 52px;
    background: linear-gradient(135deg, var(--azul), var(--bordo));
    border-radius: 10px;
    display: flex;
    align-items: center;
    justify-content: center;
    color: white;
    font-size: 28px;
    font-weight: bold;
    margin-right: 10px;
}

/* Search Bar */
.search-bar {
    flex: 1;
    max-width: 500px;
    display: flex;
    border: 2px solid var(--azul);
    border-radius: 50px;
    overflow: hidden;
}

.search-bar input {
    flex: 1;
    border: none;
    padding: 14px 18px;
    outline: none;
    font-size: 1rem;
}

/* Categorias */
.categories {
    background: #f8f9fa;
    padding: 12px 0;
    border-bottom: 1px solid #eee;
}

.categories .container {
    display: flex;
    flex-wrap: wrap;
    gap: 15px;
    justify-content: center;
}

.category-item {
    display: flex;
    flex-direction: column;
    align-items: center;
    text-decoration: none;
    color: #333;
    min-width: 100px;
    transition: 0.3s;
}

.category-item i {
    font-size: 1.8rem;
    color: var(--bordo);
    margin-bottom: 5px;
}

.category-item:hover {
    color: var(--azul);
    transform: translateY(-4px);
}