using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Problemas.Clases
{
    public class ChangeString
    {
        public string build(string Entrada)
        {
            string output = string.Empty;

            char[] letras = new char[27] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'ñ', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            char[] letrasM = new char[27] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'Ñ', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };

            char[] caracteres = Entrada.ToCharArray();

            for (int i = 0; i < caracteres.Count(); i++)
            {
                if (Char.IsUpper(caracteres[i]))
                {
                    for (int j = 0; j < letrasM.Count(); j++)
                    {
                        if (caracteres[i] == letrasM[j])
                        {
                            caracteres[i] = letrasM[j + 1];
                            break;
                        }
                    }
                }
                else
                {
                    for (int j = 0; j < letras.Count(); j++)
                    {
                        if (caracteres[i] == letras[j])
                        {
                            caracteres[i] = letras[j + 1];
                            break;
                        }
                    }
                }
                
                output += caracteres[i].ToString();
            }
            return output;
        }
    }
}