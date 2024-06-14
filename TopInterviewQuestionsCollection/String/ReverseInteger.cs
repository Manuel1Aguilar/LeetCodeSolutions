using System.Runtime.CompilerServices;

namespace LeetCodeSolutions.TopInterviewQuestionsCollection.Strings
{
    public static class ReverseInteger
    {
        private static int Reverse(int x)
        {
            if (x == int.MinValue) return 0;

            int sign = x < 0 ? -1 : 1;

            x = Math.Abs(x);
            int res = 0;
            while (x > 0)
            {
                int pop = x % 10;
                x /= 10;

                if (res > (int.MaxValue - pop) / 10)
                {
                    return 0;
                }

                res = res * 10 + pop;
            }
            return res * sign;
        }

        public static void CallSolution()
        {
            int input;
            int res;
            Console.WriteLine("Reverse String Tests");

            input = -123;
            Console.Write($"Input: {input}; ");
            res = Reverse(input);
            Console.WriteLine($"Res: {res}");

            input = 110;
            Console.Write($"Input: {input}; ");
            res = Reverse(input);
            Console.WriteLine($"Res: {res}");

            input = -2147483648;
            Console.Write($"Input: {input}; ");
            res = Reverse(input);
            Console.WriteLine($"Res: {res}");
        }
    }
}