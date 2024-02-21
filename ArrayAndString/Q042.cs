/*
Given n non-negative integers representing an elevation map where the width of each bar is 1, compute how much water it can trap after raining.

 

Example 1:


Input: height = [0,1,0,2,1,0,1,3,2,1,2,1]
Output: 6
Explanation: The above elevation map (black section) is represented by array [0,1,0,2,1,0,1,3,2,1,2,1]. In this case, 6 units of rain water (blue section) are being trapped.
Example 2:

Input: height = [4,2,0,3,2,5]
Output: 9
 

Constraints:

n == height.length
1 <= n <= 2 * 104
0 <= height[i] <= 105
 */

using System;
namespace Questions.ArrayAndString
{
	public class Q042
	{
        public int Trap(int[] height)
        {
            var size = height.Length;

            if(size <= 2)
            {
                return 0;
            }

            var stack = new Stack<int>();
            stack.Push(0);

            var sum = 0;

            for(var i = 0; i < size; i++)
            {
                var stackTop = stack.Peek();

                if (height[i] < height[stackTop])
                {
                    stack.Push(i);
                }
                else if (height[i] == height[stackTop])
                {
                    stack.Pop();
                    stack.Push(i);
                }
                else
                {
                    var heightAtIdx = height[i];

                    while(stack.Count != 0 && heightAtIdx > height[stackTop])
                    {
                        var mid = stack.Pop();

                        if(stack.Count != 0)
                        {
                            var left = stack.Peek();
                            var h = Math.Min(height[left], height[i]) - height[mid];
                            var w = i - left - 1;

                            var hold = h * w;

                            if(hold > 0)
                            {
                                sum += hold;
                            }

                            stackTop = stack.Peek();
                                                    }
                    }

                    stack.Push(i);
                }

            }

            return sum;
        }
    }
}

