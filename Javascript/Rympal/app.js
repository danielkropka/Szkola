document.getElementById("result-button").addEventListener("click", function () {
  const { value: height } = document.getElementById("height");
  const { value: weight } = document.getElementById("weight");

  if (isNaN(height) || height < 1) {
    alert("Wprowadź poprawnie wzrost!");
    return;
  }
  if (isNaN(weight) || weight < 1) {
    alert("Wprowadź poprawnie wagę");
    return;
  }

  document.getElementById("result").innerText =
    `${(weight / Math.pow(height, 2)).toFixed(2)}`;
});
