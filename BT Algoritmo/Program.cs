using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_Algoritmo
{
    class Program
    {

        static void ImprimeC(char[] vCh)
        {
            string str = new string(vCh);
            Console.Write(str + "\n");
        }

        static string Universo = "abcd";
        static void Combinação(ref char[] vChar, int pos, int ini = 0)
        {
            for(int i = 0; i < Universo.Length; i++)
            {
                vChar[ini] = Universo[i];

                if (ini == pos-1)
                    ImprimeC(vChar);
                else
                    Combinação(ref vChar, pos, ini + 1);
                   
            }
        }

        static void BruteForce(int pos)
        {
            char[] vCh = new char[pos];

            for (int i=1; i<=pos; i++)
            {
                Combinação(ref vCh, i);
            }
        }

        static void Main(string[] args)
        {
            BruteForce(3);
            Console.Read();
        }
    }
}
