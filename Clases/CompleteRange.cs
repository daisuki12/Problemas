using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Problemas.Clases
{
    public class CompleteRange
    {
        public int[] build(int[] Entrada)
        {
            int maxIndex = -1;
            int maxInt = Int32.MinValue;

            for (int i = 0; i < Entrada.Length; i++)
            {
                int value = Entrada[i];
                if (value > maxInt)
                {
                    maxInt = value;
                    maxIndex = i;
                }
            }


            int[] array = new int[maxInt];

            for (int i = 0; i < maxInt; i++)
            {
                array[i] = i + 1;
            }
            return array;
        }
    }
}