﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metody09_14GitHub
{
    class Vypocty
    {
        public static double Diskriminant(double a, double b, double c, out double x1, out double x2, out double d)
        {
            d = (b * b) - (4 * a * c);
            x1 = 0;
            x2 = 0;
            if (d < 0)
            {
                d = 0;
            }
            else if (d > 0)
            {
                x1 = (-b + Math.Sqrt(d)) / (2 * a);
                x2 = (-b - Math.Sqrt(d)) / (2 * a);
            }
            else
            {
                x1 = (-b + Math.Sqrt(d)) / (2 * a);
            }
            return d;
        }
        public static bool ObsahujeCislici(string sup, out int cifSoucet, out int lichCifSoucet, out int sudCifSoucet)
        {
            bool obsahujeCislici = false;
            cifSoucet = 0;
            lichCifSoucet = 0;
            sudCifSoucet = 0;
            for (int i = 0; i < sup.Length; ++i)
            {
                if (Char.IsNumber(sup[i]))
                {
                    obsahujeCislici = true;
                    cifSoucet += int.Parse(sup[i].ToString());

                    if (int.Parse(sup[i].ToString()) % 2 != 0)
                    {
                        lichCifSoucet += int.Parse(sup[i].ToString());
                    }
                    else if (int.Parse(sup[i].ToString()) % 2 == 0)
                    {
                        sudCifSoucet += int.Parse(sup[i].ToString());
                    }
                }
            }
            return obsahujeCislici;
        }
        public static int PocetSlov1(string vstup,out string UpravenyRetezec )
        {  
            char[] separators = { ' ' };
            vstup = vstup.Trim();
            string[] poleslov = vstup.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            int PocetSlov = poleslov.Length;
            
            int i = 0;
            while(i<vstup.Length)
            {
                if(char.IsNumber(vstup[i]))
                {
                    vstup= vstup.Remove(i, 1);

                }
                else ++i; 

            }
            UpravenyRetezec = vstup;                   
            return (PocetSlov);
        }






    }


            


        }
    

