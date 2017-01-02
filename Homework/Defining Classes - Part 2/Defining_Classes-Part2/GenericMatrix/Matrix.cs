using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericMatrix
{
    public class Matrix<T> where T : IEnumerable<T>, IConvertible, IComparable<T>
    {
        private T[,] matrix;

        public Matrix(int row, int col)
        {
            this.matrix = new T[row, col];
        }

        public T this[int row, int col]
        {
            get
            {
                indexValidator(row, col);
                return this.matrix[row, col];
            }

            set
            {
                this.matrix[row, col] = value;
            }
        }

        public int GetLength(int dimension)
        {
            return this.matrix.GetLength(dimension);
        }

        public void indexValidator(int row, int col)
        {
            if (row < 0 || row >= matrix.GetLength(0) || col < 0 || col >= matrix.GetLength(1))
            {
                throw new IndexOutOfRangeException("Trying to reach an unexcistig element!");
            }
        }

        public static Matrix<T> operator -(Matrix<T> matrix1, Matrix<T> matrix2)
        {
            if (matrix1.GetLength(0) != matrix2.GetLength(0) || matrix1.GetLength(1) != matrix2.GetLength(1))
            {
                throw new IndexOutOfRangeException("The operation can not be done!");
            }
            int rows = matrix2.GetLength(0);
            int cols = matrix2.GetLength(1);

            Matrix<T> result = new Matrix<T>(rows, cols);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    result[i, j] = (dynamic)matrix1[i, j] - (dynamic)matrix2[i, j];
                }
            }
            return result;
        }

        public static Matrix<T> operator +(Matrix<T> matrix1, Matrix<T> matrix2)
        {
            if (matrix1.GetLength(0) != matrix2.GetLength(0) || matrix1.GetLength(1) != matrix2.GetLength(1))
            {
                throw new IndexOutOfRangeException("The operation can not be done!");
            }
            int rows = matrix2.GetLength(0);
            int cols = matrix2.GetLength(1);

            Matrix<T> result = new Matrix<T>(rows, cols);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    result[i, j] = (dynamic)matrix1[i, j] + (dynamic)matrix2[i, j];
                }
            }
            return result;
        }

        public static Matrix<T> operator *(Matrix<T> matrix1, Matrix<T> matrix2)
        {
            if (matrix1.GetLength(1) != matrix2.GetLength(0))
            {
                throw new IndexOutOfRangeException("The operation can not be done!");
            }
            int rows = matrix1.GetLength(0);
            int cols = matrix2.GetLength(1);

            Matrix<T> result = new Matrix<T>(rows, cols);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    for (int k = 0; k < matrix1.GetLength(1); k++)
                    {
                        result[i, j] += (dynamic)matrix1[i, k] * (dynamic)matrix2[k, j];
                    }

                }
            }
            return result;
        }

        public static bool operator true(Matrix<T> matrix)
        {
            bool hasZeroElement = false;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j].Equals(0))
                    {
                        hasZeroElement = true;
                    }
                }
            }

            return hasZeroElement;
        }

        public static bool operator false(Matrix<T> matrix)
        {
            bool DoesnotHaveZeroElement = true;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j].Equals(0))
                    {
                        DoesnotHaveZeroElement = false;
                    }
                }
            }

            return DoesnotHaveZeroElement;
        }

        public override string ToString()
        {
            var builder = new StringBuilder();

            for (int i = 0; i < this.matrix.GetLength(0); i++)
            {
                for (int j = 0; j < this.matrix.GetLength(1); j++)
                {
                    builder.Append(this.matrix[i, j] + " ");
                }

                builder.AppendLine();
            }

            return builder.ToString().Trim();

        }
    }
}
