setInterval(() => {
  const date = new Date();
  document.querySelector("#timer").innerText = `${convertString(
    date.getHours()
  )}:${convertString(date.getMinutes())}:${convertString(date.getSeconds())}`;
}, 1000);

const convertString = (x) => {
  return x < 10 ? `0${x}` : x;
};
