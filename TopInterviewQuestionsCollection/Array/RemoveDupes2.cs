namespace LeetCodeSolutions.TopInterviewQuestionsCollection.Array
{
    public static class RemoveDupesRetry
    {
        public static int RemoveDuplicatesFromSortedArray(int[] nums)
        {
            int uniqueElementPointer = 1;
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] != nums[i - 1])
                {
                    nums[uniqueElementPointer] = nums[i];
                    uniqueElementPointer++;
                }
            }
            return uniqueElementPointer;
        }

        public static void CallSolution()
        {
            int[] input = [1, 1, 2];
            Console.WriteLine($"Calling Remove dupes with input {String.Join(',', input)}");
            int res = RemoveDupesRetry.RemoveDuplicatesFromSortedArray(input);
            Console.WriteLine($"Result is {res} and the array is now {String.Join(',', input)}");

            input = [0, 0, 0, 1, 1, 2, 2, 3, 4, 5];
            Console.WriteLine($"Calling Remove dupes with input {String.Join(',', input)}");
            res = RemoveDupesRetry.RemoveDuplicatesFromSortedArray(input);
            Console.WriteLine($"Result is {res} and the array is now {String.Join(',', input)}");
        }
    }
}