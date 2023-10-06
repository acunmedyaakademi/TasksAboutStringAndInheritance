using System;
using System.Collections.Generic;
using System.IO.MemoryMappedFiles;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car corolla = new Car("Corolla", "Mavi", 700, 2001);                                                                        //Car sınıfından corolla adında nesne ürettik
            Car mercedes = new Car("Mercedes", "Siyah", 195, 2005);                                                                     //Car sınıfından mercedes adında nesne ürettik.
            
            Console.WriteLine("Corolla :   " + corolla.Color + " | " + corolla.MaxSpeed + " | Model Yılı : " + corolla.YearOfModel);    //Corolla nesnesinin belirlenen özellikleri getter methoduyla ekrana basıldı.
            Console.WriteLine("Mercedes : " + mercedes.Color + " | " + mercedes.MaxSpeed + " | Model Yılı : " + mercedes.YearOfModel);  //Mercedes nesnesinin belirlenen özellikleri getter methoduyla ekrana basıldı.

            corolla.CurrentSpeed = 100;                                            //Corolla nesnesinın currentSpeed değişkenine setter method'u ile değişken atandı.
            mercedes.CurrentSpeed = 280;                                           //Mercedes nesnesinın currentSpeed değişkenine setter method'u ile değişken atandı.

            corolla.speedLimitAlert();                                             //speedLimitAlert method'u çağırıldı.
            mercedes.speedLimitAlert();                                            //speedLimitAlert method'u çağırıldı.

            corolla.VehicleIdentificationNumber = "54685848";                      //Corolla nesnesinın vehicleIdentificationNumber değişkenine setter method'u ile değişken atandı.
            mercedes.VehicleIdentificationNumber = "879879545687423";              //Mercedes nesnesinın vehicleIdentificationNumber değişkenine setter method'u ile değişken atandı.    

            Console.WriteLine(corolla.VehicleIdentificationNumber);                //Corolla nesnesine atanan vehicleIdentificationNumber getter ile yazdırılmaya çalışıldı.Setter'daki kurallara uymadığı için hata alıp mesaj verdi.
            Console.WriteLine(mercedes.VehicleIdentificationNumber);               //Mercedes nesnesinin vehicleIdentificationNumber değişkeni şifreli şekilde getter ile ekrana basıldı.

            SuperCar superCar = new SuperCar("Honda", "Beyaz", 450, 2023, 45);     //SuperCar sınıfından superCar adında nesne üretildi
            Console.WriteLine(superCar.MaxSpeed);                                  //SuperCar nesnesinin maxSpeed değişkeni getter ile ekrana basıldı.

            Console.ReadLine();
        }

        
    }

}
