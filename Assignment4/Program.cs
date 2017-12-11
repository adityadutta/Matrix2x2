using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int op; // variable to hold option
                char ch; // var to hold choice
                double e11, e12, e21, e22; //vars to hold vector values and scalar value   
                Matrix2x2 matrix = new Matrix2x2();        
                do
                {
                    //user input for matrix2x2
                    Console.Write("Input a value for row 1 and column 1: ");
                    e11 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Input a value for row 1 and column 2: ");
                    e12 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Input a value for row 2 and column 1: ");
                    e21 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Input a value for row 2 and column 2: ");
                    e22 = Convert.ToDouble(Console.ReadLine());

                    matrix = new Matrix2x2(e11, e12, e21, e22);

                    Console.WriteLine(e11 + "    " + e12 + "\n" + e21 + "    " + e22);
                    //Options
                    Console.WriteLine("Matrix2x2\n1.Add Matrix\n2.Subtract Matrix\n3.Set Scaling Matrix\n4.Quit");
                    Console.WriteLine("\nEnter your choice: "); //user option
                    op = Convert.ToInt32(Console.ReadLine());
                    //switching the options
                    switch (op)
                    {
                        case 1:
                            Console.Write("Input a value for row 1 and column 1: ");
                            e11 = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Input a value for row 1 and column 2: ");
                            e12 = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Input a value for row 2 and column 1: ");
                            e21 = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Input a value for row 2 and column 2: ");
                            e22 = Convert.ToDouble(Console.ReadLine());

                            Matrix2x2 otherMatrix = new Matrix2x2(e11, e12, e21, e22);
                            matrix.AddMatrix(otherMatrix);
                            break;
                        case 2:
                            Console.Write("Input a value for row 1 and column 1: ");
                            e11 = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Input a value for row 1 and column 2: ");
                            e12 = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Input a value for row 2 and column 1: ");
                            e21 = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Input a value for row 2 and column 2: ");
                            e22 = Convert.ToDouble(Console.ReadLine());

                            Matrix2x2 otherMatrix1 = new Matrix2x2(e11, e12, e21, e22);
                            matrix.SubtractMatrix(otherMatrix1);
                            break;
                        case 3:
                            double scaleX, scaleY;
                            Console.Write("Enter value to Scale X: ");
                            scaleX = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Enter value to Scale Y: ");
                            scaleY = Convert.ToDouble(Console.ReadLine());

                            matrix.SetScalingMatrix(scaleX, scaleY);
                            break;
                        case 4:
                            //exit the applications
                            Environment.Exit(0);
                            break;
                        default:
                            //if invalid input is entered
                            Console.WriteLine("Invalid Input! Try again.");
                            break;
                    }
                    //users' choice to continue
                    Console.WriteLine("\nContinue?(y/n)");
                    ch = Convert.ToChar(Console.ReadLine());
                }
                //if it is 'yes' continue the program
                while (ch == 'y' || ch == 'Y');
            }
            //catching exception and displaying error
            catch (Exception e)
            {
                Console.WriteLine("Error encountered: " + e.Message + "\nRun the program again! Press any key.");
                Console.ReadKey();
            }

        }
    }
}
