const handleChange = () => {
  const { id } = event.target;
  const element = document.getElementById(id);
  switch (id) {
    case "textArea-1":
      document.getElementById("textArea-2").value = element.value;
      break;
    case "textArea-2":
      document.getElementById("textArea-1").value = element.value;
      break;
  }
};
