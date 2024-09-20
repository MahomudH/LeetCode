let validPalindrome = function (str) {
  let leftP = 0;
  let rightP = str.length - 1;

  let isAlphaNum = (c) => {
    return (
      (c >= "a" && c <= "z") || (c >= "0" && c <= "9") || (c >= "A" && c <= "Z")
    );
  };
  while (leftP <= rightP) {
    while (!isAlphaNum(str[leftP])) leftP++;

    while (!isAlphaNum(str[rightP])) rightP--;

    if (str[leftP].toLowerCase() != str[rightP].toLowerCase()) return false;

    leftP++;
    rightP--;
  }

  return true;
};

console.log(validPalindrome("A man0, a plan, A !@#canal: Pa0nama"));
