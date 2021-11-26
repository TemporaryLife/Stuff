using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new ListNode(9);
            var b = new ListNode(1, new ListNode(9, new ListNode(9,new ListNode(9,new ListNode(9,
                new ListNode(9,new ListNode(9,new ListNode(9,new ListNode(9,new ListNode(9))))))))));
            Console.WriteLine(AddTwoNumbers(a, b).val);
        }
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int val = 0, ListNode next = null)
            {
                this.val = val;
                this.next = next;
            }


            public static decimal ListToNumber(ListNode node)
            {
                var result_string = new StringBuilder();
                var current_node = node;

                do
                {
                    if (current_node != null)
                    {
                        
                        result_string.Insert(0, current_node.val.ToString());
                        current_node = current_node.next;
                    }
                    else
                    {
                        break;
                    }

                } while (node.next != null);
                Console.WriteLine(BigInteger.Max());
                /*var res = Convert.ToUInt64(Convert.ToString(result_string));*/

                return res;
            }


        }
        static public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {

            var Number1 = ListNode.ListToNumber(l1);
            var Number2 = ListNode.ListToNumber(l2);
            var list_of_nodes=new List<ListNode>();
            var res = new StringBuilder(Convert.ToString(Number1 + Number2));
            
            ListNode node;
            
            for (int i= 0; i < res.ToString().Length; i++)
            {
                if (i == 0)
                {
                    node =new ListNode(int.Parse(Convert.ToString(res[i])));
                    
                    
                }
                else
                {
                    node= new ListNode(int.Parse(Convert.ToString(res[i])), list_of_nodes[i-1] );
                }
                
                
                list_of_nodes.Add(node);

                 
            }

            return list_of_nodes[list_of_nodes.Count-1];
        }
    }
}
