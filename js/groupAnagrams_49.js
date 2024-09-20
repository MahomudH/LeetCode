let groupAnagrams = (str) => {
  let map = {};
  let index = 0;
  let result = [];

  let sumOfWord = (word) => {
    let sum = 0;
    let length = word.length;
    for (let i = 0 ; i < length; i++)
      sum += (word[i].charCodeAt() ** 5);
    return sum;
  };

  for (let i = 0,length =str.length; i < length; i++) {
    let sumWord = sumOfWord(str[i]);
    
    if (!map.hasOwnProperty(sumWord)) {
      map[sumWord] = index;
      result.push([str[i]]);
      index++;
    } else {
      result[map[sumWord]].push(str[i]);
    }

  }

  return result
};

let test = groupAnagrams(['tea','eat','nat','fat','ate','tan','fa','vbnxkji','wqdtegp']);

console.log(test);
