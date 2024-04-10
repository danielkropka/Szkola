const ValidateInput = () => {
  const element = document.getElementById("inp");
  if (element.value.trim() === "") alert("Musisz coś wpisać");
  else if (isNaN(parseFloat(element.value))) alert("Musisz wpisać liczbę");
  else return;

  element.focus();
};
