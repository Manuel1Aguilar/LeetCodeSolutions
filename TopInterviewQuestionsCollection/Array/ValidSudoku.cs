namespace LeetCodeSolutions.TopInterviewQuestionsCollection.Array
{
    public static class ValidSudoku
    {
        private static bool IsValidSudoku(char[][] board)
        {
            HashSet<char>[] columns = new HashSet<char>[9];
            HashSet<char>[] squares = new HashSet<char>[9];

            for(int i = 0; i < 9; i++){
                columns[i] = new();
                squares[i] = new();
            }

            for (int i = 0; i < board.Length; i++)
            {
                HashSet<char> row = new();
                for (int j = 0; j < board[i].Length; j++)
                {
                    if (board[i][j] != '.')
                    {
                        char cell = board[i][j];
                        int square = GetSquare(i, j);
                        if (!row.Add(cell) || !columns[j].Add(cell) || !squares[square].Add(cell))
                        {
                            return false;
                        }
                    }
                }
            }
            return true;
        }

        private static int GetSquare(int row, int column)
        {
            return row / 3 * 3 + column / 3;
        }

        public static void CallSolution()
        {
            char[][] input;
            bool res;

            Console.WriteLine("ValidSudoku tests");

            input = [['5','3','.','.','7','.','.','.','.']
                    ,['6','.','.','1','9','5','.','.','.']
                    ,['.','9','8','.','.','.','.','6','.']
                    ,['8','.','.','.','6','.','.','.','3']
                    ,['4','.','.','8','.','3','.','.','1']
                    ,['7','.','.','.','2','.','.','.','6']
                    ,['.','6','.','.','.','.','2','8','.']
                    ,['.','.','.','4','1','9','.','.','5']
                    ,['.','.','.','.','8','.','.','7','9']];
            res = IsValidSudoku(input);
            Console.WriteLine("Input:");
            foreach (char[] row in input)
            {
                Console.WriteLine(String.Join(", ", row));
            }
            Console.WriteLine($"Res: {res}");


            input = [['5','3','.','.','7','.','.','.','.']
                    ,['6','.','.','1','9','5','.','.','.']
                    ,['.','9','8','.','.','.','.','6','.']
                    ,['5','.','.','.','6','.','.','.','3']
                    ,['4','.','.','8','.','3','.','.','1']
                    ,['7','.','.','.','2','.','.','.','6']
                    ,['.','6','.','.','.','.','2','8','.']
                    ,['.','.','.','4','1','9','.','.','5']
                    ,['.','.','.','.','8','.','.','7','9']];
            res = IsValidSudoku(input);
            Console.WriteLine("Input:");
            foreach (char[] row in input)
            {
                Console.WriteLine(String.Join(", ", row));
            }
            Console.WriteLine($"Res: {res}");

            input = [['5','3','.','.','7','.','.','.','.']
                    ,['6','.','5','1','9','5','.','.','.']
                    ,['.','9','8','.','.','.','.','6','.']
                    ,['8','.','.','.','6','.','.','.','3']
                    ,['4','.','.','8','.','3','.','.','1']
                    ,['7','.','.','.','2','.','.','.','6']
                    ,['.','6','.','.','.','.','2','8','.']
                    ,['.','.','.','4','1','9','.','.','5']
                    ,['.','.','.','.','8','.','.','7','9']];
            res = IsValidSudoku(input);
            Console.WriteLine("Input:");
            foreach (char[] row in input)
            {
                Console.WriteLine(String.Join(", ", row));
            }
            Console.WriteLine($"Res: {res}");

            input = [['5','3','.','5','7','.','.','.','.']
                    ,['6','.','.','1','9','5','.','.','.']
                    ,['.','9','8','.','.','.','.','6','.']
                    ,['8','.','.','.','6','.','.','.','3']
                    ,['4','.','.','8','.','3','.','.','1']
                    ,['7','.','.','.','2','.','.','.','6']
                    ,['.','6','.','.','.','.','2','8','.']
                    ,['.','.','.','4','1','9','.','.','5']
                    ,['.','.','.','.','8','.','.','7','9']];
            res = IsValidSudoku(input);
            Console.WriteLine("Input:");
            foreach (char[] row in input)
            {
                Console.WriteLine(String.Join(", ", row));
            }
            Console.WriteLine($"Res: {res}");
        }
    }
}