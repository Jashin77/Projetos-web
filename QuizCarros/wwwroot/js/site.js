const buttons = document.querySelectorAll('.alternativa-btn');
const form = document.querySelector('form');
const respostaInput = document.getElementById('resposta-input');

// Verifica se os elementos foram encontrados
console.log("Botões encontrados:", buttons);
console.log("Formulário encontrado:", form);
console.log("Input encontrado:", respostaInput);

// Adiciona o evento de clique
buttons.forEach(button => {
    button.addEventListener('click', () => {
        const respostaSelecionada = button.dataset.resposta;

        // Pega a resposta correta do body
        const respostaCorreta = parseInt(document.body.getAttribute('data-resposta-correta'));
        console.log("Resposta correta:", respostaCorreta);
        console.log("Resposta selecionada:", respostaSelecionada);

        // Passa a resposta pro input hidden
        respostaInput.value = respostaSelecionada;

        // Muda a cor do botão
        if (parseInt(respostaSelecionada) === respostaCorreta) {
            button.classList.add('correct'); // Verde
        } else {
            button.classList.add('incorrect'); // Vermelho
        }

        // Desabilita todos os botões
        buttons.forEach(btn => btn.disabled = true);

        // Envia o formulário após 1 segundo
        setTimeout(() => {
            form.submit();
        }, 1000);
    });
});
