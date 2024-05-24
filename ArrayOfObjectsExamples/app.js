const advancedArray = [
  {
    id: 1,
    name: "Alice",
    age: 28,
    skills: ["JavaScript", "React", "Node.js"],
    address: {
      street: "123 Main St",
      city: "Wonderland",
      zip: "12345",
    },
    isActive: true,
    getFullName: function () {
      return `${this.name} Doe`;
    },
  },
  {
    id: 2,
    name: "Bob",
    age: 32,
    skills: ["Python", "Django", "Machine Learning"],
    address: {
      street: "456 Elm St",
      city: "Dreamland",
      zip: "54321",
    },
    isActive: false,
    getFullName: function () {
      return `${this.name} Smith`;
    },
  },
  {
    id: 3,
    name: "Charlie",
    age: 25,
    skills: ["Java", "Spring", "Hibernate"],
    address: {
      street: "789 Oak St",
      city: "Fantasyland",
      zip: "67890",
    },
    isActive: true,
    getFullName: function () {
      return `${this.name} Brown`;
    },
  },
];

const render = () => {
  const resultDiv = document.querySelector("#result");
  for (const person of advancedArray) {
    resultDiv.innerText += `ID: ${person.id} |  ${person.getFullName()} \nSkille:`;
    for (const skill of person.skills) {
      resultDiv.innerText += ` ${skill}, `;
    }
    resultDiv.innerHTML += `<br/><span>Ulica: ${person.address.street}, Miasto: ${person.address.city}, Kod pocztowy: ${person.address.zip}</span>`;
    resultDiv.innerText += "\n\n";
  }
};

render();
