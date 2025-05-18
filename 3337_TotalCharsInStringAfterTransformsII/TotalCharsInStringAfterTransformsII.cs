namespace LeetCodeSolutions;

public static class TotalCharsInStringAfterTransformsII {
    private const long MOD = 1_000_000_007;
    private static int LengthAfterTransformations(string s, int t, IList<int> nums) {
        // Define transformation matrix
        
        // Exponentiate matrix to t

        // Return amount of chars per char in s after t transformations from matrix
        return 0;
    }

    private static int[][] MultiplyMatrix(int[][] A, int[][] B) {
        if (A[0].Length != B.Length) {
            throw new Exception("A cols must be equal to B rows");
        }

        int n = A.Length, m = B.Length, z = B[0].Length;
        int[][] C = new int[m][];
        for (int i = 0; i < m; i++) {
            C[i] = new int[z];
            for (int k = 0; k < m; k++) {
                if (A[i][k] == 0) continue;
                for (int j = 0; j < z; j++) {
                    C[i][j] += A[i][k] * B[k][j];
                }
            }
        }
        return C;
    }

    private static int[][] FastMatrixExponentiation(int[][] M, int exponent) {
        var result = IdentityMatrix(M);
        var power = DeepClone(M);

        while (exponent > 0) {
            if (exponent % 2 > 0) {
                result = MultiplyMatrix(result, power);
            }

            power = MultiplyMatrix(power, power);
            exponent = exponent / 2;
        }

        return result;
    }
    
    private static int[][] DeepClone(int[][] M) {
        int n = M.Length;
        var res = new int[n][];
        for (int i = 0; i < n; i++) {
            res[i] = (int[])M[i].Clone();
        }
        return res;
    }

    private static int[][] IdentityMatrix(int[][] M) {
        if (M.Length != M[0].Length) {
            throw new Exception("This only works for square matrices");
        }
        int n = M.Length;
        int[][] I = new int[n][];
        for (int i = 0; i < n; i++) {
            I[i] = new int[n];
            I[i][i] = 1;
        }
        return I;
    }

}
