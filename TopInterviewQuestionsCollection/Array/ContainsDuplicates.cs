namespace LeetCodeSolutions.TopInterviewQuestionsCollection.Array
{
    public static class ContainsDuplicates
    {
        private static bool HasDuplicates(int[] nums)
        {
            HashSet<int> uniqueNums = new();
            for(int i = 0; i < nums.Length; i++)
            {
                if(!uniqueNums.Add(nums[i])){
                    return true;
                }
            }
            return false;
        }

        public static void CallSolution()
        {
            int[] input;
            bool res;
            Console.WriteLine("Has duplicates tests");
            input = [1,2,3,4,5,6,6];
            res = HasDuplicates(input);
            Console.WriteLine($"Input: {String.Join(',', input)} Res: {res}");
            
            input = [1,2,3,4,5,6,1];
            res = HasDuplicates(input);
            Console.WriteLine($"Input: {String.Join(',', input)} Res: {res}");

            input = [1,2,3,4];
            res = HasDuplicates(input);
            Console.WriteLine($"Input: {String.Join(',', input)} Res: {res}");
        }
    }
}