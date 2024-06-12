namespace LeetCodeSolutions.TopInterviewQuestionsCollection.Array
{
    public static class RotateImage
    {
        private static void RotateImageInPlace(int[][] matrix)
        {
            for (int i = matrix.Length - 1; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    (matrix[i][j], matrix[j][i]) = (matrix[j][i], matrix[i][j]);
                }
            }
            for (int i = 0; i < matrix.Length; i++)
            {
                RotateArray(matrix[i]);
            }
        }

        private static void RotateArray(int[] array)
        {
            int start = 0;
            int end = array.Length - 1;
            while (start < end)
            {
                (array[start], array[end]) = (array[end], array[start]);
                start++;
                end--;
            }
        }

        public static void CallSolution()
        {
            int[][] input;

            Console.WriteLine("Rotate Image Tests");

            input = [[1, 2, 3], [4, 5, 6], [7, 8, 9]];
            Console.WriteLine("Input:");
            foreach (int[] row in input)
            {
                Console.WriteLine(String.Join(", ", row));
            }
            RotateImageInPlace(input);
            Console.WriteLine("Res:");
            foreach (int[] row in input)
            {
                Console.WriteLine(String.Join(", ", row));
            }

            input = [[5, 1, 9, 11], [2, 4, 8, 10], [13, 3, 6, 7], [15, 14, 12, 16]];
            Console.WriteLine("Input:");
            foreach (int[] row in input)
            {
                Console.WriteLine(String.Join(", ", row));
            }
            RotateImageInPlace(input);
            Console.WriteLine("Res:");
            foreach (int[] row in input)
            {
                Console.WriteLine(String.Join(", ", row));
            }
        }
    }
}