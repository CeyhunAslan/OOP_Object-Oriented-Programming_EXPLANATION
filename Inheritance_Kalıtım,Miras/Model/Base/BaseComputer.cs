using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Kalıtım_Miras.Model.Base
{
    //Kalıtım (Inheritance): Biyolojideki kalıtım ile yazılımdaki kalıtım aynı mantıkta çalışmaktadır. Biyolojide nasıl bizler ebeveylerimizden kalıtım yoluyla özellikler aldıysak yazılımda da aynı mantıkta ata sınıflardan alt sınıflara özelliklik kazandırıyoruz.

    //Kalıtım bizlere bir hiyerarşi ve düzen kazandırır. Sınıflardaki kod kalabalığını engeller. Bize yönetilebilir sınıflar yaratmamıza yardımcı olur.

    //Ata sınıfların üyelerini dizayn ederken bu sınıftan kalıtım alacak alt sınıfların özellikleri göz önünde bulundurulmalıdır. Sadece bir alt sınıfı ilgilendiren "x" bir özelliği ata sınıfa yazarsak, ata sınıftan kalıtım alan bütün alt sınıflara kalıtılmış olur. 
    internal class BaseComputer
    {
        // Kalıtım kullanım amacım Enitites 'deki sınıflarımın ortak özelliklerini burya sınıfların kendisine ise sadece kendi özelliklerini yazarak bağımlılığı azaltıyorum ortak özelliklerim base'de kendilerine ait çzelliklerim kendilerinde olmuş olur.  
        public string CPU { get; set; }
        public string DisplayCard { get; set; }
        public string Motherboard { get; set; }
        public string RAM { get; set; }
        public string Case { get; set; }
        public string PSU { get; set; }


        //Override: Ata sınıflarda bulunan methodların alt sınıflarda var olan yetenekleri dışında yetenekler yüklenmesidir. Bunu yaparken var olan yetenek ezilerek yeni yetenek kazandırılır.

        public virtual string PcOpen()//fonksiyonumuzu "virtual" olarak işaretlememizdeki amaç onun override edileceğini belirtmemzdir. "virtual" işaretlemeseydim override edemezdim.
        {
            return "Pc Açıldı";
        }
    }
}
