namespace LeetCodeSolutions;

public static class TotalCharsInStringAfterTransforms {

    const long MOD = 1_000_000_007;
    public static int LengthAfterTransformations(string s, int t) {
        if (t == 0) {
            return s.Length;
        }
        long[][] transformation = new long[27][];
        for (int i = 0; i < transformation.Length; i++) {
            transformation[i] = new long[27];    
        }

        for (int i = 0; i < 25; i++) {
            transformation[i+1][i] = 1; // Transformation matrix says that after one transformation each starting letter (column) will yield one of the next letter (row)
                                        // So in transformation column A (t[x][0]) has a 1 on row B (t[1][x]) => t[1][0] = 1. This holds true a..y
        }
        transformation[0][25] += 1;// Column z has a 1 on row A
        transformation[1][25] += 1;//  and row B because the Zs transform to ab
        // and the last row is the length row, z is the only letter to increase the total length by one after transformation because it becomes 2 letters
        transformation[26][25] = 1;
         // We give a value of 1 to the last cell to carry over the length after each M multiplication (the last row tracks length changes, the last 
         // column is needed so the multiplication doesnt delete delta len)
        transformation[26][26] = 1;

        // Multiplying the transformation matrix by itself means returns the matrix of changes after t*2 transformations, so if we multiply the matrix by itself once
        // we get a matrix of the transformations applied twice (column A which means start with an A will have a 1 in C because A becomes C after transforming twice)
        //
        // Multiplying by itself means exponentiationg. Can't afford to calculate all matrices one by one so we take advantage of Matrix property M^t * M^t = M^2t
        var finalTransform = FastMatrixExp(transformation, t);

        // Get a long array of the original strings char appearances count
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
            totalLen = (totalLen + v0[i] * finalTransform[26][i] % MOD) % MOD;
        }
        return ((int)totalLen);
    }

    private static long[][] MultiplyMatrix(long[][] A, long[][] B) {
        if (A[0].Length != B.Length) {
            throw new Exception("Matrix A has to have equal number of columns as B has rows");
        }
        int aRows = A.Length, aColsbRows = A[0].Length, bCols = B[0].Length;
        long[][] C = new long[aRows][];
        for (int i = 0; i < aRows; i++) {
            C[i] = new long[bCols];
        }
        for (int i = 0; i < aRows; i++) {
            for (int k = 0; k < aColsbRows; k++) {
                if (A[i][k] == 0) {
                    continue;
                }
                for (int j = 0; j < bCols; j++) {
                    C[i][j] = (C[i][j] + A[i][k] * B[k][j] % MOD) % MOD;
                }
            }
        }
        return C;
    }
    private static long[][] IdentityMatrix(long[][] M) {
        if (M.Length != M[0].Length) {
            throw new Exception("Identity Matrix only works for square matrices");
        }

        long[][] identity = new long[M.Length][];
        for (int i = 0; i < M.Length; i++) {
            identity[i] = new long[M[0].Length];
            identity[i][i] = 1;
        }
        // The identity matrix serves as a "1" on multiplication. It doesnt change the second matix.
         return identity;
    }
    private static long[][] FastMatrixExp(long[][] M, int exponent) {
        var result = IdentityMatrix(M);
        var power = CloneMatrix(M);
        while (exponent > 0) {
            if (exponent % 2 > 0) {
                result = MultiplyMatrix(result, power);
            }
            power = MultiplyMatrix(power, power);

            exponent = exponent / 2;
        }
        return result;
    }

    private static long[][] CloneMatrix(long[][] M) {
        var clone  = new long[M.Length][];
        for (int i = 0; i < M.Length; i++) {
            clone[i] = (long[])M[i].Clone();
        }
        return clone;
    }

    public static void CallSolution() {
        string input;
        int inputT;

        Console.WriteLine("3335 Total Chars in string after transformations solution:");

        input = "abcyy";
        inputT = 2;
        Console.WriteLine($"Input: {input}, T: {inputT}; res: {LengthAfterTransformations(input, inputT)}");

        input = "azbk";
        inputT = 1;
        Console.WriteLine($"Input: {input}, T: {inputT}; res: {LengthAfterTransformations(input, inputT)}");

    }
}
