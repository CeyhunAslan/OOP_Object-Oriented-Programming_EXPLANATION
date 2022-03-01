using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface_Arayuz.Business.Interface
{
    //Interfacelerin baş harfi herzaman "I" olarak tanımlanmalıdır. Bu bir best practice'dir.
   public interface IEraserRepository
    {
        //Interface içerisine yazılan tüm üyeler override edilmeye zorunludur. Bir başka değiş ile alt sınıflarda implement edilmeye zorunludur. Bu bakımdan interface için tam bir kural koyucudur. Yani alt sınıf ile üst sınıf arasında sözleşme imzaladık diyebiliriz.
        //Interfaceler içerisinde kodlama yapılamazdı. C# yeni versiyonlarında bu yapı değiştirildi.

        //Iterface'nin kendisi ve üyeleri public olmalıdır. Zaten override edileceği için private işaretlemeye çalışmak mantıksızca olurdu.

        //Static işaretlenemezler, static üye barındıramazlar. Sınıfın kendisi static işaretlenemez ama C# yeni versiyonlarında static üye barındırmaya başladılar.

        //Virtual olarak işaretlenemezler. Ne sınıfın kendisi nede üyeleri

        //Interface'leri tercih etmemizdeki diğer bir husus ise tam olarak buradaki kullanılma nedenidir. C# developer'ları çoklu kalıtıma sıcak bakmamışlardır. Yani C# direk olarak çoklu kalıtımı destekleyen bir programlama dili değildir. C#'da çoklu kalıtımı temin etmek için interface'ler kullanılmaktadır. 
        void Eraser(GroupBox groupBox);
      


    }
}
