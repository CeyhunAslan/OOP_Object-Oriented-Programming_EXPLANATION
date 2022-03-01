using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation_Kapsülleme
{
    internal class Kapsülleme
    {//kapsülleme (Encapsulation) sayesinde nesneler bilinçsiz kullanımdan korunmuş olur. Fakat bazı durumlarda private field’ lara erişmemiz ve özelliklerini kullanmamız gerekebilir.Bu durumda Property kavramı devreye girer. Property bir field’ in değerini geri döndürmeye (Get) ve değerini ayarlamaya (Set) olanak sağlar.


        private int _boy;
        //Boy eksi (-) olamayacağı için encapsulation ile şartlandırıyorum 
        public int Boy
        {
            get { return _boy; }
            set
            {
                if (value < 0)
                { _boy = 0; }
                else
                { _boy = value; }
            }
        }

       // işe giriş yapılırken bu property capsulleme sayesinde o anı verir hale getiriyoruz ve müdahaleye kapatıyorum
        private DateTime _createDate = DateTime.Now;
        public DateTime CreateDate 
        {
            get {return _createDate; }
            set {_createDate = value; } 
        }

    }
}
