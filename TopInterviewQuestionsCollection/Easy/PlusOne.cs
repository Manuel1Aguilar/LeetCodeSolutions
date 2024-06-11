namespace LeetCodeSolutions.TopInterviewQuestionsCollection.Easy 
{
    public static class PlusOne
    {
        public static int[] AddOne(int[] nums)
        {
            for (int i = nums.Length - 1; i >= 0; i--)
            {
                if(nums[i] == 9) {
                    nums[i] = 0;
                } else {
                    nums[i] += 1;
                    return nums;
                }
            }
            int[] res = new int[nums.Length + 1];
            Array.Copy(nums, 0, res, 1, nums.Length);
            res[0] = 1;
            return res;
        }

        public static void CallSolution()
        {
            int[] input;
            int[] res;

            Console.WriteLine("Plus one tests");

            input = [1, 9, 9, 9];
            Console.Write($"Input: {String.Join(", ", input)}; ");
            res = AddOne(input);
            Console.WriteLine($"Res: {String.Join(", ", res)}");

            
            input = [1, 2, 3, 4];
            Console.Write($"Input: {String.Join(", ", input)}; ");
            res = AddOne(input);
            Console.WriteLine($"Res: {String.Join(", ", res)}");

            
            input = [1, 0, 0, 0];
            Console.Write($"Input: {String.Join(", ", input)}; ");
            res = AddOne(input);
            Console.WriteLine($"Res: {String.Join(", ", res)}");
            
            input = [9, 9, 9, 9];
            Console.Write($"Input: {String.Join(", ", input)}; ");
            res = AddOne(input);
            Console.WriteLine($"Res: {String.Join(", ", res)}");
        }
    }
}