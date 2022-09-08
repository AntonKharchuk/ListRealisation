using System;

namespace ListRealisation
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<int> myIntList = new MyList<int>();

            for (int i = 0; i < 10; i++)
            {
                myIntList.Add(i*4);
            }
            Console.WriteLine(myIntList.Length);

            myIntList.RemoveAt(5);
            Console.WriteLine(myIntList.Length);
            Console.WriteLine("-------------");

            for (int i = 0; i < myIntList.Length; i++)
            {
                Console.WriteLine(myIntList[i]);
            }
            Console.WriteLine("============");

            MyList<string> myStringList = new MyList<string> ("adfas");

            myStringList.Add("asdae");
            myStringList.Add("aqwghq");
            myStringList.Add("qhqf");
            myStringList.Add("s");
            myStringList.Add("tqwd");


            for (int i = 0; i < myStringList.Length; i++)
            {
                Console.WriteLine(myStringList[i]);
            }
            Console.WriteLine("============");

            MyList<char> myCharList = new MyList<char>();

            for (int i = 97; i < 109; i++)
            {
                myCharList.Add((char)i);
            }
            Console.WriteLine(myCharList.Length);

            myCharList.RemoveAt(myCharList.Length-1);
            Console.WriteLine(myCharList.Length);

            Console.WriteLine("-------------");

            for (int i = 0; i < myCharList.Length; i++)
            {
                Console.WriteLine(myCharList[i]);
            }
;



        }
    }
}
