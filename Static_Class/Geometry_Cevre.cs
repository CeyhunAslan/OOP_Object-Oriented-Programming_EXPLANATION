using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Class
{
    internal  static class Cevre
    {
        //Statik sınıfların örneklemi (instance) çıkarılmaz. Bu yüzden örneklam olma maliyetinden kurtulmuş olursunuz. Burada örnek mailiyetinden kastımız yaratılan sınıfların başlatıldığında (initilize) edildiğinde yani constructor tetiklendiğinde RAM'de yaratılması konusundur.

        //Static sınıfların kullanımı çok basittir. Statik sınıf içerisine yazılan bir üyeye erişmek istediğimizde "class_name"+ "." + "member_name" olarak erişebiliriz.
        //Yani sınıfın örneklemini almak "Sınıf sınıf = new Sınıf();" dediğimiz'de Sınıf classı içindeki tüm elemnaları çağırmış oluruz ama static classlar bize hangi üye ile işimiz varsa onun çağırmamız sağlar.


        //Statik sınıfları kullanım amacımız spesifik bir işi yapmka için öbeklenmiş methodlar kümesidir diyebilir. Örneğin C# içerisinde gömülü olarak bulanan "Math" statik sınıfı. Bu sınıfın tek bir amaca hizmet eder. Matematik işlemleri yaparken kullanacağımız methodları bize temiz etmesi. Başka hiç bir işi yoktur. İhtiyacımız olan matematiksel işlemi instance çıkarmadan pratik bir biçimde kullanabiliriz.Başka bir örnek vericek olursak Geometri alan / çevre  hesaplama gibi bir işe uygun static classlarımıuz......


        //Statik sınıflar kalıtım vermezler kalıtım almazlar. Ama burada istisnai bir durum vardır. Her sınıfın üst bilgilerini tutan yani onun sınıf olduğunu belirten bir meta sınıf vardır System.Object. C# bütün sınıflar bu sınıftan kalıtım alırlar. Ama bu durum dışında statikler kesinlikle kalıtım almazlar kalıtım vermezler. Tek bir amaçları vardır iş yapmak.


        //Statik sınıflar içerisinde sabitlerimizi tanımlayabilir.
        public const double PI = 3.1414;
      
       
        public static double Kare(double a)
        {
            double sonuc = a * 4;
            return Math.Round(sonuc);
        }

        public static double DikDörtgen(double a , double b)
        {
            double sonuc = 2* (a + b);
            return Math.Round(sonuc);
        }
        public static double Ucgen(double a , double b , double c)
        {
            double sonuc = a + b + c;
            return Math.Round(sonuc);
        }
        public static double ParalelKenar(double a , double b)
        {
            double sonuc = 2*(a+b);
            return Math.Round(sonuc);
        }
        public static double Eskenar(double a)
        {
            double sonuc = 4 * a;
            return Math.Round(sonuc);
        }
        public static double Daire(double r)
        { 
            double sonuc = (2*PI*r);
            return Math.Round(sonuc);
        }

        public static double Yamuk(double a, double b, double c, double d)
        { 
            double sonuc = a + b + c + d;
            return Math.Round(sonuc);
        }
        public static double Elips(double a , double b)
        {
            double hesap = (Math.Pow(a, 2) + Math.Pow(b, 2));
            double hesap2 = 0.5 * hesap;
            
            
            double karekok = Math.Sqrt(hesap2);
            double pı = 2 * PI;
            double sonuc = pı * karekok;
            return Math.Round(sonuc);
        }

        


    }
}