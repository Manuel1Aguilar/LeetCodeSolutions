namespace LeetCodeSolutions.TopInterviewQuestionsCollection.Array
{
    public static class TwoSumSolution
    {
        private static int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> validTable = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                int searchTarget = target - nums[i];
                if(validTable.ContainsKey(searchTarget))
                {
                    return [validTable[searchTarget], i];
                }
                validTable.Add(nums[i], i);
            }
            return [];
        }

        public static void CallSolution()
        {
            int[] input;
            int target;
            int[] res;

            Console.WriteLine("TwoSum Tests");

            input = [2, 7, 11, 13, 4];
            target = 9;
            res = TwoSum(input, target);
            Console.WriteLine($"Input: {String.Join(", ", input)}; Target: {target}; Res: {String.Join(", ", res)}");


            input = [3, 3];
            target = 6;
            res = TwoSum(input, target);
            Console.WriteLine($"Input: {String.Join(", ", input)}; Target: {target}; Res: {String.Join(", ", res)}");


            input = [3, 2, 4];
            target = 6;
            res = TwoSum(input, target);
            Console.WriteLine($"Input: {String.Join(", ", input)}; Target: {target}; Res: {String.Join(", ", res)}");

        }
    }
}