const array = ["Maciej", 5, "Ale heca", 101, 50, 1];

const showArrayInDiv = (t) => {
  document.querySelector("#tablica").innerText += `${t.toString()}\n`;
};

showArrayInDiv(array);

const findElement = (t, needle) => {
  for (let i = 0; i < t.length; i++) if (t[i] === needle) return i;
  return -1;
};

console.log(findElement(array, "Ale heca"));

const addElement = (t, element) => (t[t.length] = element);

addElement(array, "cosik");

showArrayInDiv(array);

const deleteLastElement = (t) => t.pop();

console.log(deleteLastElement(array));
showArrayInDiv(array);
