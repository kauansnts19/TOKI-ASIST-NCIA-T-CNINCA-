* {
  margin: 0;
  padding: 0;
  box-sizing: border-box;
}

body {
  font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;
}

/* Barra Superior - Bordô */
.top-bar {
  background-color: #8B0000; /* Bordô escuro */
  color: white;
  padding: 8px 0;
  font-size: 14px;
}

.top-bar .container {
  max-width: 1200px;
  margin: 0 auto;
  display: flex;
  align-items: center;
  justify-content: space-between;
  flex-wrap: wrap;
  gap: 10px;
  padding: 0 20px;
}

.top-bar a {
  color: white;
  text-decoration: none;
  margin-left: 15px;
}

.social i {
  margin-left: 12px;
  font-size: 16px;
}

/* Header Principal */
.main-header {
  background-color: #f8f8f8;
  padding: 15px 0;
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

/* Logo - TOKI.co */
.logo {
  display: flex;
  align-items: center;
  gap: 12px;
  color: #222;
}

.logo-icon {
  background: linear-gradient(135deg, #8B0000, #4A0000);
  color: white;
  width: 55px;
  height: 55px;
  border-radius: 10px;
  display: flex;
  align-items: center;
  justify-content: center;
  font-size: 32px;
  font-weight: bold;
  box-shadow: 0 4px 10px rgba(139, 0, 0, 0.4);
}

.logo strong {
  font-size: 26px;
  letter-spacing: -1px;
}

.logo small {
  font-size: 13px;
  color: #555;
  font-weight: 600;
}

/* Barra de Pesquisa */
.search-bar {
  flex: 1;
  max-width: 500px;
  display: flex;
}

.search-bar input {
  flex: 1;
  padding: 12px 16px;
  border: 2px solid #ddd;
  border-right: none;
  border-radius: 8px 0 0 8px;
  font-size: 16px;
  outline: none;
}

.search-bar button {
  background-color: #8B0000;
  color: white;
  border: none;
  padding: 0 20px;
  border-radius: 0 8px 8px 0;
  cursor: pointer;
  font-size: 18px;
}

/* Ações do Usuário */
.user-actions {
  display: flex;
  align-items: center;
  gap: 25px;
}

.user-actions a {
  display: flex;
  align-items: center;
  gap: 6px;
  color: #222;
  text-decoration: none;
  font-size: 15px;
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
  width: 18px;
  height: 18px;
  border-radius: 50%;
  display: flex;
  align-items: center;
  justify-content: center;
}

/* Categorias */
.categories {
  background-color: white;
  padding: 15px 0;
  border-bottom: 1px solid #eee;
}

.categories .container {
  max-width: 1200px;
  margin: 0 auto;
  display: flex;
  justify-content: space-around;
  flex-wrap: wrap;
  gap: 15px;
  padding: 0 20px;
}

.category-item {
  display: flex;
  flex-direction: column;
  align-items: center;
  text-decoration: none;
  color: #333;
  font-size: 13px;
  text-align: center;
  transition: color 0.3s;
}

.category-item i {
  font-size: 24px;
  margin-bottom: 6px;
  color: #8B0000;
}

.category-item:hover {
  color: #8B0000;
}

/* Responsivo */
@media (max-width: 768px) {
  .top-bar .container {
    justify-content: center;
    text-align: center;
  }
  .search-bar {
    max-width: 100%;
  }
}