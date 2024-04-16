(function () {
  const blocks = document.querySelectorAll(".block");
  for (const block of blocks) {
    block.addEventListener("click", function (event) {
      alert(event.target.innerText);
    });
  }
})();
