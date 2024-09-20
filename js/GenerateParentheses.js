var generateParenthesis = function (n) {
  const res = [];
  backTrack(n, 0, 0, "", res);
  return res;
};

var backTrack =function (n, openN, closeN, current, res)  {
  if (openN === closeN && openN === n) {
    res.push(current);
    return;
  }

  if (openN < n) backTrack(n, openN + 1, closeN, current+"(", res);

  if (closeN < openN) backTrack(n, openN, closeN + 1, current+")", res);
};

console.log(generateParenthesis(3));
