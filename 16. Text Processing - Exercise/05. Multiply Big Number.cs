using System;
using System.Text;

namespace _05.MultiplyBigNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string bigNumber = Console.ReadLine();
            int number = int.Parse(Console.ReadLine());

            if (number == 0)
            {
                Console.WriteLine(0);
                return;
            }

            while (bigNumber[0] == '0')
            {
                bigNumber = bigNumber.Substring(1);
            }

            StringBuilder sb = new StringBuilder();
            int remainder = 0;

            for (int i = bigNumber.Length -1 ; i >= 0; i--)
            {
                int result = int.Parse(bigNumber[i].ToString()) * number + remainder;
                remainder = 0;

                if (result > 9)
                {
                    remainder = result / 10;
                    result = result % 10;
                }

                sb.Append(result);
            }

            if (remainder !=0)
            {
                sb.Append(remainder);
            }


            StringBuilder final = new StringBuilder();
            for (int i = sb.Length - 1; i >= 0; i--)
            {
                final.Append(sb[i]);
            }

            Console.WriteLine(final);
        }
    }
}
