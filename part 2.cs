using System;

namespace LabWork
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
             
            Console.Write("Введіть ціле число X >1: ");
            while (!int.TryParse(Console.ReadLine(), out int x) || x <= 1)
            {
                Console.WriteLine("Ви помилились, число має бути >1");
                
                Console.Write("Введіть ціле число X >1: ");
            }
            
            int n = 0;
            for (int i = 9; i > 1; i--)
            {
                while (x % i == 0)
                {
                    n = n * 10 + i;
                    x /= i;
                }
            }
            
            string s = n.ToString();
            char[] ar = s.ToCharArray();
            Array.Reverse(ar);
            s = new String(ar);
            n = Convert.ToInt32(s);
            
            if (x > 1)
            {
                Console.WriteLine("Такого числа не існує");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Найменше натуральне число: " + n);
                Console.ReadLine();
            }
        }
    }
}
