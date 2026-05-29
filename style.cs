* {
  margin: 0;
  padding: 0;
  box-sizing: border-box;
}

body {
  font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;
  background-color: #f9f9f9;
}

/* ==================== BARRA SUPERIOR ==================== */
.top-bar {
  background-color: #8B0000;
  color: white;
  padding: 10px 0;
  font-size: 14.5px;
}

.top-bar .container {
  max-width: 1200px;
  margin: 0 auto;
  padding: 0 20px;
  display: flex;
  align-items: center;
  justify-content: space-between;
  flex-wrap: wrap;
  gap: 12px;
}

.top-bar a {
  color: white;
  text-decoration: none;
}

.top-bar .social i {
  margin-left: 14px;
  font-size: 17px;
}

/* ==================== HEADER PRINCIPAL ==================== */
.main-header {
  background-color: #ffffff;
  padding: 20px 0;
  box-shadow: 0 2px 8px rgba(0, 0, 0, 0.08);
  border-bottom: 1px solid #eee;
}

.main-header .container {
  max-width: 1200px;
  margin: 0 auto;
  padding: 0 20px;
  display: flex;
  align-items: center;
  justify-content: space-between;
  gap: 20px;
}

/* Logo */
.logo {
  display: flex;
  align-items: center;
  gap: 14px;
  text-decoration: none;
  color: #222;
}

.logo-icon {
  background: linear-gradient(135deg, #8B0000, #5C0000);
  color: white;
  width: 62px;
  height: 62px;
  border-radius: 12px;
  display: flex;
  align-items: center;
  justify-content: center;
  font-size: 36px;
  font-weight: bold;
  box-shadow: 0 5px 15px rgba(139, 0, 0, 0.3);
}

.logo-text strong {
  font-size: 29px;
  line-height: 1.1;
}

.logo-text small {
  font-size: 14px;
  color: #555;
  font-weight: 600;
}

/* Barra de Pesquisa */
.search-bar {
  flex: 1;
  max-width: 520px;
  display: flex;
}

.search-bar input {
  flex: 1;
  padding: 14px 18px;
  border: 2px solid #ddd;
  border-right: none;
  border-radius: 10px 0 0 10px;
  font-size: 16px;
  outline: none;
  transition: border 0.3s;
}

.search-bar input:focus {
  border-color: #8B0000;
}

.search-bar button {
  background-color: #8B0000;
  color: white;
  border: none;
  padding: 0 24px;
  border-radius: 0 10px 10px 0;
  cursor: pointer;
  font-size: 18px;
  transition: background 0.3s;
}

.search-bar button:hover {
  background-color: #6B0000;
}

/* Ícones do Usuário */
.user-actions {
  display: flex;
  align-items: center;
  gap: 28px;
}

.user-actions a {
  display: flex;
  align-items: center;
  gap: 8px;
  color: #222;
  text-decoration: none;
  font-size: 15.5px;
  transition: color 0.3s;
}

.user-actions a:hover {
  color: #8B0000;
}

.cart {
  position: relative;
}

.cart-count {
  position: absolute;
  top: -6px;
  right: -8px;
  background-color: #8B0000;
  color: white;
  font-size: 12px;
  width: 19px;
  height: 19px;
  border-radius: 50%;
  display: flex;
  align-items: center;
  justify-content: center;
  font-weight: bold;
}

/* ==================== CATEGORIAS ==================== */
.categories {
  background-color: white;
  padding: 18px 0;
  border-bottom: 1px solid #eee;
}

.categories .container {
  max-width: 1200px;
  margin: 0 auto;
  padding: 0 20px;
  display: flex;
  justify-content: space-between;
  flex-wrap: wrap;
  gap: 20px;
}

.category-item {
  display: flex;
  flex-direction: column;
  align-items: center;
  text-decoration: none;
  color: #333;
  font-size: 13.8px;
  transition: all 0.3s ease;
}

.category-item i {
  font-size: 27px;
  margin-bottom: 8px;
  color: #8B0000;
}

.category-item:hover {
  color: #8B0000;
  transform: translateY(-4px);
}

/* ==================== RESPONSIVO ==================== */
@media (max-width: 992px) {
  .categories .container {
    justify-content: center;
  }
}

@media (max-width: 768px) {
  .main-header .container {
    flex-wrap: wrap;
    justify-content: center;
    text-align: center;
  }
  
  .search-bar {
    width: 100%;
    max-width: 100%;
    order: 3;
    margin-top: 12px;
  }
  
  .top-bar .container {
    justify-content: center;
  }
}