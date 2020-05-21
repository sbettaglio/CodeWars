// return the missing number!
function findNumber(array) {
  let sum = array.length + 1;
  let expectedCount = (sum * (sum + 1)) / 2;
  let actualCount = array.reduce((a, b) => a + b, 0);
  return expectedCount - actualCount;
}
