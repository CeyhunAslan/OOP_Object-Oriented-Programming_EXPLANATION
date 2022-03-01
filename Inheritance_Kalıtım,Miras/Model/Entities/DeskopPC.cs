using Inheritance_Kalıtım_Miras.Model.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Kalıtım_Miras.Model.Entities
{ //DeskopPc sınıfımızız BaseComputer.cs sınıfından miraz almıştır. DeskopPC.cs sınfı artık BaseComputer.cs sınıfının tüm özelliklerine sahiptir.bu sınıfta sadece DestopPC'nın ömzellikleri olacak
    internal class DeskopPC:BaseComputer
    {
        public string Monitör { get; set; }
        public string Kulaklık { get; set; }
        public string Klavye { get; set; }
        public string Mouse { get; set; }


        public override string PcOpen() //Burada base classımda virtula işaretli fonksiyonumu burada kullanımı istediğim gibi ezdim 
        {
            return "Deskop PC açıldı...!!!";
        }
    }
}
