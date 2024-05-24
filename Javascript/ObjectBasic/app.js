const person = {
  firstName: "Maciej",
  lastName: "Wojtaszek",
  age: 51,
  show() {
    console.log(this.firstName, this.lastName, this.age);
  },
  addAge() {
    console.log(this.age + 5);
  },
};

const array = [5, 1, 8, 4, 3, 7, 1, 6, 1];
for (let i = 0; i < array.length - 1; i++) {
  for (let j = 0; j < array.length - 1 - i; j++) {
    if (array[j] > array[j + 1])
      array[j + 1] = [array[j], (array[j] = array[j + 1])][0];
  }
}
console.log(array);

const middle = Math.floor(array.length / 2);
if (array.length % 2 === 0) {
  console.log(array[middle - 1] + array[middle] / 2);
} else {
  console.log(array[middle]);
}

person["weight"] = 88;
console.log(person);

const array2 = Object.keys(person);
for (const string of array2) {
  console.log(string);
}

console.log(Object.values(person));

console.log(Object.entries(person));

for (const key in Object.entries(person)) {
  console.log(Object.entries(person)[key][0], Object.entries(person)[key][1]);
}

let tablica = [5, 1],
  t = [1, 5];
console.log(tablica);
console.log(t);
tablica = t;
console.log(tablica);
