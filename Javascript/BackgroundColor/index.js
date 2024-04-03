const changeBackground = () => {
  document.body.style.backgroundColor = getComputedStyle(
    document.getElementById(event.target.id),
  ).backgroundColor;
};
