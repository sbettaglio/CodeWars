function cleanString(s) {
  let sArray = s.split("");
  for (let i = 0; i < sArray.length; i++) {
    if (sArray[i] === "#") {
      sArray.pop(sArray);
    }
  }
}
