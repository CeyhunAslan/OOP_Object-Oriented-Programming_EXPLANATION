using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Constructor_Kurucu_Metot
{
    public  class Book
    {
        //Constrcutor : nesne yönelimli programlama kavramı içerisinde bulunan sınıf yapılarının nesne olarak tanımlanmasında alt yapıyı hazırlayan, kurucu rolü üstlenen, sınıf ismi ile aynı isime sahip olan, geriye değer döndürmeyen fonksiyon türleridir.

        //Projelerimiz içerisinde bazı tanımlamaları, sınıfı çağırırken gerçekleştirmek isteyebiliriz. Bu durumda çeşitli constructor metot tanımlamaları ile projemizin inşa sürecine müdahale edebiliriz.

        //C# Constructor tanımlaması yapacağımız zaman, yapıcı metodumuzun ismi ile sınıfımızın ismi aynı olmak zorundadır.

        //

        //Constrcutor shortcut ctor+tab+tab
        public Book()
        {
            //Bir sınıftan örneklem çıkardığımız zaman otomatik olarak tetiklenen yapıcı bir methodtur. Aslında sınıfımızı başlatmaya (initialize) yarar. Sınıfın örneklemi alındığında otomatik olarak tetiklenir ve ilgli sınıfı kullanıma hazır hale getirir. 

            // //İlk yaptığımız örnekte aslında constructor kullandık. Örneklem aldığımızda new anahtar sözcüğünün yanında ilgili sınıfın constructor çağırmıştık. Fark etmişsiniz di constrcutor'un ismi sınıf ile aynıdır.

            //Constructor çalışma mantığı itibariyle bize danışmadan sormadan, sınıftan örneklem alındığında kendi kendine tetiklenir ve üzerine atanmış görevleri icra eder. 

            MessageBox.Show("Yazılmış en iyi kitap Kralkatilli Güncesidir");

        }
        //Bir kez daha constructor açtığımızda bize ilk ettapta kızacaktır. Bunun nedeni aynı methodun birden fazla kez oluşturulamamasıdır. Normal method ve functionlarda olduğu gibi constructor'larımızıda overload ettiğimizde onu parametrelerinden ayırabiliyoruz.

        public Book(string parametre)
        {
            //2. constructor dışarıdan marka bilgisi alarak ilgili sınıfın Marka property'sine değer atayacak.
            //Constructor'ların bir diğer özelliği ise hızlıca değer atamasıdır. Bu özelliği vasıtasıyla dışarıdan gelen değeri otomatik olarka property'lere set edebilir. Yani sınıf initialize dilirken bu özellikler ile initilize edilsin diyebiliriz.

            parametre = "Centilmen Pıc Yazılmış En iyi 2.Kitaptır.";

            MessageBox.Show(parametre);
        }
    }
}
