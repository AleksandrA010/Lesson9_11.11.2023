using System;

namespace LabWork
{
    internal class BCipher : ICipher
    {
        private int stepMemory;
        private int RequestStep()
        {
            bool flag = false;
            int step = 0;
            Console.Write("\nВведите шаг: ");
            while (!flag)
            {
                flag = int.TryParse(Console.ReadLine(), out step);
                if (!flag)
                {
                    Console.Write("Вы правильно ввели данные.\nПовторите ввод: ");
                }
            }
            Console.WriteLine();
            stepMemory = step;
            return step;
        }
        public string decode(string inputString)
        {
            char[] a = inputString.ToCharArray();
            for (int i = 0; i < a.Length; i++)
            {
                if (char.IsLetter(a[i]))
                {
                    a[i] = (char)(a[i] - stepMemory);
                }
            }
            string stringResult = new string(a);
            return stringResult;
        }

        public string encode(string inputString)
        {
            int step = RequestStep();
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
