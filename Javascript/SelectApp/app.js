const menuItems = [
    {
      name: "WP",
      url: "https://www.wp.pl/",
    },
    {
      name: "Onet",
      url: "https://www.onet.pl/",
    },
    {
      name: "Gazeta",
      url: "https://www.gazeta.pl/",
    },
  ],
  element = document.getElementById("selectMenu");

for (const menuItem of menuItems) {
  element.appendChild(new Option(menuItem.name, menuItem.url));
}

element.addEventListener("change", (e) =>
  window.open(e.target.value, "_blank"),
);
