const Body = document.querySelector("DFN");

Body.addEventListener("click", updateName);

const time = new Date()
function updateName() {
  Body.textContent = time.getUTCFullYear();
}