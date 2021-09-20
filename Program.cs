using System;
using System.IO;

namespace DizinProgramı
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"/Users/apple/Projects/1234/";

            DirectoryInfo directoryInfo = new DirectoryInfo(path);
            int turu;
            
            int deger;


            Console.WriteLine("Lütfen türünü giriniz.(txt=0  jpg=1)");
            turu = Convert.ToInt32(Console.ReadLine());

            try
            {
                if (turu == 0)
                {
                    Console.WriteLine("Lütfen byte olarak dosya boyutunu giriniz");
                    deger = Convert.ToInt32(Console.ReadLine());
                    foreach (var item in directoryInfo.GetFiles("*.txt"))
                    {
                        if (item.Length == deger)
                        {
                            item.Delete();

                        }

                      


                    }


                }

                else if (turu == 1)
                {
                    foreach (var item in directoryInfo.GetFiles("*.jpg"))
                    {


                        item.Delete();









                    }
                }

            }






            finally
            {

                Console.WriteLine("İşleminiz başarılı bir şekilde gerçekleştirilmiştir..");

            }
            Console.ReadKey();
        }
    }
            
}
