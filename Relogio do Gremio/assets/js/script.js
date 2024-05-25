const horas = document.getElementById('horas');
const minutos = document.getElementById('minutos');
const segundos = document.getElementById('segundos');

const relogio = setInterval (()=>{
    let dateToday = new Date();
    horas.textContent = dateToday.getHours().toString().padStart(2,'0');
    minutos.textContent = dateToday.getMinutes().toString().padStart(2,'0');
    segundos.textContent = dateToday.getSeconds().toString().padStart(2,'0');
})