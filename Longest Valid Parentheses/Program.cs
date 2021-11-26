using System;

namespace Longest_Valid_Parentheses
{
    class Program
    {
        static void Main(string[] args)
        {
            LongestValidParentheses("())(())");
        }

        public static int LongestValidParentheses(string s)
        {
            int max_streak=0;
            int current_streak=0;
            int leftSkobCount=0;
            int rightSkobCount=0;


            for (int i=0; i<s.Length; i++)
            {
                

                
                if (s[i]=='(')
                {
                    leftSkobCount++;
                }
                else
                {
                    rightSkobCount++;

                }
                current_streak=leftSkobCount+rightSkobCount;
                Console.WriteLine("-------------------------");
                Console.WriteLine(leftSkobCount);
                Console.WriteLine(rightSkobCount);
                Console.WriteLine("-------------------------");
                
                if (rightSkobCount>leftSkobCount)
                {
                    
                    current_streak=leftSkobCount+rightSkobCount-current_streak;
                    
                    
                }
                else
                {
                    if (current_streak > max_streak)
                    {
                        max_streak = current_streak;
                    }
                }
                
                
                /*if (s[i] == '(')
                {
                    leftSkobCount++;
                    if (s[i+1]==')')
                    {
                        rightSkobCount++;
                        current_streak+=1;
                        i++;
                        if( current_streak>max_streak)
                        {
                            max_streak=current_streak;
                        }
                    }
                    else
                    {
                        leftSkobCount++;
                    }
                }
                else
                {
                    current_streak=0;

                }*/

            }
            Console.WriteLine(current_streak);
            Console.WriteLine(max_streak);
            return max_streak;
        }
    }
}
