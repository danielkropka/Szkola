const reminder = () => {
  setTimeout(() => {
    document.querySelector(".reminder").style.display = "block";
  }, document.querySelector("#seconds").value * 1000);
};

document.querySelector("#start").addEventListener("click", reminder);
document.querySelector("#remind_later").addEventListener("click", () => {
  document.querySelector(".reminder").style.display = "none";
  reminder();
});
document.querySelector("#confirm").addEventListener("click", () => {
  document.querySelector(".reminder").style.display = "none";
});
