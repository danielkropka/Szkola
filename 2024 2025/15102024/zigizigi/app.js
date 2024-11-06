const { createServer } = require("http");

const server = createServer({ hostname: "localhost" }, (req, res) => {
  res.setHeader("content-type", "text/html;charset=utf8");
  switch (req.url) {
    case "/home":
      res.end("<h1><a href='/books/mybook'>My book</a></h1>");
      break;
    case "/books/mybook":
      res.end("<h1>essunia</h1>");
      break;
    case "/about":
      res.end("<h1>Pozdro</h1>");
      break;
    default:
      res.end("<h1>Bez rączek się nie da!</h1>");
      break;
  }
});

server.listen(5000);
