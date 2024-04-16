(function () {
  const buttons = document.querySelectorAll(".button");
  for (const button of buttons) {
    button.addEventListener("click", function () {
      document.getElementById("block").style.backgroundColor =
        getComputedStyle(button).backgroundColor;
    });
  }
})();
