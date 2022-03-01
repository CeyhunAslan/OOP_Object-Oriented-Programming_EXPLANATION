
using Interface_Arayuz.Business.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface_Arayuz.Business.Concrete
{
    public class Methods_Functions : IEraserRepository, IAgeRepository
    {
        //C#'da bir sınıf sadace bir tane tane sınıftan kalıtım almaktadır. Şayet mimarimizde bir sınıf birden fazala atadan kalıtım alması gereken bir durum ortaya çıkarsa burada olduğu gibi interfaceleri kullanmak zorundayız.
        //Burada Methods_Functions sınıfı IAgeRepository sınıfınlarından kalıtım almaktadır. Bu demek oluyorki Methods_Functions artık başka bir sınıftan kalıtım alamaz. Bu durumda interface devreye girmektedir. Aşağıda görüldüğü gibi Methods_Functions IEraserRepository, 'den de kalıtım almaktadır. Böylelikle çoklu kalıtım temin edilmiştir.
        public int CalculateAge(string param)
        {
                string[] year = param.Split('/');
                int age = DateTime.Now.Year - int.Parse(year[2]);
                return age;
        }

        public void Eraser(GroupBox groupBox)
        {
            foreach (Control item in groupBox.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = String.Empty;
                }
            }
        }

   

    }
}
