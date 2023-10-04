using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.PyanzinaMA.Sprint2.Task1.V29.Lib
{
    public class DataService : ISprint2Task1V29
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] res = new bool[6];

            res[0] = (a == d) | (a!=c) ;
            res[1] = (b < a) & (c > b) ;
            res[2] = (c <= a) || (b >= c);
            res[3] = (a != d) && (a > b) ;
            res[4] = !(a == b) ;
            res[5] = (d >= c) ^ (a < c) ;

            return res;
        }
    }
}
//  true, true, true, false, true, true
//  ==, !=, <, >, <=, >=,
//  |, &, ||, &&, !, ^, последовательность операций не должна нарушаться
//a = 657;
//b = 654;
//c = 657;
//d = 657;
