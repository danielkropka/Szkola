function calcBMI() {
  event.preventDefault();
  const height = document.getElementById("height").value;
  const weight = document.getElementById("weight").value;

  document.getElementById("weight-error").hidden = !isNaN(weight);
  document.getElementById("height-error").hidden = !isNaN(height);

  console.log(isNaN(weight) || weight === "");
  if (isNaN(weight) || isNaN(height)) return;

  document.getElementById("result").value = (
    weight /
    (height * height)
  ).toFixed();
}
