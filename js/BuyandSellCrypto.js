maxProfit = (prices) => {
  let length = prices.length;
  let l = 0;
  let r = 1;
  let profit = 0;
  while (r < length) {
    if (prices[r] > prices[l]) {
      let tempProfit = prices[r] - prices[l];
      profit = tempProfit > profit ? tempProfit : profit;
    } else {
      l = r;
    }
    r++;
  }
  return profit;
};

prices = [10,8,7,5,2];
console.log(maxProfit(prices));
