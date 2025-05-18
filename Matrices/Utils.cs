using System.Numerics;

namespace Matrices;

public static class Utils {

    public static T[][] MultiplyMatrix<T>(T[][] A, T[][] B) where T : INumber<T>
    {
        int aRows = A.Length, bCols = B[0].Length, bRows = B.Length, aCols = A[0].Length;
        if (aCols != bRows) {
            throw new Exception("The number of columns in A should equal the number of rows in B");
        }
        T[][] C = new T[aRows][];
        for (int i = 0; i < aRows; i++) {
            C[i] = new T[bCols];
        }

        for (int i = 0; i < aRows; i++) {
            for (int k = 0; k < bRows; k++) { // bRows == aCols
                if (A[i][k] == T.Zero) 
                    continue;
                for (int j = 0; j < bCols; j++) {
                    C[i][j] += A[i][k] * B[k][j]; 
                }
            }
        }
        return C;
    }

    public static T[][] Mult<T>(T[][] A, T[][] B) where T : INumber<T> 
    {
        int aRows = A.Length, aCols = A[0].Length, bRows = B.Length, bCols = B[0].Length;
        if (aCols != bRows) {
            throw new Exception("A columns should be the same qty as B rows");
        }

        T[][] C = new T [aRows][];
        for (int i = 0; i < aRows; i++) {
            C[i] = new T[bCols];
        }

        for (int i = 0; i < aRows; i++) {
            for (int j = 0; j < bCols; j++) {
                for (int k = 0; k < bRows; k++) {
                    C[i][j] += A[i][k] * B[k][j];
                }
            }
        }

        return C;
    }

    public static T[][] IdentityMatrix<T>(T[][] matrix) where T : INumber<T> 
    {
        T[][] res = new T[matrix.Length][];
        for (int i = 0; i < res.Length; i++) {
            res[i] = new T[matrix[i].Length];
            res[i][i] = T.One;
        }
        return res;
    }

    public static T[][] FastExponentiation<T>(T[][] matrix, int exponent) where T : INumber<T>
    {
        T[][] power = (T[][])matrix.Clone();
        T[][] result = IdentityMatrix(matrix);

        while (exponent > 0) {
            if (exponent % 2 > 0) {
                result = Mult(result, power);
            }
            power = Mult(power, power);

            exponent = exponent / 2;
        }
        return result;
    }

    public static void PrintMatrix<T>(int[][] matrix) where T : INumber<T> {
        for (int i = 0; i < matrix.Length; i++) {
            for (int j = 0; j < matrix[i].Length; j++) {
                Console.Write(matrix[i][j].ToString().PadLeft(5));
            }
            Console.WriteLine();
        }
    }
}   
