const encode = (strs) => {
  let result = "";
  strs.forEach((el) => {
    result += el.length + "#" + el;
  });

  return result;
};

const decode = (str) => {
  let result = [];
  let j = 0;
  let strLength = str.length;
  while (j < strLength) {
    let i = 0;
    let iTemp = "";
    while (str[j] != "#") {
      iTemp += str[j];
      j++;
    }
    i = +iTemp;

    let word = str.substr(j + 1, i);
    result.push(word);

    j += i + 1;
  }

  return result;
};

let arr = ["neet","code","love","you"];
let arr2 = ["neet","code","love","you"];
console.log(decode(encode(arr)));
