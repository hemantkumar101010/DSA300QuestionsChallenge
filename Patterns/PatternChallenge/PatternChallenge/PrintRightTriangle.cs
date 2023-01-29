using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternChallenge
{
    internal class PrintRightTriangle
    {
        public void Print()
        {
            Console.WriteLine("Enter number of rows in the triangle pattern");
            int row = Convert.ToInt32(Console.ReadLine());//3
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j <=i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        //* * * * *
        //* * * * *
        //* * * * *
        //* * * * *
        //* * * * *

        public void PrintSquare()
        {
            Console.WriteLine("Enter number of col/row in the square pattern");
            int side = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < side; i++)
            {
                for (int j = 0; j < side; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
           if(side == Convert.ToInt32(Console.ReadLine()))
            {
                    Console.WriteLine(side);
            }

        }     //*       *********
        //     **       *       *
        //              *********
        //    ***
        //   ****
        public void HollowRectangular()
        {
            Console.WriteLine("Enter number of rows in the hollow rectangular pattern");
            int row = Convert.ToInt32(Console.ReadLine());//3
            Console.WriteLine("Enter number of col in the hollow rectangular pattern");
            int col = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < row; i++)
            {
                if (i == 0 || i == row - 1)
                {
                    for (int j = 0; j < col; j++)
                    {
                        Console.Write("* ");
                    }
                    Console.WriteLine();
                }
                else
                {
                    Console.Write("* ");
                    for (int k = 0; k < col-2; k++)
                    {
                        Console.Write("  ");


                    }
                    Console.Write("* ");
                    Console.WriteLine();
                }
               
            }
        }
    }
}
