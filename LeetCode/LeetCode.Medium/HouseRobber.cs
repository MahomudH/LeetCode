﻿namespace LeetCode.Medium
{
    public class HouseRobber
    {
        public static int Rob(int[] nums)
        {
            if (nums == null) return 0;
            if (nums.Length == 1) return nums[0];
            int previouslyRobbedMoney = 0;
            int robbedMoneyBeforePreviousRob = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                int currentRobValue = Math.Max(previouslyRobbedMoney, nums[i] + robbedMoneyBeforePreviousRob);
                robbedMoneyBeforePreviousRob = previouslyRobbedMoney;
                previouslyRobbedMoney = currentRobValue;
            }
            return previouslyRobbedMoney;
        }
    }
}
