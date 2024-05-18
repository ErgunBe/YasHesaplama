using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yas_Hesaplama
{
    internal class Program
    {
        class kisi
        {
            public string adi, soyadi;
            int dYili;

            public int dogumyili
            {
                set 
                {
                    if (value < 1900)
                    {
                        Console.WriteLine("doğum yılı 1900 den küçük olamaz");
                        Console.Write("doğum yılınız: ");
                        dYili = Int32.Parse(Console.ReadLine());
                    }
                    else dYili = value;
                }
            }


             public int yasi
            {
                get 
                {
                    return 2023 - dYili;
                }
            }
        }
        static void Main(string[] args)
        {
            kisi kisi1 = new kisi();

            Console.Write("adınız: ");
            kisi1.adi = Console.ReadLine();

            Console.Write("soyadınız: ");
            kisi1.soyadi = Console.ReadLine();

            Console.Write("dogum yılınız: ");
            kisi1.dogumyili = Int32.Parse(Console.ReadLine());

            Console.Write("yaşınız: ");
            Console.WriteLine(kisi1.yasi);

            Console.ReadLine();
            
        }
    }
}
