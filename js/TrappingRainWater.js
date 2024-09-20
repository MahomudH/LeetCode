var trap = function (height) {
  let leftMax = [0];
  let rightMax = new Array(height.length).fill(0);
  let minLR = new Array(height.length).fill(0);
  let leftMaxTemp = 0;
  let rightMaxTemp = 0;
  let result = 0;
  for (let i = 1; i < height.length; i++) {
    leftMaxTemp = Math.max(height[i - 1], leftMaxTemp);
    leftMax.push(leftMaxTemp);
  }

  for (let i = height.length - 2; i >= 0; i--) {
    rightMaxTemp = Math.max(height[i + 1], rightMaxTemp);
    rightMax[i] = rightMaxTemp;
  }

  for (let i = 0; i < minLR.length; i++) {
    minLR[i] = Math.min(leftMax[i], rightMax[i]);
  }

  for (let i = 0; i < height.length; i++) {
    let resultTemp = minLR[i] - height[i];
    result += resultTemp > 0 ? resultTemp : 0;
  }

  return result;
};

var trapEnhanced = function (height) {
  if (!height || height.length === 0) {
    return 0;
  }

  let result = 0;
  let leftP = 0;
  let rightP = height.length - 1;
  let maxLeft = 0;
  let maxRight = 0;

  while (leftP <= rightP) {
    if (height[leftP] < height[rightP]) {
      maxLeft = Math.max(maxLeft, height[leftP]);
      result += maxLeft - height[leftP] ;
      leftP++;
    } else {
      maxRight = Math.max(maxRight, height[rightP]);
      result += maxRight - height[rightP];
      rightP--;
    }
  }
  return result;
};
height = [0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1];
console.log(trap(height));
console.log(trapEnhanced(height));
