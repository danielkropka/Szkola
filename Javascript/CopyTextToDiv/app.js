(function () {
  document
    .querySelector("#button-result")
    .addEventListener("click", function () {
      document.getElementById("result").innerText =
        document.getElementById("textarea").value;
    });
})();
