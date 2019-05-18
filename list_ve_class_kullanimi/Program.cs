using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace list_ve_class_kullanimi
{
    class Program
    {
        static void Main(string[] args)
        {
            customer c1 = new customer();
            c1.CustomerId = 1;
            c1.Name = "berkay";
            c1.Salary = 120;

            customer c2 = new customer();
            c2.CustomerId = 2;
            c2.Name = "filiz";
            c2.Salary = 90;

            List<customer> customers = new List<customer>();
            customers.Add(c1);
            customers.Add(c2);

            foreach (customer item in customers)
            {
                Console.WriteLine("id={0}, name={1}, salary={2} ", item.CustomerId, item.Name, item.Salary);
            }

            customer c3 = customers[0];

            Console.WriteLine(c3.Name);

            if (customers.Exists(cust => cust.Name.StartsWith("z")))
            {
                Console.WriteLine("içeriyor");
            }
            else
            {
                Console.WriteLine("z ile başlayan bir şey yok");
            }

            customer c4 = customers.Find(bul => bul.Salary > 100); // birden fazla değer için FindAll kullanılabilir.
            Console.WriteLine(c4.CustomerId); // 1 den fazla değer varsa hata vermez. ilkini gösterir.


            // FindAll 1 den fazla sınıf döndürüyor. Dönen sınıfları , customer tipinde bir list'e atıp, yazdırıyoruz.
            List<customer> ccc = customers.FindAll(fazlabul => fazlabul.Salary > 50);
            foreach (customer item in ccc)
            {
                Console.WriteLine("id={0}, name={1}", item.CustomerId, item.Name);
            }


            /*Aşağıdaki örnek güzel. Açıklaması altta.*/
         
            MyIntList x = new MyIntList();
            x.AddNumber(447);
            x.AddNumber(1991);
            x.AddNumber(2019);
            Console.WriteLine(x.GetNumber(0));

            /*
              Önce sınıfımızı x e attık.
              sonra x.addnumber metodu ile liste ekleme yaptık
              sonra getnumber metodu ile listteki değeri döndük.
            */


            Console.ReadLine();
        }
    }
}
