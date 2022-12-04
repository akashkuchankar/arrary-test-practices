//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace arrary_test_practices
//{
//    internal class Class16
//    {
//        static void Main(string[] args)
//        {
//            int[,] numbers = new int[3, 4]
//            {
//                 {2,3,4,5 },
//                 { 3,5,7,8},
//                 { 3,5,7,9}
//            };
//            int nrow = numbers.GetLength(0);         // minimum number of 2 d array
//            int ncol = numbers.GetLength(1);
//            int lowest = numbers[0, 0];
//            for (int i = 0; i < nrow; i++)
//            {
//                for (int j = 0; j < ncol; j++)
//                {
//                    int num = numbers[i, j];
//                    if (num < lowest)
//                        lowest = num;
//                }
//            }
//            Console.WriteLine("lowest number is {0}", lowest);
//            Console.ReadLine();

//        }
//    }
//}
