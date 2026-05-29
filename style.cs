* {
  margin: 0;
  padding: 0;
  box-sizing: border-box;
}

body {
  font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;
}

/* Barra Superior */
.top-bar {
  background-color: #8B0000;
  color: white;
  padding: 10px 0;
  font-size: 14px;
}

.top-bar .container {
  max-width: 1200px;
  margin: 0 auto;
  display: flex;
  align-items: center;
  justify-content: space-between;
  flex-wrap: wrap;
  gap: 15px;
  padding: 0 20px;
}

.top-bar a {
  color: white;
  text-decoration: none;
}

.social i {
  margin-left: 15px;
  font-size: 16px;
}

/* Header Principal */
.main-header {
  background-color: #f8f8f8;
  padding: 18px 0;
  border-bottom: 1px solid #ddd;
}

.main-header .container {
  max-width: 1200px;
  margin: 0 auto;
  display: flex;
  align-items: center;
  justify-content: space-between;
  padding: 0 20px;
  gap: 20px;
}

/* Logo */
.logo {
  display: flex;
  align-items: center;
  gap: 12px;
  color: #222;
  text-decoration: none;
}

.logo-icon {
  background: linear-gradient(135deg, #8B0000, #5C0000);
  color: white;
  width: 58px;
  height: 58px;
  border-radius: 12px;
  display: flex;
  align-items: center;
  justify-content: center;
  font-size: 34px;
  font-weight: bold;
  box-shadow: 0 4px 12px rgba(139, 0, 0, 0.35);
}

.logo-text strong {
  font-size: 28px;
  line-height: 1;
}

.logo-text small {
  font-size: 13px;
  color: #444;
  font-weight: 600;
}

/* Barra de Pesquisa */
.search-bar {
  flex: 1;
  max-width: 520px;
  display: flex;
  height: 48px;
}

.search-bar input {
  flex: 1;
  padding: 0 16px;
  border: 2px solid #ccc;
  border-right: none;
  border-radius: 8px 0 0 8px;
  font-size: 16px;
  outline: none;
}

.search-bar button {
  background-color: #8B0000;
  color: white;
  border: none;
  width: 52px;
  border-radius: 0 8px 8px 0;
  cursor: pointer;
  font-size: 18px;
}

/* Ações do Usuário */
.user-actions {
  display: flex;
  align-items: center;
  gap: 28px;
}

.user-actions a {
  display: flex;
  align-items: center;
  gap: 7px;
  color: #222;
  text-decoration: none;
  font-size: 15px;
}

.cart {
  position: relative;
}

.cart-count {
  position: absolute;
  top: -5px;
  right: -8px;
  background-color: #8B0000;
  color: white;
  font-size: 12px;
  width: 18px;
  height: 18px;
  border-radius: 50%;
  display: flex;
  align-items: center;
  justify-content: center;
  font-weight: bold;
}

/* Categorias */
.categories {
  background-color: white;
  padding: 16px 0;
  border-bottom: 1px solid #eee;
}

.categories .container {
  max-width: 1200px;
  margin: 0 auto;
  display: flex;
  justify-content: space-between;
  flex-wrap: wrap;
  gap: 18px;
  padding: 0 20px;
}

.category-item {
  display: flex;
  flex-direction: column;
  align-items: center;
  text-decoration: none;
  color: #333;
  font-size: 13.5px;
  transition: all 0.3s;
}

.category-item i {
  font-size: 26px;
  margin-bottom: 8px;
  color: #8B0000;
}

.category-item:hover {
  color: #8B0000;
  transform: translateY(-3px);
}

/* Responsivo */
@media (max-width: 992px) {
  .categories .container {
    justify-content: center;
  }
}

@media (max-width: 768px) {
  .top-bar .container {
    text-align: center;
    justify-content: center;
  }
  
  .search-bar {
    max-width: 100%;
    order: 3;
    width: 100%;
  }
}