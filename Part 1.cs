using System;
namespace LabWork
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            
            int x = 0;
            double y = 0;
            
            Console.WriteLine("Введіть число х: ");
            
            x = int.Parse(Console.ReadLine());
            
            if (x < 2) 
            {
                y = (10 * x) / (2 -x);
                Console.WriteLine("Y = " + y);
                
            }
            else if (x <= 15) 
            {
                double dob = 1;
                for (int i = 2; i < x; i++)
                {
                    dob *= (Math.Pow(i, 3) / 3);
                    
                }
                dob =dob * 2;
                Console.WriteLine("Y = " + dob );
            }
            else
            {    
                for (int i = 16; i < x; i++)
                {
                    y += (Math.Pow(i, 2) + 1) / i;
                }
                y = y + 10;
                Console.WriteLine("Y = " + y);
            }
        }
    }
}