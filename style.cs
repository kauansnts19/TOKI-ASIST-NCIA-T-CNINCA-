* {
    margin: 0;
    padding: 0;
    box-sizing: border-box;
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
    padding: 0 15px;
}

/* Barra Superior */
.top-bar {
    background: #1a1a1a;
    color: #fff;
    font-size: 0.9rem;
    padding: 8px 0;
}

.top-bar .container {
    display: flex;
    align-items: center;
    justify-content: space-between;
    flex-wrap: wrap;
    gap: 10px;
}

.top-bar a {
    color: #fff;
    text-decoration: none;
    display: flex;
    align-items: center;
    gap: 6px;
    margin: 0 10px;
}

.top-bar a:hover {
    color: #00bfff;
}

.social {
    display: flex;
    gap: 12px;
    font-size: 1.1rem;
}

.social i:hover {
    color: #00bfff;
    cursor: pointer;
}

/* Header Principal */
.main-header {
    background: #fff;
    box-shadow: 0 2px 10px rgba(0,0,0,0.1);
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
    color: #333;
}

.logo-icon {
    width: 50px;
    height: 50px;
    background: linear-gradient(135deg, #00bfff, #0077cc);
    border-radius: 10px;
    display: flex;
    align-items: center;
    justify-content: center;
    margin-right: 10px;
    color: white;
    font-size: 28px;
    font-weight: bold;
}

.logo-text strong {
    font-size: 1.8rem;
    color: #00bfff;
}

.logo-text small {
    font-size: 0.8rem;
    color: #666;
}

/* Barra de Pesquisa */
.search-bar {
    flex: 1;
    max-width: 500px;
    display: flex;
    border: 2px solid #00bfff;
    border-radius: 50px;
    overflow: hidden;
}

.search-bar input {
    flex: 1;
    border: none;
    padding: 12px 20px;
    font-size: 1rem;
    outline: none;
}

.search-bar button {
    background: #00bfff;
    color: white;
    border: none;
    width: 50px;
    cursor: pointer;
    transition: 0.3s;
}

.search-bar button:hover {
    background: #0077cc;
}

/* Ações do Usuário */
.user-actions {
    display: flex;
    gap: 20px;
}

.user-actions a {
    display: flex;
    align-items: center;
    gap: 6px;
    text-decoration: none;
    color: #333;
    font-size: 1rem;
}

.user-actions a:hover {
    color: #00bfff;
}

.cart {
    position: relative;
}

.cart-count {
    position: absolute;
    top: -6px;
    right: -8px;
    background: #ff4444;
    color: white;
    font-size: 0.75rem;
    width: 18px;
    height: 18px;
    border-radius: 50%;
    display: flex;
    align-items: center;
    justify-content: center;
}

/* Categorias */
.categories {
    background: #f8f9fa;
    border-bottom: 1px solid #eee;
    padding: 12px 0;
}

.categories .container {
    display: flex;
    justify-content: space-between;
    flex-wrap: wrap;
    gap: 10px;
}

.category-item {
    display: flex;
    flex-direction: column;
    align-items: center;
    text-decoration: none;
    color: #333;
    font-size: 0.85rem;
    font-weight: 600;
    min-width: 90px;
    transition: 0.3s;
}

.category-item i {
    font-size: 1.6rem;
    margin-bottom: 6px;
    color: #00bfff;
}

.category-item:hover {
    color: #00bfff;
    transform: translateY(-3px);
}

/* Responsividade */
@media (max-width: 768px) {
    .top-bar .container {
        justify-content: center;
        text-align: center;
    }
    
    .main-header .container {
        flex-direction: column;
        gap: 15px;
    }
    
    .search-bar {
        max-width: 100%;
    }
    
    .categories .container {
        justify-content: center;
    }
}