using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    class Program
    {
        static void Main(string[] args)
        {

            int num = Int32.Parse(Console.ReadLine());
            switch (num)
            {
                case 1:
                    {
                        ArrayList collection = Exmp01(15);
                        Console.WriteLine("исходная коллекция чисел:");
                        WriteCollection(collection);
                        Console.WriteLine("--------------------------------------------------------------------------------");
                        removeElement(1, 5, ref collection);
                        WriteCollection(collection);
                        Console.WriteLine("--------------------------------------------------------------------------------");

                        collection.Sort();
                        WriteCollection(collection);
                    }
                    break;

                case 2:
                    {
                        ArrayList obj = new ArrayList() { 1, 2, "string", 'c', 0.2f, true };
                        WriteCollection(obj);

                        
                    }
                    break;
                case 3:
                    {
                        Queue<int> qe = new Queue<int>();
                        Random rnd = new Random();
                        for (int i = 0; i < 10; i++)
                        {
                            qe.Enqueue(rnd.Next(1, 10));
                        }

                        Console.WriteLine("Queue: ");
                        foreach (int item in qe)
                        {
                            Console.WriteLine(item);

                        }

                        Console.WriteLine("Count: "+qe.Count);

                        Console.WriteLine("Queue2: ");
                        for (int i=0;i<qe.Count; i++)
                        {
                            Console.WriteLine(qe.Dequeue()+"-"+ qe.Count);
                        }
                        Console.WriteLine("Count: " + qe.Count);
                    }
                    break;

                case 4:
                    {
                        Dictionary<int,int> d = new Dictionary<int, int>();

                        d.Add(1, 5);
                        d.Add(2, 5);
                        d.Add(3, 5);

                        foreach (var item in d)
                        {
                            Console.WriteLine((item.Key+"-"+item.Value));
                        }

                       // Lookup<int, int> l = new Lookup<int, int>();

                        if(d.ContainsKey(2))
                            Console.WriteLine("Ok"); 

                    }
                    break;
            }
        }

        static ArrayList Exmp01(int k)
        {
            Random rnd = new Random();
            ArrayList arr = new ArrayList();
            for (int i = 0; i < k; i++)
            {
                arr.Add(i);
            }
        //    arr.Add("Hello"); //добавить можно все что угодно
            //getType, Typeof
            return arr;
        }

        public static void removeElement(int i, int j, ref ArrayList arr)
        {
           arr.RemoveRange(i, j);//удалить с- по         
        }

        public static void  AddElement(int i, int j, ref ArrayList arr)
        {         
            arr.Add(i);
        }
        public static void WriteCollection(ArrayList arr)
        {
            foreach (var item in arr)
            {
                Console.WriteLine("{0}--\t{1}\t", item, item.GetType());

                if (item.GetType()==typeof(int))
                    Console.WriteLine("*");
            }
        }
    }
}
