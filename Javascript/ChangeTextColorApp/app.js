const wordsLimit = 10;
let overflow = false;
let element = document.getElementById("input");
const regex = /[ąćśęńółżźćĄĆĘŃÓŁŻŹĆŚ]/g;
const handleChange = () => {
  const { value } = element;
  const polishLetters = value.match(regex);
  const count =
    (polishLetters?.length * 2 || 0) +
    value.length -
    (polishLetters?.length || 0);
  if (count > wordsLimit) {
    if (!overflow) element.style.color = "#f00";
    overflow = true;
  } else {
    if (overflow) element.style.color = "#000";
    overflow = false;
  }
  console.log(count);
};
