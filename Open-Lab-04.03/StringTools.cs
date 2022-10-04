using System;

namespace Open_Lab_04._03
{
    public class StringTools
    {
        public string RemoveFirstLast(string original)
        {
            if (original.Length > 1)
            {
                string result = original.Substring(1, original.Length-2);
                return result;
            }
            else
            {
                return original;
            }
            
        }
    }
}
