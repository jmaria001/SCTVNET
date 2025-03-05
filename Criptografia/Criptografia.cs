using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
namespace Criptografia
{
    public static partial class Funcoes
    {
        static Random Rnd = new Random();
        public static string Criptografar(string pSenha)
        {
            pSenha = pSenha.PadRight(10, ' ');
            int bt1, bt2, bt3;
            char Caractere;
            string strTemp;
            string strResult = "";
            for (int i = 0; i < 10; i++)
            {
                Caractere = char.Parse(pSenha.Substring(i, 1));
                bt1 = Convert.ToInt16(Caractere);

                bt2 = Random(1, 700);
                bt3 = bt1 + bt2;
                strTemp = bt2.ToString().PadLeft(3, '0') + bt3.ToString().PadLeft(3, '0');
                strResult += strTemp.Substring(0, 1) +
                            strTemp.Substring(3, 1) +
                            strTemp.Substring(5, 1) +
                            strTemp.Substring(1, 1) +
                            strTemp.Substring(4, 1) +
                            strTemp.Substring(2, 1);
            }   
            return strResult;
        }
        public static string deCriptografar(string pSenha)
        {
            string strRetorno = "";
            int bt1, bt2, bt3;
            string strTemp;
            for (int i = 0; i < 60; i += 6)
            {
                strTemp = pSenha.Substring(i, 6);
                bt1 = Convert.ToInt16(strTemp.Substring(0, 1) + strTemp.Substring(3, 1) + strTemp.Substring(5, 1));
                bt2 = Convert.ToInt16(strTemp.Substring(1, 1) + strTemp.Substring(4, 1) + strTemp.Substring(2, 1));
                bt3 = bt2 - bt1;
                strRetorno += (char)bt3;
            }
            return strRetorno;
        }
        static int Random(int pMin, int pMax)
        {
            return Rnd.Next(pMin, pMax);
        }

    }
}
