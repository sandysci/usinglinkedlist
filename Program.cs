using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Linkedlistpratice
{
    class Program
    {
        static void Main(string[] args)
        {
            linkl();
        }
        public static void linkl() {

            LinkedList<string> mylink = new LinkedList<string> { };
            mylink.AddFirst("sandy");//add item to the first
            mylink.AddLast( "health");//the last
            mylink.AddLast("chioma");//after the last
            mylink.AddLast("ezeibe");//after the last

            LinkedListNode<string> mynode = mylink.Find("sandy");// node point to sandy position
            mylink.AddAfter(mynode, "inserted");// add inserted after sandy
            LinkedListNode<string> mynode2 = mylink.Find("chioma");// node point befor chioma
            mylink.AddBefore(mynode2, "before chioma");// insert before chioma
            

            foreach (var my in mylink) {
                Console.WriteLine(my);
            }
            Console.ReadLine();
        }
    }
}
