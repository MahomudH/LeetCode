using LeetCode.Easy;

int[] nums = new int[] { 0, 1, 0, 2, 3 };

MoveZeroes.PrintAfterMoveZeroes(nums);

Console.Write("[");
foreach (int item in nums)
{
    Console.Write(item + ", ");
}
Console.Write("\b\b]");