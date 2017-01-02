using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericMatrix
{
    class StartUp
    {
        static void Main(string[] args)
        {
            Matrix<int> integerMatrix1 = new Matrix<int>(4, 2);
            Matrix<int> integerMatrix2 = new Matrix<int>(4, 2);
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    integerMatrix1[i, j] = (i*2 - j*3) * 3 - 2;
                    integerMatrix2[i, j] = (i * 3 - j * 2) * 3 - 1;

                }
            }

            Console.WriteLine($"Matrix 1: \n{integerMatrix1.ToString()}\n");
            Console.WriteLine($"Matrix 2: \n{integerMatrix2.ToString()}\n");
            Matrix<int> add = integerMatrix1 + integerMatrix2;
            Console.WriteLine($"Matrix 1+ Matrix 2: \n{add.ToString()}\n");
            Matrix<int> sub = integerMatrix1 - integerMatrix2;
            Console.WriteLine($"Matrix 1- Matrix 2: \n{sub.ToString()}\n");
            Matrix<int> multiplication = integerMatrix1 * integerMatrix2; // the matrixes do not cover the requirements for the operation -> they throw an exception

        }
    }
}
