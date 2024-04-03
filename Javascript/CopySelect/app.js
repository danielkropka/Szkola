const handleSelect = () => {
  /*const { target } = event;
  /!*  const selects = document.getElementsByTagName("select");
  for (let i = 0; i < selects.length; i++) {
    selects[i].options[0].hidden = true;
  }*!/
  switch (target.id) {
    case "select-1":
      document.getElementById("select-2").selectedIndex = target.selectedIndex;
      break;
    case "select-2":
      document.getElementById("select-1").selectedIndex = target.selectedIndex;
      break;
  }*/
  const { target } = event;
  switch (target.id) {
    case "select-1":
      document.getElementById("select-2").value = target.value;
      break;
    case "select-2":
      document.getElementById("select-1").value = target.value;
      break;
  }
};
