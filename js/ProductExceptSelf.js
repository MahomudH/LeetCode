let productExceptSelf = (nums) => {
  let prevProduct = 1;
  let length = nums.length;
  let tempArr1 = new Array(length).fill(1);
  let tempArr2 = new Array(length).fill(1);
  let result = [];
  for (let i = 1; i < nums.length; i++) {
    prevProduct *= nums[i - 1];
    tempArr1[i] = prevProduct;
  }

  prevProduct = 1;
  for (let i = length - 2; i >= 0; i--) {
    prevProduct *= nums[i + 1];
    tempArr2[i] = prevProduct;
  }

  for (let i = 0; i < length; i++) {
    result.push(tempArr1[i] * tempArr2[i]);
  }
  return result;
};

let productExceptSelfEnhanced = (nums) => {
  let length = nums.length;
  let result = new Array(length);
  let leftProduct = 1;
  for (let i = 0; i < length; i++) {
    result[i] = leftProduct;
    leftProduct *= nums[i];
  }

  let rightProduct = 1;
  for (let i = length - 1; i >= 0; i--) {
    result[i] *= rightProduct;
    rightProduct *= nums[i];

    
  }
  return result;
};
let arr = [1, 2, 4, 6];
console.log(productExceptSelfEnhanced(arr));
