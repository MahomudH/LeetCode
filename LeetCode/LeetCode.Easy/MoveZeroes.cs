namespace LeetCode.Easy;

public class MoveZeroes
{
    public static void PrintAfterMoveZeroes(int[] nums)
    {
        int length = nums.Length;
        if(length == 0)
            Console.WriteLine("The array is empty"); 

        if (length == 1)
            Console.WriteLine($"[{nums[0]}]");

        int j = 1;

        for (int i = 0; j < length; j++)
        {
            if (nums[i] != 0)
            {
                i++;
            }
            else
            {
                if (nums[j] != 0)
                {
                    nums[i] = nums[j];
                    nums[j] = 0;
                    i++;
                }
            }
        }

        Console.Write("[");
        foreach (int item in nums)
        {
            Console.Write(item +", ");
        }
        Console.Write("\b\b]");
    }
}

