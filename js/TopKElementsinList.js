const topKFrequent = (nums, k) => {
  let map = new Map();
  let length = nums.length;
  for (let i = 0; i < length; i++) {
    if (map[nums[i]] > 0) map[nums[i]] += 1;
    else map[nums[i]] = 1;
  }

  let obj = Object.keys(map).map((key) => [Number(key), map[key]]);

  let sortedObj = obj.sort((a, b) => {
    return b[1] - a[1];
  });

  let result = [];

  for (let i = 0; i < k; i++) {
    result.push(sortedObj[i][0]);
  }

  return result;
};

const topKFrequentEnhanced = (nums, k) => {
  let map = new Map();
  let arr = new Array(nums.length + 1).fill(0);
  let ans = [];

  nums.forEach(el => {
    const val = map.get(el) || 0;
    map.set(el, val + 1);
});
  for (let [key, value] of map) {
    const prev = arr[value] || [];
    prev.push(key);
    arr[value] = prev;
  }

  arr.reverse();
  for (let el of arr) {
    if (k < 1) break;
    if (el)
      for (let el2 of el) {
        ans.push(el2);
        k--;
      }
  }

  return ans;
};

//testing
let nums2 = [3, 3, 3, 3, 3, 1, 1, 1, 2, 2, 2, 2];
let k = 1;

console.log(topKFrequent(nums2, k));
console.log(topKFrequentEnhanced(nums2, k));
