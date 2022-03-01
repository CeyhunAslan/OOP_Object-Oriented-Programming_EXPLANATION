using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_ÇokBicimlilik
{
    internal interface IBase
    {
        // Polymorphism : programımızda oluşan bir nesne yapısının birbirinden farklı nesneler şeklinde davranmasını sağlayan yapı olarak cevaplayabiliriz.

        //Projelerimizde kurmuş olduğumuz yapılara esneklik sağlar ve farklı yapıdaki işlemler ile arasındaki bağlantı ilişkilerini azaltarak daha güvenli bir hale getirir.
        //Kod yapımızın tekrarlayan bir şekilde yazılmasının minimum seviyeye indirerek projelerimizin okunabilirlik oranında artış sağlamasına yardımcı olur.
        //Polymorphism yapısı kullandığımız projelerimizde almış olduğumuz hatayı tek bir yapı içerisinde çözüme ulaştırma kolaylığı bulunur.

        //Aşağıdaki yapımı miras/kalıtım yolula alt sınıflarımda o sınıfa uygun bir işlem yapması için değiştiricem Bu işleme polymorhism denir. 
        string CallSound();
    }
}
