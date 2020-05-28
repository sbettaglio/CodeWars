function dominator(arr) {
  arr.sort();
  let value = 0;
  let count = 0;
  for (var i = 0; i < arr.length; i++) {
    if (value == arr[i]) {
      count++;
    } else {
      value = arr[i];
      count = 1;
    }
    if (count > arr.length / 2) return value;
  }
  return -1;
}
