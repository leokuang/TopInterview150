/*
238. Product of Array Except Self

Given an integer array nums, return an array answer such that answer[i] is equal to the product of all the elements of nums except nums[i].

The product of any prefix or suffix of nums is guaranteed to fit in a 32-bit integer.

You must write an algorithm that runs in O(n) time and without using the division operation.

 

Example 1:

Input: nums = [1,2,3,4]
Output: [24,12,8,6]
Example 2:

Input: nums = [-1,1,0,-3,3]
Output: [0,0,9,0,0]
 

Constraints:

2 <= nums.length <= 105
-30 <= nums[i] <= 30
The product of any prefix or suffix of nums is guaranteed to fit in a 32-bit integer.
 

Follow up: Can you solve the problem in O(1) extra space complexity? (The output array does not count as extra space for space complexity analysis.)

 */
using System;
namespace Questions.ArrayAndString
{
	public class Q238
	{
        public int[] ProductExceptSelf(int[] nums)
        {

            var length = nums.Length;

            var L = new int[length];
            var R = new int[length];
            var answer = new int[length];

            L[0] = 1;
            for(var i = 1; i < length; i++)
            {
                L[i] = nums[i - 1] * L[i - 1]; 
            }

            R[length - 1] = 1;
            for(var i = length - 2; i >= 0; i--)
            {
                R[i] = nums[i + 1] * R[i + 1];
            }

            for(var i = 0; i < length; i++)
            {
                answer[i] = L[i] * R[i];
            }


            return answer;
        }
    }
}

