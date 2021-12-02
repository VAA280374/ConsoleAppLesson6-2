using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLesson6_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string vStr = Console.ReadLine();
            // Console.WriteLine(vStr);
            string[] vStrArray = vStr.Split();
            string vResult = "";
            int vStrLenght = 0;
            bool _true = true;
            foreach (string str in vStrArray)
            {
                vResult += str;
            }
            vStrLenght = vResult.Length;
            vResult = vResult.ToLower();
            // Console.WriteLine(vResult);
            // Console.WriteLine(vStrLenght);
            int vStrLenght1 = vStrLenght / 2;
            for (int i = 0; i < vStrLenght1; i++)
            {
                // Console.WriteLine("{0}   {1}", vResult[i], vResult[vStrLenght - 1 - i]);
                if (vResult[i] != vResult[vStrLenght - 1 - i])
                {
                    _true = false;
                    break;
                }
            }
            if (_true) Console.WriteLine("Введенное предложение является палидромом");
            else Console.WriteLine("Введенное предложение палидромом не является");
            Console.ReadKey();
        }
    }
}
