using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЗадачаЧислоПалиндром
{
    public class MainModel
    {
        public static string ReverseStr(string intput)
        {
            if (intput == null) intput = "";
             
            string revers = "";
            
            for (int i = intput.Length - 1; i >= 0; i--)
            {
                revers += intput[i] ;
            }
            
            return revers;
        }

        public static string CheckOK(string intput, string revers)
        {
           return  intput == revers ? "ДА - это палиндром" : "НЕТ - введенное число НЕ палиндром";
        }

    }
}
