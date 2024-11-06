const { showPerson } = require("./func.js");
const { firstName, lastName } = require("./var.js");
const os = require("os");
const { readFile, writeFile } = require("fs");

showPerson(firstName, lastName);

console.log("System:", os.userInfo());

readFile("./1.txt", (err, data) => {
  if (err) throw err;
  writeFile("./person.txt", `${data} ${lastName}\n`, (err) => {
    if (err) throw err;
  });
});
