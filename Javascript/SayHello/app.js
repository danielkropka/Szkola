document.getElementById("name").addEventListener("keypress", function (event) {
  if (event.code === "Enter") {
    alert(`Cześć ${event.target.value}`);
  }
});
