const Trinomial = (a, b, c) => {
  if (a === 0) {
    alert("A nie może być równe 0");
    return;
  }

  const delta = Math.pow(b, 2) - 4 * a * c;

  if (delta < 0) console.log("Brak rozwiązań");
  if (delta === 0) console.log(`1 rozwiązanie\nX1=X2: ${-b / (2 * a)}`);
  if (delta > 0)
    console.log(
      `2 rozwiązania:\nX1: ${(-b - Math.sqrt(delta)) / (2 * a)}\nX2: ${(-b + Math.sqrt(delta)) / (2 * a)}`,
    );
};

const bmi = (weight, height) => {
  const result = weight / Math.pow(height, 2).toFixed();
  console.log(result);
  console.log(
    result <= 20
      ? "Niedowaga"
      : result >= 20 && result <= 25
        ? "Prawidłowa"
        : result > 25 && result < 30
          ? "Nadwaga"
          : result >= 30
            ? "Otyłość"
            : null,
  );
};
