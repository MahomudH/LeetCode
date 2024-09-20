let longestConsecutive = (arr) => {
  let map = new Set(arr);
  let maxLength = 0;
  for (let i = 0, length = arr.length; i < length; i++) {
    let startPoint = arr[i];
    let tempLength = 0;
    if (map.has(startPoint - 1)) continue;
    else {
      tempLength++;
      if (tempLength > maxLength) maxLength = tempLength;
      while (map.has(startPoint + 1)) {
        tempLength++;
        startPoint++;
        if (tempLength > maxLength) maxLength = tempLength;
      }
    }
  }
  return maxLength;
};

arr = [1, 200,201,2,5,9,7,8,6];
console.log(longestConsecutive(arr));

