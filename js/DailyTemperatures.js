dailyTemperatures = function (temperatures) {
  let length = temperatures.length;
  let res = new Array(length).fill(0);
  let stack = [];
  for (let i = 0; i < length; i++) {
    const t = temperatures[i];
    while (stack.length > 0 && t > stack[stack.length - 1][0]) {
      const [stackT, stackInd] = stack.pop();
      res[stackInd] = i - stackInd;
    }
    stack.push([t, i]);
  }
  return res;
};
