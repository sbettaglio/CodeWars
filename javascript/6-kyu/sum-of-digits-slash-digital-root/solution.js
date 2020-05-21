function digital_root(n) {
  let numString = n.toString();
  let root = 0;
  while (numString.length > 1) {
    for (let i = 0; i < numString.length; i++) {
      root += parseInt(numString[i]);
    }
    numString = root.toString();
    root = 0;
  }
  return parseInt(numString);
}
