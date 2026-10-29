const games = [
"PAC-MAN",
"GALAGA",
"DONKEY KONG",
"SPACE INVADERS",
"ASTEROIDS",
"CENTIPEDE",
"DIG DUG",
"JOUST",
"MS. PAC-MAN"
];

let currentIndex = 1; // Começa selecionado em GALAGA, igual na imagem de referência

const gameListElement = document.getElementById('gameList');

function renderMenu() {
gameListElement.innerHTML = '';

games.forEach((game, index) => {
const li = document.createElement('li');
li.className = `game-item ${index === currentIndex ? 'selected' : ''}`;

// Se for o selecionado, adiciona as setas características
const arrow = index === currentIndex ? '&gt;&gt; ' : '&gt; ';

li.innerHTML = `<span class="pointer">${arrow}</span>${game}`;
gameListElement.appendChild(li);
});
}

// Interatividade com o Teclado (Setas cima/baixo e Enter)
document.addEventListener('keydown', (event) => {
if (event.key === 'ArrowUp') {
currentIndex = (currentIndex
1 + games.length) % games.length;
renderMenu();
} else if (event.key === 'ArrowDown') {
currentIndex = (currentIndex + 1) % games.length;
renderMenu();
} else if (event.key === 'Enter') {
alert(`Carregando o jogo: ${games[currentIndex]}... Divirta-se!`);
}
});
// Renderização Inicial
renderMenu();