using System;

namespace LabWork
{
    internal class ACipher : ICipher
    {

        public string decode(string inputString)
        {
            int step = 1;
            char[] a = inputString.ToCharArray();
            for (int i = 0; i < a.Length; i++)
            {
                if (char.IsLetter(a[i]))
                {
                    a[i] = (char)(a[i] - step);
                }
            }
            string stringResult = new string(a);
            return stringResult;
        }

        public string encode(string inputString)
        {
            int step = 1;
            char[] a = inputString.ToCharArray();
            for (int i = 0; i < a.Length; i++)
            {
                if (char.IsLetter(a[i]))
                {
                    a[i] = (char)(a[i] + step);
                }
                else
                {

                }
            }
            string stringResult = new string(a);
            return stringResult;
        }
    }
}
