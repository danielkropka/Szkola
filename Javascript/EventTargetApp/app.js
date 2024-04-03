function handleClick() {
  const spanValue = event.target.innerText;
  event.target.innerHTML = `<input value=${spanValue} />`;
}

function handleEvent(e) {
  console.log(e.key);
}

addEventListener();
