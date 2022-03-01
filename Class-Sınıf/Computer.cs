using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Sınıf
{
    public class Computer
    {
        //Access Modifier : türkçe karşılığı erişim belirteçleridir. Bir nesnenin erişim seviyesini bizlere belirlme imkanı sunar.
        //public (Genel): Tüm Solution'da Erişilebilir demek
        //infernal (İçsel):Aynı program içerisinden erişilebilir, fakat farklı bir program içerisinden erişilemez durumdadır. Program içerisinde herhangi bir kısıtlaması yoktur.
        //Protected (Korunumlu) :Kod içinde bir değerin protected olarak tanımlanması; o değere, bulunduğu class  ve ondan türetilen diğer sınıflar içinden erişilebilir olduğunu göstermektedir. Protected; bir anlamda, public ve private erişim belirleyicilerinin birleşimi olarak görülebilmektedir.
        //Private (Gizli) :Bir değerin private olarak tanımlanması demek, o değişkene sadece kendi class’ı içinden ulaşılabileceği anlamına gelmektedir.


        //Burada biz bir bilgisayar nesenesi yaratmak istiyoruz. Yaratmak istediğimiz bu nesnenin ilk önce prototipini oluşturmak için Computer adında bir class oluşturduk.Bilgisayarın sahipliklerini yada yeteneklerini bilgisayar classımızda yaratıyoruz.


        //bir sınıfın üyesine herhangi bir access modifier ile işaretlenmez ise default olarak "private" atanır. 
        //Nesne Nedir? 
        //Verileri saklayan ve bu veriler üzerinde işlem yapan metodları saklayan bileşenlerdir.(Porpertler)

        public string CPU { get; set; }
        public string DisplayCard { get; set; }
        public string Motherboard { get; set; }
        public string RAM { get; set; }
        public string Case { get; set; }
        public string PSU { get; set; }

        //Form1.cs döndüğümüzde artık örneklem üzerinden public olan üyelere erişip değer atayabileceğiz.

        //Not: Bir sınıfın access modifier belirtilmez ise defult olarak internal işaretlenir. Bir sınıfı public access modifer ile işaretlersek üyeleri otomatik olarak public olmaz. Çünkü sınıf içerisinde bazı üyeleri dış erişiem kapatmak isteyebiliriz. 

    }
}
