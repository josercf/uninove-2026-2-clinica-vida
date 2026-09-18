const busca = document.querySelector('#busca-especialidade');
const cards = document.querySelectorAll('.lista-especialidades li');

busca.addEventListener('input', () => {
    const termo = busca.value.trim().toLowerCase();
    cards.forEach((card) => {
        const nome = card.textContent.toLowerCase();
        card.classList.toggle('oculto', !nome.includes(termo));
    });
});