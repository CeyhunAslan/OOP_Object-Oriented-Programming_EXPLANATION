using Abstract_Soyutlama.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Soyutlama.Models.Concrete
{
    
    internal  class Gitar:MuzikAletleri
    {
        //MuzikAleti sınıfından kalıtım alan Gitar.cs sınıfı bize ilk etapta kızdı. Sakin bir şekilde hatının üzerine geldiğimde Sound() fonksiyonunu implement edilmediğininden ötürü kızdığını dördük. Bu hatayı düzeltmek için ata sınıftan gelen bu kuralı bu alt sınıfta uyguladık (implement). Ayrıca burada dikkat etmemiz gereken diğer bir husus ise override edilen methodun ihtiyacıma yönelik olarak yetenek kazandırılmasıdır.


        public override string Sound()
        {
            return "Gitar sesi..!";
        }

        //Gitar akort edilmesi gereken bir enstrüman olduğundan AkortEtmek() fonksiyonunu burada çağırıyorum. Bu fonksiyon bize bir yetenek ile gelecek var olan yeteneğini ezip ihityacıma göre bir yetenek kazandırıyorum.

        public override string AkortEtmek()
        {
            return "Gitar akort edildi..! Kullanıma hazır..!";
        }

        //Gitar sınıfının ihityacı olan spesikik özellik ve yetenekler burada yazılmalıdır.
        public string TelTuru { get; set; }

    }
}
