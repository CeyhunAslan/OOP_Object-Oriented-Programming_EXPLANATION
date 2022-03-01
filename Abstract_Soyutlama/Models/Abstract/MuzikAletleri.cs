using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Soyutlama.Models.Abstract
{//C#'da soyutlama uygulamanın iki yolu vardır. Bunlar abstract sınıflar ve infterface'lerdir.

    //Bir sınıfı abstract keyword'ü ile işaretlersek sınıfı soyutlaştırmış oluruz.
    internal abstract class MuzikAletleri
    {
        //Uygulamalarımızda abstract ata sınıfları kullanmamızdaki birincil amaç kalıtım ile bir birlerine bağlanan yani birbirlerine referance veren sınıfları kendi aralarında gevşek bağlı (loose couple) bir şeklde kullanmaktır. Soyutlama loose couple sınıflar elde etmek için sadece birinci adımdır. Soyutlama kullanıyorum artık çok gevşek bağlı rahat extend edilebilir sınıflarım var diye düşünmeyin. Daha uyacağımız çok fazla prensip ve desen var. Dediğim gibi soyutlama sadece birinci adımdır.

        //Abstract sınıf kullanmadaki bir diğer amaç, ilgili soyut sınıftan kalıtım alan alt sınıflara kural koymaktır. Bu açıdan düşünecek olursak üst sınıflar ile alt sınıflar arasında sözleşme imzalıyoruz.

        //Soyut sınıfların amacı kalıtım vermektir. Soyut sınıflardan örneklem (instance) çıkarılmaz.

        //Abstract sınıflar static olarak işaretlenemezler. Çünkü static sınıflar kalıtım almazlar, kalıtım vermezler. Abstract sınıfların amacı kalıtım vermektir. 

        //Abstract sınıflar private olarak işaretlenemez. Çünkü amaçları kaltım vermektir.


        //Abstract olarak işaretlenmiş bir sınıftaki her hangi bir üyeyi abstract olarak işaretlersek bu üye alt sınıflarda override edilmek zorundadır. BU zorunluluk abstract sınıfların kural koyma özelliğinin kendisidir.
        public abstract string Sound(); //Not: abstract olarak işaretlenmiş method yada functionların gövdesi olmaz. Çünkü bu method yada fonksiyonlar alt sınıflarda görev ve yeteneklerini kazanacaktır.

        //Not: Override: Method yada fuction override etmek, onları alt sınıflarda farklı farklı kullanımlara hazrılamak demektir. Yukarıda abstract olarak işaretlenmiş "Sound()" fonksiyonum her bir alt sınıfta override edilerek, farklı farklı görevler icra edecektir. Override terimini türkçe kaynaklarda ezmek olarak geçmektedir.

        //Yukarıdaki bilgi ışığında düşünecek olursak zaten override edeceğim yani alt sınıflarda yetenek kazandıracağım bir methoda niye burada gövde kazandırayım değil mi?

        //Abstract bir sınıf içerisinde abstract olarak işaretlenmemiş üyeler override edilmeye zorunlu değildir. Bu özelliği ile abstract sınıfların concrete yani somut gibi davranabildiği ortaya çıkmaktadır.
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }

        //Buradaki virtual keyword'ü fonksiyonumuzu alt sınıflarda override edilebilir hale getirmektedir. Peki abstact olarak işaretlenmiş method'tan farkı nedir? Abstract olarak işaretlenmiş method override edilmeye zorunludur. Lakin virtual olarak işaretlenmiş method override edilmeye zorunlu değildir. Override edilebilme opsiyonuna sahiptir.
        public virtual string AkortEtmek()
        {
            //Buradaki düşünce şu, bütün müzik aletleri akort edilmez. Bu bağlamda AkortEtmek() foksiyonunu override edilmeye zorunlu tutmadık. Bazı alt sınıflarda ihtiyaç olabilir ve burada kazandığı yetenek ile kullanılabilinir. Kimi sınıflarda override edilerek farklı yetenek kaznadırılabilinir. Bu opsiyonu yüzünden abstact olarak işaretlemek yerine virtual olarak işaretledik. İhtiyaç varsa override edilecek yoksa edilmeyecek. Abstact işaretleseydim override edilemeye zorunlu olacaktı ve default bir yetenek veremeyecektim.
            return "Akort işlemi yapılmasına gerek yoktur..!";
        }
    }
}
