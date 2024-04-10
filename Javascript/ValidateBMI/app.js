const calculateBMI = () => {
  event.preventDefault();
  const height = document.getElementById("height").value;
  const weight = document.getElementById("weight").value;

  if (!validate(height) || !validate(weight)) return;

  document.getElementById("result").innerText =
    `${(weight / (height * height)).toFixed()}`;
};

function validate(value) {
  if (value.trim() === "") {
    alert("Musisz coś wpisać!");
    return false;
  } else if (isNaN(parseFloat(value))) {
    alert("Wprowadź liczbę!");
    return false;
  } else if (value <= 0) {
    alert("Liczba musi być większa od 0!");
    return false;
  }
}
