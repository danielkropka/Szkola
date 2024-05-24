const greater = (a, b) => (a >= b ? a : b);

let result = greater(9, 8);
console.log(result);

function getType(type) {
  switch (typeof type) {
    case "string":
      console.log("tekst");
      break;
    case "number":
      console.log("liczba");
      break;
    case "boolean":
      console.log("logika");
      break;
    default:
      break;
  }
}

getType("tak");
getType(true);
getType(5);
