using System.Text;

namespace LeetCodeSolutions.TopInterviewQuestionsCollection.Strings
{
    public static class StringToInteger
    {
        public static int MyAtoi(string s)
        {
            if(string.IsNullOrWhiteSpace(s))
            {
                return 0;
            }

            string trimmedString = s.Trim();
            int i = 0;
            int sign = 1;

            if (trimmedString[0] == '-' || trimmedString[0] == '+')
            {
                sign = trimmedString[0] == '-' ? -1 : 1;
                i++;
            }

            int res = 0;
            int limit = int.MaxValue / 10;
            int digitLimit = sign == -1 ? Math.Abs(int.MinValue % 10) : int.MaxValue % 10;

            while (i < trimmedString.Length && char.IsDigit(trimmedString[i]))
            {
                int digit = trimmedString[i] - '0';
                if(res > limit  || (res == limit && digit >= digitLimit))
                {
                    return sign == -1 ? int.MinValue : int.MaxValue;
                }
                res = res * 10 + digit;
                i++;
            }
            return res * sign;
        }

        public static void CallSolution()
        {
            string input;
            int res;

            Console.WriteLine($"Max Value: {int.MaxValue}; Min Value: {int.MinValue}");
            Console.WriteLine("String To Integer ATOI Tests");

            // input = "-42";
            // res = MyAtoi(input);
            // Console.WriteLine($"Input: {input}; Result: {res}");

            // input = "10";
            // res = MyAtoi(input);
            // Console.WriteLine($"Input: {input}; Result: {res}");

            // input = "1337c0d3";
            // res = MyAtoi(input);
            // Console.WriteLine($"Input: {input}; Result: {res}");

            // input = "0-1";
            // res = MyAtoi(input);
            // Console.WriteLine($"Input: {input}; Result: {res}");

            // input = "words and 987";
            // res = MyAtoi(input);
            // Console.WriteLine($"Input: {input}; Result: {res}");

            // input = "-91283472332";
            // res = MyAtoi(input);
            // Console.WriteLine($"Input: {input}; Result: {res}");

            // input = "-042";
            // res = MyAtoi(input);
            // Console.WriteLine($"Input: {input}; Result: {res}");

            input = "-21474836482";
            res = MyAtoi(input);
            Console.WriteLine($"Input: {input}; Result: {res}");
        }
    }
}