let counter = 2;

const calc = () => {
  let result = 0;
  let inputs = document.getElementsByClassName("input");
  for (let input of inputs) {
    result += Number(input.value);
  }

  document.getElementById("result").value = result;
};

const addField = () => {
  let container = document.getElementById("form-1");
  let newInput = document.createElement("input");
  newInput.className = "input";
  newInput.oninput = function () {
    calc();
  };
  newInput.id = `inp-${counter++}`;
  container.appendChild(newInput);
};
