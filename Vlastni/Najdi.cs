using System;
using System.Collections.Generic;

namespace Vlastni
{
    public class Najdi
    {
        public static double DruheMax(List<double> cisla)
        {
            if (cisla.Count > 0)
            {
                double druheMax = double.MinValue;
                double max = double.MinValue;
                foreach (double prochazeneCislo in cisla)
                {
                    if (prochazeneCislo > max)
                    {
                        druheMax = max;
                        max = prochazeneCislo;
                    }
                    else if (prochazeneCislo > druheMax) druheMax = prochazeneCislo;
                }
                return druheMax;
            }
            else return -1;
        }
        public static double DruheMin(List<double> cisla)
        {
            if (cisla.Count > 0)
            {
                double druheMin = double.MaxValue;
                double min = double.MaxValue;
                foreach (double prochazeneCislo in cisla)
                {
                    if (prochazeneCislo < druheMin)
                    {
                        druheMin = min;
                        min = prochazeneCislo;
                    }
                    else if (prochazeneCislo > druheMin) druheMin = prochazeneCislo;
                }
                return druheMin;
            }
            else return -1;
        }

        public static char znakvNejvetsimPoctu(List<char> znaky)
        {
            char znakMax = ' ';
            int pocetMax = -1;
            int pocet = 0;

            foreach (char i in znaky)
            {
                foreach (char j in znaky)
                {
                    if (i == j) ++pocet;
                }

                if (pocet > pocetMax)
                {
                    znakMax = i;
                    pocetMax = pocet;
                }
                pocet = 0;
            }

            return znakMax;
        }
    }
}
