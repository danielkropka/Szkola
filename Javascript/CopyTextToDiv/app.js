(function () {
  document
    .querySelector("#button-result")
    .addEventListener("click", function () {
      const input = document.querySelector("#textarea");
      if (input.value.trim().length < 1) {
        alert("Musisz coś wpisać");
        input.focus();
        return;
      }
      document.querySelector("#result").innerText = input.value;
    });
})();
