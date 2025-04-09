namespace LeetCodeSolutions;

public class MinimumNumberOfOperationsToMakeArrayDistinct {

    public static int Solve(int[] input) {
        int ops = 0;
        while (HasDuplicates(input)) {
            ops++;
            if (input.Length < 3) {
                input = [];
            } else {
                int[] aux = new int[input.Length - 3];
                Array.Copy(input, 3, aux, 0, input.Length - 3);
                input = aux;
            }
        }
        return ops;
    }

    private static bool HasDuplicates(int[] input) {
        HashSet<int> elements = new();
        Console.WriteLine($"Array to check: {string.Join(',', input)}");
        for (int i = 0; i < input.Length; i++) {
            if(!elements.Add(input[i])) {
                return true;
            }
        }
        return false;
    }

    public static void CallSolution() {
        int[] input;

        Console.WriteLine("Minimum number of ops to make array distinct solution:");

        input = [1, 2, 3, 4, 2, 3, 3, 5, 7];
        Console.WriteLine($"Input: {string.Join(',', input)}; Output: {Solve(input)}");

        input = [6, 7, 8, 9, 6];
        Console.WriteLine($"Input: {string.Join(',', input)}; Output: {Solve(input)}");

        input = [1, 2, 3, 3];
        Console.WriteLine($"Input: {string.Join(',', input)}; Output: {Solve(input)}");

        input = [4, 5, 6, 4, 4];
        Console.WriteLine($"Input: {string.Join(',', input)}; Output: {Solve(input)}");
        
        input = [6, 7, 8, 9];
        Console.WriteLine($"Input: {string.Join(',', input)}; Output: {Solve(input)}");
    }

}
