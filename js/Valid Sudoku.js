let isValidSudoku = function (board) {
  let rowMap = new Map();
  let colMap = new Map();
  let squareMap = new Map();

  for (let i = 0; i < 9; i++) {
    for (let j = 0; j < 9; j++) {
      if (board[i][j] == ".") continue;

      let num = board[i][j];

      if (rowMap.get(i)?.includes(num)) return false;
      
      if (colMap.get(j)?.includes(num)) return false;

      let squareKey = `${Math.floor(i / 3)}-${Math.floor(j / 3)}`;
      if (squareMap.get(squareKey)?.includes(num)) return false;

      rowMap.set(i, [...(rowMap.get(i) || []), num]);
      colMap.set(j, [...(colMap.get(j) || []), num]);
      squareMap.set(squareKey, [...(squareMap.get(squareKey) || []), num]);
    }
  }

  return true;
};
let board = [
  ["5", "3", ".", ".", "7", ".", ".", ".", "."],
  ["6", ".", ".", "1", "9", "5", ".", ".", "."],
  [".", "9", "8", ".", ".", ".", ".", "6", "."],
  ["8", ".", ".", ".", "6", ".", ".", ".", "3"],
  ["4", ".", ".", "8", ".", "3", ".", ".", "1"],
  ["7", ".", ".", ".", "2", ".", ".", ".", "6"],
  [".", "6", ".", ".", ".", ".", "2", "8", "."],
  [".", ".", ".", "4", "1", "9", ".", ".", "5"],
  [".", ".", ".", ".", "8", ".", ".", "7", "9"],
];

console.log(isValidSudoku(board));
