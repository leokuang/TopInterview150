﻿using Questions.ArrayAndString;

namespace Questions;

class Program
{
    static void Main(string[] args)
    {
        ////Q088
        //var question = new Q088();
        //question.Merge(new int[] { 1, 2, 3, 0, 0, 0 }, 2, new int[] { 2, 5, 6 }, 3);

        ////Q045
        //var question = new Q045();
        //question.Jump(new int[] { 2, 3, 1, 1, 4 });

        ////Q274
        //var question = new Q274();
        //question.HIndex(new int[] { 3, 0, 6, 1, 5 });

        ////Q238
        //var question = new Q238();
        //question.ProductExceptSelf(new int[] { 1, 2, 3, 4 });

        //Q134
        var question = new Q134();
        question.CanCompleteCircuit(new int[] { 1, 2, 3, 4, 5 }, new int[] { 3, 4, 5, 1, 2 });

    }
}

