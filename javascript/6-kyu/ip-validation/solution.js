function isValidIP(str) {
  let octet = str.split(".");
  let valid = false;
  if (octet.length !== 4) {
    return false;
  } else {
    for (let i = 0; i < octet.length; i++) {
      if (typeof (octet[i] !== Number)) {
        return false;
      } else if (octet[i] >= 0 && octet[i] <= 255) {
        valid = true;
      } else if (octet === "0") {
        valid = true;
      }
    }
    return valid;
  }
}
