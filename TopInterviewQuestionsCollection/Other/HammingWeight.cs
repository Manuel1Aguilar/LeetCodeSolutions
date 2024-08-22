namespace LeetCodeSolutions.TopInterviewQuestionsCollection.Other;

public static class HammingWeight
{
    private static int GetIntsHammingWeight(int n)
    {
        int count = 0;
        while (n > 0)
        {
            if (n % 2 == 1)
            {
                count++;
            }
            n /= 2;
        }
        return count;
    }
    public static void CallSolution()
    {
        int input;
        int res;

        Console.WriteLine("Hamming weight solution");

        input = 1;
        res = GetIntsHammingWeight(input);
        Console.WriteLine($"Input: {input}; Res: {res}");


        input = 128;
        res = GetIntsHammingWeight(input);
        Console.WriteLine($"Input: {input}; Res: {res}");

        input = 3;
        res = GetIntsHammingWeight(input);
        Console.WriteLine($"Input: {input}; Res: {res}");

        input = int.MaxValue;
        res = GetIntsHammingWeight(input);
        Console.WriteLine($"Input: {input}; Res: {res}");
    }

}