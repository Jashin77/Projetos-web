const buttons = document.querySelectorAll('.alternativa-btn');
const form = document.querySelector('form');
const respostaInput = document.getElementById('resposta-input');

console.log("Botões encontrados:", buttons);
console.log("Formulário encontrado:", form);
console.log("Input encontrado:", respostaInput);

buttons.forEach(button => {
    button.addEventListener('click', () => {
        const respostaSelecionada = button.dataset.resposta;

        const respostaCorreta = parseInt(document.body.getAttribute('data-resposta-correta'));
        console.log("Resposta correta:", respostaCorreta);
        console.log("Resposta selecionada:", respostaSelecionada);

        respostaInput.value = respostaSelecionada;

        if (parseInt(respostaSelecionada) === respostaCorreta) {
            button.classList.add('correct');
        } else {
            button.classList.add('incorrect'); 
        }

        buttons.forEach(btn => btn.disabled = true);

        setTimeout(() => {
            form.submit();
        }, 1000);
    });
});
