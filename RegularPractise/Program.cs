using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegularPractise
{
    class Program
    {
        public static bool IsIp(string Ip)
        {
            Regex IsIp = new Regex(@"(((([2][0-5][0-5])|([0|1]*[0-9][0-9])|([0-9]))(\.)){3})(([2][0-5][0-5])|([0|1]*[0-9][0-9])|([0-9]))");          
            return IsIp.IsMatch(Ip);
        }
        public static int WovelCount(string str)
        {
            Regex WovelCount = new Regex(@"[aeiouyAEUOUY]");
            return WovelCount.Matches(str).Count;
        }
        public static bool IsURL(string Url)
        {
            Regex isURL = new Regex(@"^(https://)?([a-z])([a-z|\d]{2,32})(\.)[a-z]{2,3}");
            return isURL.IsMatch(Url);
        }
        public static bool IsDigitLetter(string str) {
            Regex isDL = new Regex(@"^[a-z-A-Z-0-9]+$");
            return isDL.IsMatch(str);
        }
        public static bool IsTime(string str)
        {
            Regex IsTime = new Regex(@"^(([0-1]([0-9])?)|[2][0-3]?):[0-5][0-9]$");
            return IsTime.IsMatch(str);
        }
        public static bool IsIndexUSA(string str)
        {
            Regex IsUSA = new Regex(@"\^[0-9]{4,5}$");
            return IsUSA.IsMatch(str);
        }
        static void Main(string[] args)
        {
            string str = "192.168.1.0";
            if (IsIp(str))
                Console.WriteLine(str + " True!");
            else Console.WriteLine(str + " False!");
            str = "192.168.1.0222";
            if (IsIp(str))
                Console.WriteLine(str + " True!");
            else Console.WriteLine(str + " False!");



            str = "aeiuirufhgruihgifeuore";
            Console.WriteLine("There are " + WovelCount(str) + " wovels!");

            str = "google.com";
            if (IsURL(str))
                Console.WriteLine(str + " True!");
            else Console.WriteLine(str + " False!");

            str = "1oogle.com";
            if (IsURL(str))
                Console.WriteLine(str + " True!");
            else Console.WriteLine(str + " False!");


            if (IsDigitLetter(str))
                Console.WriteLine(str + " True!");
            else Console.WriteLine(str + " False!");

            str = "&%&#$&%$";
            if (IsDigitLetter(str))
                Console.WriteLine(str + " True!");
            else Console.WriteLine(str + " False!");

            str = "12:35";
            if (IsTime(str))
                Console.WriteLine(str + " True!");
            else Console.WriteLine(str + " False!");

            str = "24:10";
            if (IsTime(str))
                Console.WriteLine(str + " True!");
            else Console.WriteLine(str + " False!");

            str = "99999";
            if (IsIndexUSA(str))
                Console.WriteLine(str + " True!");
            else Console.WriteLine(str + " False!");
            str = "0995";
            if (IsIndexUSA(str))
                Console.WriteLine(str + " True!");
            else Console.WriteLine(str + " False!");

        }
    }
}
