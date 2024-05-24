const persons = [];

document.querySelector("#submit").addEventListener("click", () => {
  const data = document.getElementsByTagName("input");
  persons.push({
    name: data[0].value,
    surname: data[1].value,
    height: data[2].value,
    weight: data[3].value,
  });
  render();
});

const render = () => {
  const items = document.querySelectorAll(".item");
  const list = document.querySelector(".list");
  if (items.length > 0) for (const item of items) list.removeChild(item);
  for (const person of persons) {
    const newItem = document.createElement("div");
    newItem.classList.add("item");
    newItem.innerHTML = `<span>${person.name} ${person.surname}</span><span>Wzrost ${person.height}m Waga ${person.weight}kg</span><span>BMI: ${person.weight / Math.pow(person.height, 2).toFixed()}</span>`;
    list.appendChild(newItem);
  }
};
