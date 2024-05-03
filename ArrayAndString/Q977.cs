/**
977. Squares of a Sorted Array

Given an integer array nums sorted in non-decreasing order, return an array of the squares of each number sorted in non-decreasing order.

 

Example 1:

Input: nums = [-4,-1,0,3,10]
Output: [0,1,9,16,100]
Explanation: After squaring, the array becomes [16,1,0,9,100].
After sorting, it becomes [0,1,9,16,100].
Example 2:

Input: nums = [-7,-3,2,3,11]
Output: [4,9,9,49,121]
 

Constraints:

1 <= nums.length <= 104
-104 <= nums[i] <= 104
nums is sorted in non-decreasing order.
 

Follow up: Squaring each element and sorting the new array is very trivial, could you find an O(n) solution using a different approach?
*/

public class Q977
{
    public int[] SortedSquares(int[] nums) 
    {
        for(var i = 0; i < nums.Length; i++)
        {
            nums[i] = nums[i] * nums[i];
        }

        return nums.Order().ToArray();
    }

    public int[] SortedSquares1(int[] nums)
    {
        var start = 0;
        var end = nums.Length - 1;
        var result = new int[nums.Length];

        for(var i = nums.Length - 1; i >= 0; i--)
        {
            if(nums[start] * nums[start] > nums[end] * nums[end])
            {
                result[i] = nums[start] * nums[start];
                start++;
            }
            else
            {
                result[i] = nums[end] * nums[end];
                end--;
            }         
        }

        return result;
    }

}