using System;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();
            myDictionary.Add(1, "Ayse");
            myDictionary.Add(2,"Fatma");
            myDictionary.Add(3, "Beyza");
            myDictionary.DictionaryList();
        }
    }
}
