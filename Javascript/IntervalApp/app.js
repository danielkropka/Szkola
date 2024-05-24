/*
const output = document.querySelector("#output");
let counter = 0;
let intervalID = null;

intervalID = setInterval(() => {
  if (counter === 68) clearInterval(intervalID);
  counter++;
  output.innerHTML = `<h2>${counter}</h2>`;
}, 10);

document.querySelector("#stop_button").addEventListener("click", () => {
  clearInterval(intervalID);
});
*/

document.querySelector("#setReminder").addEventListener("click", () => {
  setTimeout(
    () => {
      alert(document.querySelector("#description").value);
    },
    document.querySelector("#time").value * 1000,
  );
});
