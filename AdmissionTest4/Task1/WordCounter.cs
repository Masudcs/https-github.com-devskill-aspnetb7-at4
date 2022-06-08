using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
  
    public class WordCounter
    {

       
        public int Count(string text)
        {
            int count = text.Trim().Split(' ', '$', '#', '@', '.', '(', ',', '?', ')', '{', '}', '[', ']', '$', '%', '1', '2', '3', '4', '5', '6', '7', '8', '9', '0').Length;
            return count;
        }
       
    }
}
