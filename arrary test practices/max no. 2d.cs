//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace arrary_test_practices
//{
//    internal class Class17
//    {
//        static void Main(string[] args)
//        {
//            int[,] numbers = new int[3, 4]
//           {
//                {3,5,7,8},
//                {5,6,8,9},
//                {7,4,1,9}
//           };
//            int max;
//            for (int i = 0; i < numbers.GetLength(0); i++)     //maximum number of each row of 2 d array
//            {
//                max = numbers[i, 0];
//                for (int j = 1; j < numbers.GetLength(1); j++)
//                {
//                    if (numbers[i, j] > max)
//                    {
//                        max = numbers[i, j];
//                    }

//                }
//                Console.WriteLine(max);
//            }
//        }
//    }
//}
