function addLetters(...letters) {
  let alphabet = "zabcdefghijklmnopqrstuvwxy";
  let sum = 0;
  for (letter of letters) {
    sum += alphabet.indexOf(letter);
  }
  return alphabet[sum % 26];
}
