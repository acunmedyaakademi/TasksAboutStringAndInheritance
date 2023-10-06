using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringFunctions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "Bu bir string  ";
            string s1 = " fonksiyonları, bir denemesidir.  ";
            string s2 = string.Concat(s, s1);
            string[] trySplit = s2.Split(',');
            string[] tryJoin = { "Acun", "Medya", "Akademi" };

            Console.WriteLine("s : " + s);
            Console.WriteLine("s1 : " + s1);
            Console.WriteLine("s2 : " + s2 + "\n\n\n");
            Console.WriteLine("s string'inin boyutu : " + s.Length);                                              //String Boyutunu Verir.
            Console.WriteLine("s + s1 : " + string.Concat(s, s1));                                                //String'leri birleştirmek için kullanılır.
            Console.WriteLine("s string'inin her elemanı büyük harf : " + s.ToUpper());                           //String'in her elemanını büyük harf yapar.
            Console.WriteLine("s string'inin her elemanı küçük harf : " + s.ToLower());                           //String'in her elemanını küçük harf yapar.
            Console.WriteLine("s2 string'inin 14. elemanı ve devamını göster : " + s2.Substring(14));             //String değerin belirli bir parçasını almamızı sağlar.
            Console.WriteLine("s2 string'inde 'yon' ara ve index döndür : " + s2.IndexOf("yon"));                 //String ifadenin içerisinde arama yapar ve index sayısını verir.
            Console.WriteLine("s2 string'inde 'yan' ara ve index döndür : " + s2.IndexOf("yan"));                 //String'in içerisinde aradığımız ifade yoksa -1 değeri döner.
            Console.WriteLine("s2 string'inde 'bir' ara ve index döndür : " + s2.IndexOf("bir"));
            Console.WriteLine("s2 string'inde son 'bir'i ara ve index döndür : " + s2.LastIndexOf("bir"));        //Eşleşmenin bulunduğu en son index numarası alınır.
            Console.WriteLine("s1 'de' içeriyor mu? : " + s1.Contains("de"));                                     //Değişken içerisinde arama yapar ve boolean(true-false) değer döndürür.
            Console.WriteLine("s string'i 'str' ile mi başlıyor? : " + s.StartsWith("str"));                      //İfadenin belirtilen değer ile başlayıp başlamadığını kontrol eder.
            Console.WriteLine("s string'i 'Bu' ile mi başlıyor? : " + s.StartsWith("Bu"));                        //True - False değer döndürür.
            Console.WriteLine("s string'i 'ing' ile mi bitiyor? : " + s.EndsWith("ing"));                         //İfadenin belirtilen değer ile bitip bitmediğini kontrol eder.
            Console.WriteLine("s string'i 'str' ile mi bitiyor? : " + s.EndsWith("str"));                         //True - False değer döndürür.
            Console.WriteLine("s1 string'inde ',' leri boşluk ile değiştir : " + s1.Replace(",", string.Empty));  //Değerdeki belirli karakterleri değiştirir.
            Console.WriteLine("trySplit dizisinin 0. elemanı : " + trySplit[0]);                                  //Değerdeki belirli karakterden yazıyı parçalar.
            Console.WriteLine("trySplit dizisinin 1. elemanı : " + trySplit[1]);
            Console.WriteLine("s1 stringinin başındaki boşlukları sil : " + s1.TrimStart());                      //Değerin başındaki boşlukları siler.
            Console.WriteLine("s stringinin başındaki ve sonundaki boşlukları sil : "  + s.Trim());               //Değerin hem başındaki hem sonundaki boşlukları siler.
            Console.WriteLine("s1 stringinin sonundaki boşlukları sil : " + s1.TrimEnd());                        //Değerin sonundaki boşlukları siler.                                                       
            Console.WriteLine("tryJoin dizisinin elemanları arasına ',' ekle : " + string.Join(",", tryJoin));    //Dizideki değerler arasına virgül ekler.
            Console.WriteLine("s string'inin elemanları arasına ',' ekle (Çalışmaz!) : " + string.Join(",", s));
            Console.WriteLine("tryJoin dizisinin elemanlarını alt alta göster : " + string.Join("\n", tryJoin));  //Dizideki elemanları alt alta ekler.

            //Format - Değerleri farklı formatta görüntülemek için kullanılır.

            decimal showTl = 10.5m;
            int showDecimal = 15;
            decimal showScientificFormat = 15000m;
            decimal showFloat = 15.5m;
            decimal showMonetary = 15000000m;
            int showHexadecimal = 450;
            decimal show0 = 15.5m;
            decimal show1 = 15.551m;

            Console.WriteLine("C : " + String.Format("{0:C}", showTl));
            Console.WriteLine("D : " + String.Format("{0:D3}", showDecimal));
            Console.WriteLine("D : " + String.Format("{0:D5}", showDecimal));
            Console.WriteLine("E : " + String.Format("{0:E}", showScientificFormat));
            Console.WriteLine("F : " + String.Format("{0:F1}", showFloat));
            Console.WriteLine("F : " + String.Format("{0:F2}", showFloat));
            Console.WriteLine("F : " + String.Format("{0:F3}", showFloat));
            Console.WriteLine("N : " + String.Format("{0:N}", showMonetary));
            Console.WriteLine("X : " + String.Format("{0:X}", showHexadecimal));
            Console.WriteLine("0 : " + String.Format("{0:000000.00}", show0));
            Console.WriteLine("# : " + String.Format("{0:###.##}", show1));

            var vocable = "yazılım";
            int indexof = vocable.IndexOf('ı', 2, 4);
            Console.WriteLine("indexOf-5 örneği: " + indexof);

            Console.ReadLine();
        }
    }
}
