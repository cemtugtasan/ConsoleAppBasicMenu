using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA__Çalışma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int toplam = 0;
            Console.WriteLine("Restorana hoşgeldiniz. Lütfen seçmek istediğiniz katagoriyi tuşlayın.");
            bool devamMi = true;
            while (devamMi=true)
            {
                Console.WriteLine("1.Ana Yemekler\n2.içecekler\n3.tatlilar\n4.çıkış");
                char katagoriSecme = char.Parse(Console.ReadLine());
                
                switch (katagoriSecme)
                {
                    
                    case '1': 
                            Console.WriteLine("1.Iskender---40\n2.kebap---30\n3.Kıymalı Pide---25\n4.geri");
                            katagoriSecme = char.Parse(Console.ReadLine());
                        if (katagoriSecme == '1')
                        {
                            Console.WriteLine("Lütfen Adet girişi yapın.");
                            int adet = int.Parse(Console.ReadLine());
                            toplam += adet * 40;

                        }
                        else if (katagoriSecme == '2')
                        {
                            Console.WriteLine("Lütfen Adet girişi yapın.");
                            int adet = int.Parse(Console.ReadLine());
                            toplam += adet * 30;
                        }
                        else if (katagoriSecme == '3')
                        {
                            Console.WriteLine("Lütfen Adet girişi yapın.");
                            int adet = int.Parse(Console.ReadLine());
                            toplam += adet * 25;
                        }
                        else if (katagoriSecme == '4')
                        {
                            break;
                        }                       
                        else
                        {
                            Console.WriteLine("Lütfen geçerli bir giriş yapınız.");
                        }
                        
                        break;
                    
                    case '2':
                            Console.WriteLine("1.kola---10\n2.soda---8\n3.şalgam---5\n4.geri");
                            katagoriSecme = char.Parse(Console.ReadLine());
                
                        if (katagoriSecme == '1')
                        {
                            Console.WriteLine("Lütfen Adet girişi yapın.");
                            int adet = int.Parse(Console.ReadLine());
                            toplam += adet * 10;

                        }
                        else if (katagoriSecme == '2')
                        {
                            Console.WriteLine("Lütfen Adet girişi yapın.");
                            int adet = int.Parse(Console.ReadLine());
                            toplam += adet * 8;
                        }
                        else if (katagoriSecme == '3')
                        {
                            Console.WriteLine("Lütfen Adet girişi yapın.");
                            int adet = int.Parse(Console.ReadLine());
                            toplam += adet * 5;
                        }
                        else if (katagoriSecme == '4')
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Lütfen geçerli bir giriş yapınız.");
                        }
                        
                        break;


                    case '3':
                            Console.WriteLine("1.süpangle---20\n2.Çikolatalı kek---15\n3.dondurma---15\n4.geri");
                            katagoriSecme = char.Parse(Console.ReadLine());

                        if (katagoriSecme == '1')
                        {
                            Console.WriteLine("Lütfen Adet girişi yapın.");
                            int adet = int.Parse(Console.ReadLine());
                            toplam += adet * 20;

                        }
                        else if (katagoriSecme == '2')
                        {
                            Console.WriteLine("Lütfen Adet girişi yapın.");
                            int adet = int.Parse(Console.ReadLine());
                            toplam += adet * 15;
                        }
                        else if (katagoriSecme == '3')
                        {
                            Console.WriteLine("Lütfen Adet girişi yapın.");
                            int adet = int.Parse(Console.ReadLine());
                            toplam += adet * 15;
                        }
                        else if (katagoriSecme == '4')
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Lütfen geçerli bir giriş yapınız.");
                        }
                        
                        break;

                    case '4': Console.WriteLine($"Bizi seçtiğiniz için teşekkür ederiz\nHesabınız= {toplam} TL");

                             devamMi = false; break;

                }
                

            }

            Console.ReadKey();
        }
    }
}
