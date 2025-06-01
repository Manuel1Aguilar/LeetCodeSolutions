namespace LeetCodeSolutions;

public static class TotalCharsInStringAfterTransformsII {
    private const long MOD = 1_000_000_007;
    private static int LengthAfterTransformations(string s, int t, IList<int> nums) {
        // Define transformation matrix
        int[][] transformation = new int[27][];
        for (int i = 0; i < transformation.Length; i++) {
            transformation[i] = new int[27];
        }
        for (int i = 0; i < 26; i++) {
            int ts = nums[i];
            for (int j = 1; j <= ts; j++) {
                transformation[(i + j) % 26][i] = 1;
            }
            
            transformation[26][i] = ts;
        }
         transformation[26][26] = 0;
        // Exponentiate matrix to transformations
        var transformed = FastMatrixExponentiation(transformation, t);
        // Return amount of chars per char in s after t transformations from matrix
        long[] v0 = new long[27];
        foreach(char c in s) {
            v0[c - 'a']++;
        }
        v0[26] = s.Length;

        // Multiply it by the last row (len) of the transformation matrix after t transformations
        // (The len row was used to hold how many extra characters each original character yielded after t transforms so multiplying by the qty of each
        // character I have originally means I get how many characters each char means at the end)
        long totalLen = 0;
        for (int i = 0; i < 27; i++) {
            totalLen = (totalLen + v0[i] * transformed[26][i] % MOD) % MOD;
        }
        return ((int)totalLen);
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
                    C[i][j] = (int)((C[i][j] + (long)A[i][k] * B[k][j] % MOD) % MOD);
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


    public static void CallSolution() {
        string sInput;
        int tInput;
        int[] nInput;

        Console.WriteLine("3337. Total Characters in String After Transformations II Solution:");

        tInput = 2;
        sInput = "abcyy";
        nInput = [1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,2];
        Console.WriteLine($"Inputs: s {sInput}, t {tInput}, nums {string.Join(',', nInput)}; Output: { LengthAfterTransformations(sInput, tInput, nInput)}");

        tInput = 1;
        sInput = "azbk";
        nInput = [2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2];
        Console.WriteLine($"Inputs: s {sInput}, t {tInput}, nums {string.Join(',', nInput)}; Output: { LengthAfterTransformations(sInput, tInput, nInput)}");
    }

}
