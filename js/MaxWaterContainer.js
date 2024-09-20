let maxArea = (heights) => {
  let leftP = 0;
  let rightP = heights.length - 1;
  let max = 0;
  while (leftP < rightP) {
    let tempMin = Math.min(heights[leftP], heights[rightP]);
    let temp = (rightP - leftP) * tempMin;
    max = Math.max(max, temp);
    heights[leftP] > heights[rightP] ? rightP-- : leftP++;
  }

  return max;
};

let height = [1, 7, 2, 5, 4, 7, 3, 6];
console.log(maxArea(height));
