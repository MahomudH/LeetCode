var nums = new  int[]{3, 2, 4};
var target = 6;

//var result = TwoSum.TwoSum.GetTwoSum(nums, target);
var result = TwoSum.TwoSum.GetTwoSumUsingHashMap(nums, target);

Console.Write("[");
foreach (var output in result)
{
    Console.Write(output + ",");   
}
Console.Write("\b]");