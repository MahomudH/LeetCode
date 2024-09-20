var twoSum = function (nums, target) {
  let map = new Map();
  for (let i = 0, length = nums.length; i < length; i++) {
    let temp = target - nums[i];
    if (map.has(nums[i])) {
      return [map.get(nums[i]), i];
    }
    map.set(temp, i);
  }
  return [];
};

let nums2 = [2, 7, 11, 6, 15],
  target = 13;
console.log(twoSum(nums2, target));

