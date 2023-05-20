using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumTwoII
{
    public class SumTwo
    {
        public static int[] GetSumTwo(int[] nums,int target)
        {
            var left = 0;
            var right = nums.Length-1;
            var sum = 0;

            while (left < right)
            {
                sum = nums[left] + nums[right];

                if (sum > target)
                    right -= 1;
                else if(sum < target) 
                    left += 1;
                else 
                    return new int[]{left+1 , right+1};
            }

            return null;

        }
    }
}
