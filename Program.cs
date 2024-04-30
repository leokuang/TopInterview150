using Questions.ArrayAndString;

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
        // var question = new Q134();
        // question.CanCompleteCircuit(new int[] { 1, 2, 3, 4, 5 }, new int[] { 3, 4, 5, 1, 2 });

        //Q704
        // var question = new Q704();
        // var result = question.Search(new int[] { -1, 0, 3, 5, 9, 12 }, 9);

        // Console.WriteLine($"Result is: {result}");

        //Q027
        var question = new Q027();
        var result = question.RemoveElement1(new int[] { 0, 1, 2, 2, 3, 0, 4, 2 }, 2);

        Console.WriteLine($"Result is: {result}");
    }
}

