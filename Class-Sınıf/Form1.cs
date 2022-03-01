using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Class_Sınıf
{
    public partial class Class : Form
    {
        public Class()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //List<string> sehirler = new List<string>();
            //Button btn = new Button();
            //Random random = new Random();

            //Yukarıda C# içerisinde gömülü olarak bulunan Button ve Random sınıflarından nesne ürettim. Yani bu sınıflardan örneklem çıkardık.
            //Bu işleme biz "instance" diyoruz.Classların erişilebilir properylerine erişmek için bir nesneye classı çağırıyoruz.


            //Aşağıda ise bizim oluşturudğumuz Computer sınıfından instance yani örneklem çıkartıyoruz. Zaten OOP bize bunu temin eder. Uygulamada ihtiyacımız olan nesneleri üretmek için oop kullanıyoruz.

            Computer computer = new Computer();
            //Computer sınıf'ımın tipinde computer isimli bir nesne yaratım ve new anahtar sözcüğü sayesinde cllasımın tüm özellilklerini computer 'de sahib.


            //yaratılan nesnenin özelliklerine erişek onlara değer atamak istediğimizde "instance_name" + "." operatörü ile erişiyoruz.

            computer.CPU = "Ryzen 5 3600";
            computer.RAM = "Patriot 8GB DDR4 3200MHz";
            computer.Motherboard = "Asus TUF B450-Pro";
            computer.DisplayCard = "MSI GTX 1650 Super";
            computer.Case = "MSI Mag 10M Vampriric";
            computer.PSU = "XPG 550W Bronze";


            //Yukarıda üretilen nesnenin sınıfında bulunan üyelerden public oldukları ve intance alındığı için erişim içlkerine  istediğimmiz verileri verdik 

            MessageBox.Show($"İşlmeci :{computer.CPU} \n RAM : {computer.RAM} \n Anakart : {computer.Motherboard} \n Ekran Kartı : {computer.DisplayCard} \n Kasa : {computer.Case} \n Güç Kaynağı: {computer.PSU} ");


        }
    }
}
