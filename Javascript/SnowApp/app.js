const count = 500,
  minSize = 1,
  maxSize = 20,
  minW = 0,
  maxW = 1800,
  minH = 0,
  maxH = 900;
let x = [],
  y = [],
  sf = [],
  vY = [],
  vX = [],
  vXTime = [],
  minVxTime = 100,
  maxVxTime = 120,
  v = 70;

function Random(from = 0, to = 99) {
  /*    do {
                  let randomNumber = Math.random() * 100;
                  if (randomNumber <= to && randomNumber >= from)
                      return randomNumber.toFixed();
              } while(true);*/
  return Math.floor(Math.random() * (to - from + 1) + from);
}

function CreateSnowflake(id) {
  const img = document.createElement("img");
  img.src = "assets/snow.png";
  img.id = `snowflake-${id}`;
  img.className = "snowflake";
  const size = Random(minSize, maxSize);
  img.style.width = `${size}px`;

  sf[id] = {};
  sf[id].size = size;

  return document.body.appendChild(img);
}

function SnowflakeGo(sf, x, y) {
  sf.style.left = `${x}px`;
  sf.style.top = `${y}px`;
}

function MoveSnow() {
  for (let i = 0; i < count; i++) {
    vXTime[i]--;
    if (vXTime[i] === 0) {
      vY[i] = RandomSpeed(sf[i], true);
      vX[i] = RandomSpeed(sf[i]);
      vXTime[i] = Random(minVxTime, maxVxTime);
    }
    y[i] += vY[i];
    if (y[i] > maxH) y[i] = minH;
    x[i] += vX[i];
    if (x[i] > maxW) x[i] = minW;
    SnowflakeGo(sf[i].img, x[i], y[i]);
  }

  requestAnimationFrame(MoveSnow);
}

function RandomSpeed(sf, isBackwards = false) {
  return isBackwards
    ? sf.size >= 15
      ? Random(2, 3)
      : sf.size < 15 && sf.size > 8
        ? Random(1, 2)
        : 1
    : sf.size >= 15
      ? Random(-2, 3)
      : sf.size < 15 && sf.size > 8
        ? Random(-2, 2)
        : Random(-1, 1);
}

function Init() {
  for (let i = 0; i < count; i++) {
    let snowflake = CreateSnowflake(i);
    sf[i].img = document.getElementById(`snowflake-${i}`);
    x[i] = Random(minW, maxW);
    y[i] = Random(minH, maxH);
    vY[i] = RandomSpeed(sf[i], true);
    vX[i] = RandomSpeed(sf[i]);
    vXTime[i] = Random(minVxTime, maxVxTime);
  }
  for (let i = 0; i < count; i++) SnowflakeGo(sf[i].img, x[i], y[i]);

  MoveSnow();
}

Init();
if (v > 100) v = 100;
