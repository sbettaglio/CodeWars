function cleanString(s) {
  let answer = [];
  for (let i = 0; i < s.length; i++) {
    if (s[i] === "#") {
      answer.pop();
    } else {
      answer.push(s[i]);
    }
  }
  return answer.join().replace(/,/g, "");
}
