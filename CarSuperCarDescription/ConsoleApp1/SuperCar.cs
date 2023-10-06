using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class SuperCar : Car   //SuperCar bir Sub Class'tır. Yani Car sınıfının değişkenlerini ve yöntemlerini miras alan bir alt sınıftır.
                                    //Süper sınıftan(Car Sınıfı) miras alabilme özelliğine sahiptir ve kendine has özellikler, metotlar da eklenebilir.
    {
        public SuperCar(string name, string color, int maxSpeed, int yearOfModel, int nosCount) : base(name, color, maxSpeed, yearOfModel)   //base Car sınıfının constructor'ıdır.
        {
            Console.WriteLine(nosCount);
        }
    }
}
