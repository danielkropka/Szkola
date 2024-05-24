const result = document.getElementById("result");

const names = ["Maciek", "Róźa", "Bartek", "Jakub", "Sebastian"];
result.innerHTML += names.join("<br>");

const fruits = ["Apple", "Lemon", "Orange"];
const array = [10];

const appendArray = (array, value) => array.push(value);
appendArray(array, 5);

console.log(array);
