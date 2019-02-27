using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27._02._2019_CW
{
    class Program
    {
        static void Main(string[] args)
        {

            Exmpl106();

        }

        public static ArrayList Example101()
        {
            Random rnd = new Random();
            ArrayList ar = new ArrayList();
            for (int i = 0; i < 5; i++)
            {
                ar.Add(rnd.Next(1, 5));
                Console.WriteLine(ar[i]);
            }
            ar.Add("Hola");
            ar.Add(true);

            //Remove
            ar.RemoveRange(1, 5);
            //ar.ToArray().OrderBy();
            return ar;
        }

        public static void Exmpl102()
        {
            Hashtable hash = new Hashtable();
            hash.Add("df", "1");
            hash.Add("ddf", "2");
            hash.Add("dfdf", "3");

            ICollection keys = hash.Keys;
            foreach (var item in keys)
            {
                Console.WriteLine(hash[item]);
            }
        }

        public static void Exmpl103()
        {
            Queue<int> qe = new Queue<int>();
            Random rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                qe.Enqueue(i);
            }


            Console.WriteLine("Очередь 0");
            foreach (int item in qe)
            {

                Console.WriteLine(item);
            }
            //вытащили с очереди
            var t = qe.Dequeue();
            var t1 = qe.Peek();
            Console.WriteLine("Кто следующий {0}", t1);
            Console.WriteLine("Очередь 1");
            foreach (int item in qe)
            {

                Console.WriteLine(item);
            }

        }

        public static void Exmpl104()
        {
            Stack<int> vs = new Stack<int>();
            vs.Push(3);
            vs.Push(5);
            vs.Push(6);
            foreach (var item in vs)
            {
                Console.WriteLine(item);
            }
            //вытащим
            int st = vs.Pop();
            Console.WriteLine("\n\n");
            foreach (var item in vs)
            {
                Console.WriteLine(item);
            }
        }
        public static void Exmpl105()
        {
            Dictionary<int, string> dic = new Dictionary<int, string>();
            for (int i = 0; i < 10; i++)
            {
                dic.Add(i, "->" + i);
            }
            if (!dic.ContainsKey(5))
                dic.Add(5, "->5");

            foreach (var item in dic)
            {
                Console.WriteLine("Key {0} - Value {1}", item.Key, item.Value);
            }

            //ILookup lp = new Lookup<int, string>;

        }

        public static void Exmpl106()
        {
            SortedList<int, string> keyValuePairs = new SortedList<int, string>();

            keyValuePairs.Add(1,"1");
            keyValuePairs.Add(5, "1");
            keyValuePairs.Add(2, "1");

            foreach (var item in keyValuePairs)
            {
                Console.WriteLine("{0}-{1}",item.Key, item.Value);
            }

        }
    }
}
