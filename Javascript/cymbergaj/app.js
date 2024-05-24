const books = [
  {
    title: "Pan Tadeusz",
    author: "Adam Mickiewicz",
    img: "1.jpg",
    year: 1834,
    prices: [100, 80],
    details: {
      pages: 200,
      cover: "Twarda",
    },
  },
  {
    title: "Milion małych kawałków",
    author: "James Frey",
    img: "2.jpg",
    prices: [120, 90],
    details: {
      pages: 250,
    },
  },
  {
    title: "Lalka",
    author: "Stefan Żeromski",
    img: "3.jpg",
    year: 1889,
    prices: [90],
    details: {
      cover: "Twarda",
    },
  },
  {
    title: "Krzyżacy",
    author: "Henryk Sienkiewicz",
    img: "4.jpg",
    year: 1900,
    prices: [110, 75],
    details: {
      pages: 1200,
      cover: "Twarda",
    },
  },
  {
    title: "My dzieci z dworca ZOO",
    author: "Christiane F.",
    img: "5.jpg",
    year: 1978,
    prices: [55, 30],
    details: {
      pages: 200,
    },
  },
];

const addBook = () => {
  const title = document.querySelector("#title").value;
  const author = document.querySelector("#author").value;
  const year = document.querySelector("#year").value;
  const pages = document.querySelector("#pages").value;
  const cover = document.querySelector("#cover").value;
  const price = document.querySelector("#price").value;
  const priceDiscount = document.querySelector("#priceDiscount").value;

  books.push({
    title,
    author,
    year,
    details: {
      pages,
      cover,
    },
    prices: [price, priceDiscount],
  });
  render();
};

document.querySelector("#add_button").addEventListener("click", addBook);

const render = () => {
  const resultElement = document.querySelector("#books_result");
  resultElement.innerHTML = "";
  let result = "";
  for (const book of books) {
    const { pages, cover } = book.details;
    result = `<span style="text-align: center"><strong>${book.title}</strong></span>
        <span>Autor: ${book.author}</span>
        <img src=${book.img} alt=${book.img ? book.img : "brak"} />
        <span>Rok: ${book.year ? book.year : "-"}</span>
        ${pages ? `<span>Ilość stron: ${pages}</span>` : ""}
        ${cover ? `<span>Okładka: ${cover}</span>` : ""}
        `;

    result += `<div>Ceny: ${book.prices.join(", ")}</div>`;
    resultElement.innerHTML += `<div class="book">${result}</div>`;
  }
};

render();
