const isAnagram = function (str1, str2, map = new Map()) {
  if (!(str1.length == str2.length)) return false;

  addFrequency(str1,map);
  subtractFrequency(str2,map);

  return checkFrequency(map);
};

const addFrequency = (str, map) => {
  for (const char of str) {
    const count = (map.get(char) || 0) + 1;

    map.set(char, count);
  }
};

const subtractFrequency = (str, map) => {
  for (const char of str) {
    if (!map.has(char)) continue;

    const count = map.get(char) - 1;

    map.set(char, count);
  }
};

const checkFrequency = (map) => {
    for (const [char,count] of map){
        const isEmpty = count === 0;
        if(!isEmpty) return false;
    }

    return true;
}

console.log(isAnagram("asdf","fdas"));

