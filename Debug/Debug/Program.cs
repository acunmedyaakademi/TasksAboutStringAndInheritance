using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Debug
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Android kullanan kullanıcı sayısını giriniz : ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("iOS kullanan kullanıcı sayısını giriniz : ");
            int i = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("İos kullananların android kullananlara oranı : " + a / i);
        }
    }
}
