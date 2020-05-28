function dominator(arr) {
  let value = -1;
  for (let i = 0; i < arr.length; i++) {
    let count = 0;
    for (let j = 0; j < arr.length; i++) {
      if (arr[i] === arr[j]) {
        count++;
      }
    }
    if (count > arr.length / 2) {
      value = arr[i];
    }
  }
  return value;
}
