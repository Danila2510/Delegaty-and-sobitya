using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp22
{
    internal class Rabota
    {
        #region Задание первое :
        public static string Parnie(int[] a)
        {
            string buf = "";
            for (int i = 0; i < a.Length; i++)
                if (a[i] % 2 == 0 && a[i] != 0)
                    buf += a[i] + " ";
            return buf;
        }
        public static string Neparnie(int[] a)
        {
            string buf = "";
            for (int i = 0; i < a.Length; i++)
                if (a[i] % 2 != 0)
                    buf += a[i] + " ";
            return buf;
        }
        public static string Unkalnie(int[] a)
        {
            string buf = "";
            for (int i = 0; i < a.Length; i++)
                if ((a[i] % 2 != 0 && a[i] % 3 != 0) || a[i] == 2 || a[i] == 3)
                    buf += a[i] + " ";
            return buf;
        }
        public static string Fibanachi(int[] a)
        {
            string buf = "";
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] <= 2) buf += 1 + " ";
                int x = 1;
                int y = 1;
                int ans = 0;
                for (int j = 3; j <= a[i]; j++)
                {
                    ans = x + y;
                    x = y;
                    y = ans;
                }
                buf += ans + " ";
            }
            return buf;
        }
        public delegate string MassivNum(int[] a);
        #endregion

        #region Второе первое :
        public static string CurTime()
        {
            return DateTime.Now.ToString();
        }
        public static string CurDate()
        {
            return DateTime.Today.ToString();
        }
        public static string CurDay()
        {
            DateTime dt = DateTime.Now;

            return dt.DayOfWeek.ToString();
        }
        public delegate string CurTimeFunc();


        public static int S_Triangle(int shirina, int visota)
        {
            return ((shirina * visota) / 2);
        }
        public static int S_Rectangle(int shirina, int visota)
        {
            return shirina * visota;
        }
        public delegate int Square(int shirina, int visota);

        #endregion
        static void Main(string[] args)
        {
            int[] buf = new int[7] { 1, 2, 3, 4, 5, 7, 11 };
            MassivNum masiv_funkzya = new MassivNum(Parnie);
            masiv_funkzya += Neparnie;
            masiv_funkzya += Unkalnie;
            masiv_funkzya += Fibanachi;
            foreach (MassivNum item in masiv_funkzya.GetInvocationList())
                Console.WriteLine(item(buf) + "\n");
        }
    }

}