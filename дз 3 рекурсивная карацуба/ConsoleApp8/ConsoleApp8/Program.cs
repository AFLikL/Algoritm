namespace ConsoleApp8 // Note: actual namespace depends on the project name.
{
    class Carasuba
    {
        static long Refkarasuba(long xIn, long yIn)
        {
            string r1, r2, r3; int n = 0;
            // int lastcara=0;
            r1 = Convert.ToString(xIn); r2 = Convert.ToString(yIn);
            n = r1.Length;
            if (n < 12)
            {
                if (n % 2 == 0)
                {
                    int mn = 0;
                    long x, y, a, b, c, d; x = xIn; y = yIn;
                    //int n=0, n1=0;
                    a = x / Convert.ToInt64(Math.Pow(10, n / 2));
                    b = x % Convert.ToInt64(Math.Pow(10, n / 2));
                    c = y / Convert.ToInt64(Math.Pow(10, n / 2));
                    d = y % Convert.ToInt64(Math.Pow(10, n / 2)); long s1, s2, s3, s4, s5;
                    s1 = a * c; s2 = b * d;
                    s3 = (a + b) * (c + d); s4 = s3 - s1 - s2;
                    s5 = s1 * Convert.ToInt64(Math.Pow(10, n)) + s4 * Convert.ToInt64(Math.Pow(10, n / 2)) + s2;
                    Console.WriteLine(s5);
                    //lastcara = s5;
                    r3 = Convert.ToString(s5);
                    mn = r3.Length - r2.Length;
                    TestREFKarasuba(x, y);
                    return Refkarasuba(s5, y * Convert.ToInt64(Math.Pow(10, mn)));
                }
                else
                {
                    int mn = 0; long x, y, a, b, c, d;
                    x = xIn; y = yIn;              //int n=0, n1=0;
                    a = x / Convert.ToInt64(Math.Pow(10, n / 2)); b = x % Convert.ToInt64(Math.Pow(10, n / 2));
                    c = y / Convert.ToInt64(Math.Pow(10, n / 2)); d = y % Convert.ToInt64(Math.Pow(10, n / 2));
                    long s1, s2, s3, s4, s5; s1 = a * c;
                    s2 = b * d; s3 = (a + b) * (c + d);
                    s4 = s3 - s1 - s2; s5 = s1 * Convert.ToInt64(Math.Pow(10, n - 1)) + s4 * Convert.ToInt64(Math.Pow(10, n / 2)) + s2;
                    Console.WriteLine(s5);              //lastcara = s5;
                    r3 = Convert.ToString(s5); mn = r3.Length - r2.Length;
                    TestREFKarasuba(x, y);
                    return Refkarasuba(s5, y * Convert.ToInt64(Math.Pow(10, mn)));
                }
            }
            else
            {
                return 0;
            }
        }
        static long karasuba(long xIn, long yIn)
        {
            string r1, r2, r3; int n = 0;
            // int lastcara=0;
            r1 = Convert.ToString(xIn); r2 = Convert.ToString(yIn);
            n = r1.Length;
            if (n % 2 == 0)
            {
                int mn = 0; long x, y, a, b, c, d;
                x = xIn; y = yIn;                 //int n=0, n1=0;
                a = x / Convert.ToInt64(Math.Pow(10, n / 2)); b = x % Convert.ToInt64(Math.Pow(10, n / 2));
                c = y / Convert.ToInt64(Math.Pow(10, n / 2)); d = y % Convert.ToInt64(Math.Pow(10, n / 2));
                long s1, s2, s3, s4, s5; s1 = a * c;
                s2 = b * d; s3 = (a + b) * (c + d);
                s4 = s3 - s1 - s2; s5 = s1 * Convert.ToInt64(Math.Pow(10, n)) + s4 * Convert.ToInt64(Math.Pow(10, n / 2)) + s2;
                //Console.WriteLine(s5);                 //lastcara = s5;
                r3 = Convert.ToString(s5);
                return s5;
            }
            else
            {
                int mn = 0; long x, y, a, b, c, d;
                x = xIn; y = yIn;                 //int n=0, n1=0;
                a = x / Convert.ToInt64(Math.Pow(10, n / 2)); b = x % Convert.ToInt64(Math.Pow(10, n / 2));
                c = y / Convert.ToInt64(Math.Pow(10, n / 2)); d = y % Convert.ToInt64(Math.Pow(10, n / 2));
                long s1, s2, s3, s4, s5; s1 = a * c;
                s2 = b * d; s3 = (a + b) * (c + d);
                s4 = s3 - s1 - s2; s5 = s1 * Convert.ToInt64(Math.Pow(10, n - 1)) + s4 * Convert.ToInt64(Math.Pow(10, n / 2)) + s2;
                // Console.WriteLine(s5);                 //lastcara = s5;
                r3 = Convert.ToString(s5);
                return s5;
            }

        }
        static void TestREFKarasuba(long x, long y)
        {
            {
                if (karasuba(x, y) == x * y)
                {
                    Console.WriteLine("Yes");
                }
                else { Console.WriteLine("No"); }
            }
        }
        static void Main(string[] args)
        {
            Refkarasuba(123, 123);


        }
    }
}