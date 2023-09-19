using LeetCode.Easy;

int[] nums = new int[] { 4, 3, 2, 7, 8, 2, 3, 1 };

int[] res = AllNumbersDisappearedInArray.FindAllNumbersDisappearInArray(nums);

foreach (int i in res)
    Console.WriteLine(i);