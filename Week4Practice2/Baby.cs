using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Week4Practice2
{
    public class Baby
    {
        private string _name;
        private string _lastName;
        private DateTime _dateTimeBirth;
        
        public Baby()                                   //Parametre almayan bir ctor
        {
            Inga();
            Console.WriteLine(_dateTimeBirth = DateTime.Now); 
        }

        public Baby(string name, string lastName)                       //Parametreli ctor
        {
            _name = name;
            _lastName = lastName;
            _dateTimeBirth = DateTime.Now;                              //datetimebirth o anki tarih değerini alır
            Inga();

        }


        public string Name 
        {
            get {  return _name; }
            set {  _name = value; }
        }

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        public DateTime DateTimeBirth
        {
            get { return _dateTimeBirth; }
            set { _dateTimeBirth = value; }
        }

        public void InfoBaby()                  //bilgileri yazdırmak için oluşturulan metot
        {
            Console.WriteLine("İsim : " +_name + " Soyisim : "  +_lastName + " " + " Doğum tarihi : " +_dateTimeBirth);
        }

        public void Inga()                      //Ağlama metodu
        {
            Console.WriteLine("Ingaaa");
        }
    }
}
