using System;
using System.Text;

namespace ReverseInt
{
    class Program
    {
        static void Main(string[] args)
        {
            Reverse(-123);
        }

        static int Reverse(int number)
        {
            string string_to_number = number.ToString();
            var string_to_number_SB = new StringBuilder(string_to_number);
            var res = new StringBuilder();
            int sign = 1;

            for (int i = string_to_number_SB.Length - 1; i >= 0; i--)
            {
                if (string_to_number[i] == '-')
                {
                    sign *= -1;
                    continue;
                }
                res.Append(string_to_number[i]);
            }

            int.TryParse(res.ToString(), out int n);
            return n * sign;
        }

    }
}
