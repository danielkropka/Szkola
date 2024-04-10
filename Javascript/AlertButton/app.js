const handleClick = () => {
  let _prompt = prompt("Wprowadź imię: ", "Angelika");
  alert(_prompt ? `Cześć ${_prompt}` : "Miałeś podać imię");
};
