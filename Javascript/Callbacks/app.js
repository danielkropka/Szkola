const output = document.getElementById("output");
output.innerHTML = "<h2>Callbacks</h2>";

const persons = [
  {
    firstName: "Krzysztof",
    lastName: "Antoniuk",
    age: 18,
    height: 1.81,
    hobbies: ["Seksitowskie żarty"],
  },
  {
    firstName: "Róźa",
    lastName: "Szczerbicka",
    age: 19,
    height: 1.76,
    hobbies: ["420", "Granie na flecie"],
  },
  {
    firstName: "Mateusz",
    lastName: "Silber",
    age: 18,
    height: 1.83,
    hobbies: ["Granie na nerwach", "Cimcirimcim oliwię"],
  },
];

const showHobbies = (hobbies) => {
  let result = "";
  for (const hobby of hobbies) result += `&nbsp- ${hobby}<br/>`;
  return result;
};

const show = (array) => {
  for (const element of array) {
    output.innerHTML += `<h2>${element.firstName} ${
      element.lastName
    }</h2><p>Wzrost: ${element.height}</p><p>Wiek: ${
      element.age
    }</p><p>Hobby:<br/>${showHobbies(element.hobbies)}</p>`;
  }
};

show(persons);

const showPersonH = (person) => {
  output.innerHTML += `<br/>${person.lastName} ${person.firstName} ${
    person.height
  } ${person.hobbies.join(", ")}`;
};

const showPersonV = (person) => {
  output.innerHTML += `<br/>${person.lastName}<br/>${person.firstName}<br/>${
    person.height
  }<br/>${person.hobbies.join(", ")}`;
};

const showPersons = (t, callback) => {
  for (const person of t) callback(person);
};

showPersons(persons, showPersonH);

setInterval(
  (person) => {
    showPersonV(person);
  },
  3000,
  persons[0]
);
