/* Example
const dishes = [
    {
        name: "owsianka",
        category: "śniadanie"
    }
]*/

const dishes = [
  {
    name: "owsianka",
    category: "Śniadanie",
  },
  {
    name: "Lody",
    category: "Deser",
  },
  {
    name: "Ciasto",
    category: "Deser",
  },
  {
    name: "Jajecznica",
    category: "Śniadanie",
  },
  {
    name: "Kotlet mielony",
    category: "Obiad",
  },
  {
    name: "Kotlet schabowy",
    category: "Obiad",
  },
  {
    name: "Owoce morza",
    category: "Kolacja",
  },
  {
    name: "Sałatka",
    category: "Kolacja",
  },
];

const countCategory = (category) => {
  let count = 0;
  for (const element of dishes) {
    if (element.category === category) count++;
  }
  if (count > 0) return count;
  return 1;
};

const categories = {};

for (const index in dishes) {
  if (categories[dishes[index].category] !== undefined)
    categories[dishes[index].category]++;
  else categories[dishes[index].category] = 1;
}

console.log(categories);
