namespace LeetCodeSolutions.TopInterviewQuestionsCollection.Array
{
    public static class SingleNumber {
        private static int FindSingleNumber(int[] nums)
        {
            int res = 0;
            for(int i = 0; i < nums.Length; i++)
            {
                res ^= nums[i];
            }
            return res;
        }

        public static void CallSolution() 
        {
            int[] input;
            int res;

            Console.WriteLine("Find the single number in an array of ints");

            input = [1,1,2,2,3,4,4];
            res = FindSingleNumber(input);
            Console.WriteLine($"Input: {String.Join(", ", input)} ; Res: {res}");

            
            input = [1,1,2,2,3,3,4];
            res = FindSingleNumber(input);
            Console.WriteLine($"Input: {String.Join(", ", input)} ; Res: {res}");

            
            input = [1,0,1];
            res = FindSingleNumber(input);
            Console.WriteLine($"Input: {String.Join(", ", input)} ; Res: {res}");
        }
    }
}