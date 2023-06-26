using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace donguler_while_foreach
{
    class Program
    {
        static void Main(string[] args)
        {
           //while 
           // 1 den baslayarak console dan girilen sayıya kadar (sayı dahil) ortalama hesaplayıp console a yazdıran program.

            //Console.Write("Lutfen bir sayi giriniz:");
            //int sayi = int.Parse(Console.Readline());
            //int sayac = 1;
            //int toplam = 0;
            //while (sayac <= sayi)
            //{
                //toplam += sayac;
                //sayac ++;
            //}  

            //Console.WriteLine(toplam/sayi);

            // 'a' dan 'z' ye kadar tüm harfleri console a yazdır.

            //char character = 'a';
            //while (character < 'z')
            //{
                //Console.Write(character);
                //character ++;
            //}

            Console.WriteLine("******* FOREACH *******");
            string[] arabalar = {"BMW","TOYOTA","MERCEDES","AUDİ"}

            foreach (var araba in arabalar)
            {
                Console.WriteLine(araba);
            }

        }
    }
}
