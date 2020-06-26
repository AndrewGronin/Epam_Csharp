using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading;

namespace Task2NOD
{
    static public class NOD
    {
        static public int GetNOD(int a, int b)//Метод евклида
        {
            int t;
            while (b != 0) 
            {
                t = b;
                b = a % b;
                a = t;
            }
            return a;
        }


        static public int GetNOD(int a, int b , int c)//NOD(a,b,c) = NOD(NOD(a,b),c)
        {
            int NODab = GetNOD(a, b);
            return GetNOD(NODab, c);
        }


        static public int GetNOD(int a, int b, int c, int d)
        {
            int NODab = GetNOD(a, b);
            int NODabc = GetNOD(NODab, c);
            return GetNOD(NODabc, d);
        }


        static public int GetNOD(int a, int b, int c, int d, int e)
        {
            int NODab = GetNOD(a, b);
            int NODabc = GetNOD(NODab, c);
            int NODabcd = GetNOD(NODabc, d);
            return GetNOD(NODabcd, e);
        }
    


    static public int GetNODBinary(int u, int v)
    {
        int shift = 0;

        /* GCD(0,v) == v; GCD(u,0) == u, GCD(0,0) == 0 */
        if (u == 0) return v;
        if (v == 0) return u;

        /* Let shift := lg K, where K is the greatest power of 2
            dividing both u and v. */
        while (((u | v) & 1) == 0)
        {
            shift++;
            u >>= 1;
            v >>= 1;
        }

        while ((u & 1) == 0)
            u >>= 1;

        /* From here on, u is always odd. */
        do
        {
            /* remove all factors of 2 in v -- they are not common */
            /*   note: v is not zero, so while will terminate */
            while ((v & 1) == 0)
                v >>= 1;

            /* Now u and v are both odd. Swap if necessary so u <= v,
                then set v = v - u (which is even). For bignums, the
                 swapping is just pointer movement, and the subtraction
                  can be done in-place. */
            if (u > v)
            {
                int t = v; v = u; u = t; // Swap u and v.
            }

            v -= u; // Here v >= u.
        } while (v != 0);

        /* restore common factors of 2 */
        return u << shift;
    }


        public static int GetNODBinaryWithTime(int a, int b, out TimeSpan time)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            int res = GetNODBinary(a, b);
            stopWatch.Stop();
            // Get the elapsed time as a TimeSpan value.
            time = stopWatch.Elapsed;
            return res;
        }

        public static int GetNODWithTime(int a, int b, out TimeSpan time)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            int res = GetNOD(a, b);
            stopWatch.Stop();
            // Get the elapsed time as a TimeSpan value.
            time = stopWatch.Elapsed;
            return res;
        }
    }
}
