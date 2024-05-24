const square = document.getElementById("square");
let x = 10,
  y = 10,
  vx = 10,
  vy = 10;
const delay = 30;

const goTo = (x, y) => {
  square.style.left = x + "px";
  square.style.top = y + "px";
};

setInterval(() => {
  x += vx;
  y += vy;
  if (x < 0) {
    x -= vx;
    vx = Math.trunc(Math.random() * 10 + 1);
    x += vx;
  }
  if (x > 800) {
    x -= vx;
    vx = -Math.trunc(Math.random() * 10 + 1);
    x += vx;
  }
  if (y < 0) {
    y -= vy;
    vy = Math.trunc(Math.random() * 10 + 1);
    y += vy;
  }
  if (y > 800) {
    y -= vy;
    vy = -Math.trunc(Math.random() * 10 + 1);
    y += vy;
  }
  goTo(x, y);
}, delay);
