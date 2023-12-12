using System;
using System.Collections.Generic;
namespace example
{

    class stack<g>
    {
        private g[] A;
        private int counter;
        public stack(int a)
        {
            A = new g[a];
            counter = 0;
        }
        public int count { get { return counter; } }
        public int lengt { get { return A.Length; } }
        public bool isfull
        {
            get { return A.Length == counter; }
        }
        public void push(g a)
        {
            if (!isfull)
            {
                A[counter] = a;
                counter++;
            }
            else
                throw new Exception("is full");
        }
        public bool isEmpty { get { return counter == 0; } }

        public g pop()
        {

            if (!isEmpty)
            {
                g a = A[count - 1];
                counter--;
                return a;


            }
            else
                throw new Exception("is empty");


        }
        public void delete(int j)
        {
            int k = A.Length - 1 - j;
            g[] n = new g[k];
            //int k = A.Length - 1 - j;
            // g pop1(int j)
            //{
            //    for (int i = 0; i < length; i++)
            //    {
            //        stack<g>[] n = new stack<g>[k];


            //        if (!isEmpty)
            //        {
            //            n[i] = A[count - 1];
            //            counter--;
            //            return a;


            //        }
            //        else
            //            throw new Exception("is empty");

            //    }

            //}



        }





    }
    class program
    {
        public static void Main(string[] arg)
        {

            stack<string> s1 = new stack<string>(5);
            s1.push("1");
            s1.push("1");
            s1.push("rf");
            s1.push("نقفمل");
            s1.push("krkm4");
            Console.WriteLine(s1.count);
            string s = s1.pop();
            Console.WriteLine(s);
            Console.WriteLine(s1.count);


        }
    }
}

