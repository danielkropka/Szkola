document.getElementById("block").addEventListener("click", function (event) {
  const { target } = event;
  const style = getComputedStyle(target);
  target.style.left = `${parseFloat(style.left) + 5}px`;
});
