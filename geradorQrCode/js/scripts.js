const container = document.querySelector(".container");
const qrCodeBtn = document.querySelector("#qr-form button");

const qrCodeInput = document.querySelector("#qr-form input");

const qrCodeImg = document.querySelector("#qr-code img");


//eventos
function generateQRCode() {
    const qrCodeInputValue = qrCodeInput.value;

    if(!qrCodeInputValue)return;

    qrCodeBtn.innerText = "Gerando QR Code...";

    qrCodeImg.src = `https://api.qrserver.com/v1/create-qr-code/?size=150x150&data=${qrCodeInputValue}`

    qrCodeImg.addEventListener("load", () => {
        container.classList.add("active");
        qrCodeBtn.innerText = "Código gerado!";
    });
}

qrCodeBtn.addEventListener("click", () => {
    generateQRCode();
});
qrCodeInput.addEventListener("keydown", (e) => {
    if(e.code === "Enter"){
        generateQRCode();
    }
});

// limpara area do QR Code
qrCodeInput.addEventListener("keyup", () => {
    if(!qrCodeInput.value) {
        container.classList.remove("active");
        qrCodeImg.src = "";
        qrCodeBtn.innerText = "Gerar QR Code";
    }
});
