using System;
using System.Collections.Generic;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("");
        }
    }

    
    class MyDictinoary<TKey, TValue>
    {
        public TKey[] Keys { get; set; }
        public TValue[] Values { get; set; }

        public MyDictinoary()
        {
            this.Keys = new TKey[0];
            this.Values = new TValue[0];
        }

        public void Add(TKey newKey, TValue newValue)
        {
            TKey[] tempKeys = this.Keys;
            TValue[] tempValues = this.Values;

            Keys = new TKey[Keys.Length + 1];
            Values = new TValue[Values.Length + 1];

            for (int i = 0; i < tempKeys.Length; i++)
            {
                Keys[i] = tempKeys[i];
                Values[i] = tempValues[i];
            }
            Keys[Keys.Length - 1] = newKey;
            Values[Values.Length - 1] = newValue;
        }
    }
}
