using Inheritance_Kalıtım_Miras.Model.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Kalıtım_Miras.Model.Entities
{//Laptop sınıfım zaten BaseComputer ana clasımdan kalıtım aldığı için her bilgisayarda olan işelemci anakart ve ekran kartı gibi özelliklere zaten sahip kendisin ilgilendiren özellikleride kendi içine yazılır.
    internal class Laptop:BaseComputer
    {
        public string Sogutucu { get; set; }
        public string Adaptör { get; set; }


        public override string PcOpen()//Burada base classımda virtula işaretli fonksiyonumu burada kullanımı istediğim gibi ezdim 
        {
            return "Laptop PC Açıldı";
        }
    }
}
