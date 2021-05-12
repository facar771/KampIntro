using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDictionary<T>
    {
        T[] words;
        public MyDictionary()
        {
            words = new T[0];
        }
        public void Add(T word)
        {
            T[] tempArray = words;
            words = new T[words.Length + 1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                words[i] = tempArray[i];
            }
            words[words.Length-1] = word;
        }
        public int Length
        {
            get { return words.Length; }
        }
    } 
}
