using System;
using System.Reflection.Metadata.Ecma335;

namespace Lesson9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task No1
            //Console.WriteLine("Ededi daxil et:");
            //var input = Console.ReadLine();
            //int a= Convert.ToInt32(input);

            //Console.WriteLine("quvveti  daxil et:");
            //var inputp = Console.ReadLine();
            //int apower = Convert.ToInt32(input);

            //Console.WriteLine(Power(a, apower) ); 

            //==================================================================//


            //Task No2
            //Verilmis 3 ededden en boyuyunu tapan metod

            //Console.WriteLine("Ededi daxil et:");
            //var input = Console.ReadLine();
            //int a = Convert.ToInt32(input);

            //Console.WriteLine("Ededi  daxil et:");
            //var input1 = Console.ReadLine();
            //int b = Convert.ToInt32(input1);

            //Console.WriteLine("Ededi  daxil et:");
            //var input2 = Console.ReadLine();
            //int c = Convert.ToInt32(input2);

            //Console.WriteLine(HighestVal(a,b,c));

            //===========================================================================================//

            //Task No3
            //Verilmis ededler siyahisindaki ededlerin cemini tapan metod

            //int[] nums = { 1, 45, 67, 234, 6789, 23 };
            //Console.WriteLine(NumsSum(nums));

            //=====================================================================================//


            //Task No4
            //Verilmis ededler siyahisindaki en boyuk ededi tapan metod


            //int[] nums = { 23, 45, 56, 7664, 3452, 345 };
            //Console.WriteLine(BiggestNum(nums));

          //===================================================================================================================//

            //Task No5
            //Verilmis say qeder ededler daxil edilir ve onlar arasindan en boyuyuk console penceresinde gosterilir

            //Console.WriteLine("Massivin uzunluqunu teyin edin:");
            //var numberStr = Console.ReadLine();
            //int number = Convert.ToInt32(numberStr);
            //int[] numbers = new int[number];
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine($"{i} -ci ededi daxil et:");
            //    var numStr = Console.ReadLine();
            //    var num = Convert.ToInt32(numStr);
            //    numbers[i] = num;

            //}
            //Console.WriteLine(BiggestNum(numbers));


            //===========================================================================================================//


        }





        //Task No1
        //Veroilmish ededi verilmish quvvete yukselden metod
        static int Power(int num, int power)
        {
            int result = 1;
            for (int i = 0; i < power; i++)
            {
                result *= num;
            }
            return result;
        }




        //Task No2
        //Verilmis 3 ededden en boyuyunu tapan metod



        static int HighestVal(int a, int b, int c)
        {
            if (a > b)
            {
                if (a > c)
                {
                    return a;
                }
                else
                {
                    return c;
                }
            }
            else if (b > c)
            {
                return b;
            }
            else
            {
                return c;
            }
        }



        //Task No3
        //Verilmis ededler siyahisindaki ededlerin cemini tapan metod
        static int NumsSum(int[] numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return sum;
        }


        //Task No4
        //Verilmis ededler siyahisindaki en boyuk ededi tapan metod
        static int BiggestNum(int[] numbers)
        {
            int max = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i]>max)
                {
                    max = numbers[i];
                }
            }
            return max;
        }










    }





}
