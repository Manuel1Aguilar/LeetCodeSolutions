namespace LeetCodeSolutions.TopInterviewQuestionsCollection.Array
{
    public static class MoveZeroes
    {
        private static void MoveZeroesToEnd(int[] nums)
        {
            int nonZeroNumbersIndex = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                {
                    nums[nonZeroNumbersIndex] = nums[i];
                    nonZeroNumbersIndex++;
                }
            }
            for(int i = nonZeroNumbersIndex; i < nums.Length; i++){
                nums[i] = 0;
            }
        }

        public static void CallSolution()
        {
            int[] input;

            Console.WriteLine("Move zeroes to end of array");

            input = [1, 0, 2, 3, 0, 0];
            Console.Write($"Input: {String.Join(", ", input)}; ");
            MoveZeroesToEnd(input);
            Console.WriteLine($"Res: {String.Join(", ", input)}");


            input = [1, 0, 2];
            Console.Write($"Input: {String.Join(", ", input)}; ");
            MoveZeroesToEnd(input);
            Console.WriteLine($"Res: {String.Join(", ", input)}");


            input = [1, 2, 3, 4, 5, 0];
            Console.Write($"Input: {String.Join(", ", input)}; ");
            MoveZeroesToEnd(input);
            Console.WriteLine($"Res: {String.Join(", ", input)}");
        }
    }
}