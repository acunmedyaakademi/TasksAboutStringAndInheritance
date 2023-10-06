using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Car
    {
        //public her yerden erişebilmesi için tanımlanan, genel bir erişim belirtecidir.
        private string color;
        private string name;
        private int maxSpeed;
        private int yearOfModel;
        private int currentSpeed;
        private string vehicleIdentificationNumber;

        public Car(string name, string color, int maxSpeed, int yearOfModel)        //Constructor method'un görevi bir nesneyi ilk kullanıma hazırlamaktır. Basitçe bu sınıftan üreteceğimiz nesnelerin hangi özelliklere sahip olacağını belirleriz.
        {                                                                             
            this.Name = name;                                                       //Cunsructor'daki name değişkeninin değerini aşağıda yazdığımız Name isimli getter-setter methoda atar.
            this.Color = color;                                                     //Cunsructor'daki color değişkeninin değerini aşağıda yazdığımız Color isimli getter-setter methoda atar.
            this.MaxSpeed = maxSpeed;
            this.YearOfModel = yearOfModel;
        }

        public void speedLimitAlert()         
        {
            if (currentSpeed > 140)                                                //currentSpeed, 140'tan büyük ise
            {
                Console.WriteLine(name + " Fazla Hızlı Gidiyorsunuz!");            //Fazla Hızlı Gidiyorsunuz! yaz.
            }
            else
            {
                Console.WriteLine(name + " Hızın Normal");                         //Değilse Hızın Normal yaz.
            }
        }
        
        public void fullThrottle()   // method
        {
            Console.WriteLine("The car is going as fast as it can!");              //Method çağırıldığında The car is going as fast as it can! yaz.
        }

        public string Color                                                        // color değişkenini kapsüllemek için private tanımlarız. Böylece kullanıcı direkt olarak değişkene erişemez.
                                                                                   // Değişkene erişmek için bu methodlar çağırılır ve method çerçevesinde işlem yapmaya izin verir.
        {
            get { return color; }                                                  // get method
            set { color = value; }                                                 // set method
        }

        public string Name                                                         // name değişkenini kapsüllemek için private tanımlarız. Böylece kullanıcı direkt olarak değişkene erişemez.
        {
            get { return name; }                                                   // get method
            set { name = value; }                                                  // set method
        }

        public int MaxSpeed                                                        // maxSpeed değişkenini kapsüllemek için private tanımlarız. Böylece kullanıcı direkt olarak değişkene erişemez.
        {
            get { return maxSpeed; }                                               // get method
            set                                                                    // set method
            {
                if(value > 500)                                                    // Eğer kullanıcının girdiği değer 500'den büyükse
                {
                    Console.WriteLine(Name + "Yanlış Değer!");                     //"Yanlış Değer!" yaz ve kullanıcının girdiği değeri değişkene atama!
                }
                else
                {
                    maxSpeed = value;                                              //Değilse kullanıcının girdiği değeri değişkene ata.
                }
            } 
        }

        public int YearOfModel                                                     // yearOfModel getter-setter
        {
            get { return yearOfModel; }                                            // get method
            set { yearOfModel = value; }                                           // set method
        }

        public int CurrentSpeed                                                   // currentSpeed 
        {
            get { return currentSpeed; }                                          // get method
            set { currentSpeed = value; }                                         // set method
        }

        public string VehicleIdentificationNumber                                 // vehicleIdentificationNumber 
        {
                                                                                  
            set                                                                   //setter
            {
                
                if (value.Length != 15)                                           //Eğer kullanıcının girdiği değer 15 elemanlı değilse
                {
                    Console.WriteLine("Hatalı Giriş!");                           //"Hatalı Giriş!" mesajı yaz ve kullanıcının girdiği değeri değişkene atama!
                }
                else
                {
                    vehicleIdentificationNumber = value;                          //Değilse kullanıcının girdiği değeri değişkene ata.
                }

            }  // set method
            get
            {
                try                                                                           //setter method'da istediğimiz kurallara uymazsa değişkene değer atamıyoruz. 
                                                                                              //Bu yüzden boş değişkeni yazdırmaya çalışırken hata alıyoruz.
                {
                    string star = "***********";                                               //try kod bloğu içindekileri çalıştırmayı dene
                    string lastFourNumber = vehicleIdentificationNumber.Substring(11);
                    //Console.WriteLine("***********" + lastFourNumber);
                    return star + lastFourNumber;
                }
                catch (Exception e)                                                            //Hata alırsan
                {
                    Console.WriteLine("Şase Numarası Okunurken Hata Oluştu!" + e.Message);     //"Şase Numarası Okunurken Hata Oluştu!" mesajını yaz ve null değer döndür!
                    return null;
                }              
            }
        }
    }
}
