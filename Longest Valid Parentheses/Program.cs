using System;

namespace Longest_Valid_Parentheses
{
    class Program
    {
        static void Main(string[] args)
        {
            LongestValidParentheses("(");
        }

        public static int LongestValidParentheses(string s)
        {
            int max_streak=0;
            int current_streak=0;


            for (int i=0; i<s.Length-1; i++)
            {
                
                if (s[i] == '(')
                {
                    if (s[i+1]==')')
                    {
                        current_streak+=1;
                        i++;
                        if( current_streak>max_streak)
                        {
                            max_streak=current_streak;
                        }
                    }
                }
                else
                {
                    current_streak=0;

                }

            }
            Console.WriteLine(max_streak);
            return max_streak;
        }
    }
}
