using System;
using System.Security.Cryptography;
//using Math
namespace ConsoleApp7 // Note: actual namespace depends on the project name.
{
    class Carasuba
    {
        // я решил считать длинну числа потому что так проще представить рекурсивную версию алгоритма карацубы
        static long karasuba(long xIn, long yIn)
        {
            string r1, r2, r3; int n = 0;
            // int lastcara=0;
            r1 = Convert.ToString(xIn); r2 = Convert.ToString(yIn);
            n = r1.Length;

            int mn = 0; long x, y, a, b, c, d;
            x = xIn; y = yIn;                 //int n=0, n1=0;
            a = x / Convert.ToInt64(Math.Pow(10, n / 2)); b = x % Convert.ToInt64(Math.Pow(10, n / 2));
            c = y / Convert.ToInt64(Math.Pow(10, n / 2)); d = y % Convert.ToInt64(Math.Pow(10, n / 2));
            long s1, s2, s3, s4, s5; s1 = a * c;
            s2 = b * d; s3 = (a + b) * (c + d);
            s4 = s3 - s1 - s2;
            if (n % 2 == 0)
            {
                s5 = s1 * Convert.ToInt64(Math.Pow(10, n)) + s4 * Convert.ToInt64(Math.Pow(10, n / 2)) + s2;
            }
            else
            {
                s5 = s1 * Convert.ToInt64(Math.Pow(10, n - 1)) + s4 * Convert.ToInt64(Math.Pow(10, n / 2)) + s2;
            }
            //Console.WriteLine(s5);                 //lastcara = s5;
            r3 = Convert.ToString(s5);
            return s5;

        }

        static void TestKarasuba()
        {
            long[,] test = { { 1234, 1234 }, { 879347, 452869 }, { 78, 77439 }, { 78918, 2 } };
            long[] res = { 1522756, 398228996543, 6040242, 157836 }; for (int i = 0; i < 4; i++)
            {
                if (karasuba(test[i, 0], test[i, 1]) == res[i])
                {
                    Console.WriteLine("Yes");
                }
                else { Console.WriteLine("No"); }
            }
        }
        static void Main(string[] args)
        {

            TestKarasuba();
        }
    }
}