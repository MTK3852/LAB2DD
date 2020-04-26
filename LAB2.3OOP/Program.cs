using System;

namespace LAB2._3OOP
{
   public class Program
    {
      public  static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of array elements up to fifty ");
           int  a = Convert.ToInt32(Console.ReadLine());
           if(a>=50)
            {
                Console.WriteLine("Please enter the number of array elements up to fifty");
                a = Convert.ToInt32(Console.ReadLine());
            }
            int [] array = new int[a];
            for (int x =0; x<array.Length; x+=1)
            {
                Console.Write($"Enter array element {x}:");

                array[x] = int.Parse(Console.ReadLine());

            }
            int m = NegativeMUlp(array);
            Console.WriteLine("Multiple Of Negative Elements:"+m);
            int k = Sumofneg(array);



        }
        public static int NegativeMUlp(int[] array)
        {
            Console.WriteLine("Negative elements:");
            int b = 1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    Console.WriteLine(array[i] + " ");
                    b *= array[i];


                }
            }

            return b;
        }
        public static int Sumofneg(int[] array)
        {
            int sum = 0;
            int min = 0;
            int j = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (min > array[i])
                {
                    min = array[i];
                    j = i;
                }
            }
            for (int k = 0; k < array.Length; k++)
            {
                if (k > j)
                {
                    sum += array[k];
                }
            }

            Console.WriteLine($"The sum of the array elements located after the minimum element({min}):" + sum, min);
            return sum;
        }
    }
}
