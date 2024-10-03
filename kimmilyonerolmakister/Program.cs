using System;

namespace kimmilyonerolmakister
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isTrue = true;
            bool isFalse = false;


            Console.WriteLine("Değer 1: " + isTrue);   // true
            Console.WriteLine("Değer 2: " + isFalse);  // false


            Console.WriteLine("Bir bilgi yarışması yapıyoruz!");
            Console.WriteLine("");
            Console.WriteLine("1 -> Kızınca Tüküren Hayvan Hangisidir?");
            Console.Write("A) Lama" + "  " + "B)Deve");
            Console.WriteLine("    ");
            Console.WriteLine("Sorunun cevabı nedir?");

            string cevap = Console.ReadLine().ToLower();
            bool soru1Dogru = false;

            if (cevap != null)
            {
                if (cevap == "a")
                    Console.WriteLine("Doğru Cevap Lama");
                soru1Dogru = true;
            }


            else if (cevap == "b ")
            {
                Console.WriteLine("Yanlış cevap: Doğru cevap Lama olacaktı.");
            }

            else
            {
                Console.WriteLine("geçersiz cevap");
            }



            Console.WriteLine("2 -> Dünya'ya en yakın gezegen hangisidir ?");
            Console.Write("A) Venüs" + "  " + "B) Mars");
            Console.WriteLine("    ");
            Console.WriteLine("Sorunun cevabı nedir?");
            string cevap2 = Console.ReadLine().ToLower();
            bool soru2Dogru = false;

            if (cevap2 != null)
            {
                if (cevap2 == "a")
                    Console.WriteLine("Doğru cevap Venüs");
                soru2Dogru = true;
            }


            else if (cevap2 == "b")
            {
                Console.WriteLine("Yanlış cevap: Doğru cevap Venüs olacaktı.");
            }

            else
            {
                Console.WriteLine("geçersiz cevap");
            }



            if (soru1Dogru && soru2Dogru)
            {
                Console.WriteLine("Tebrikler! İki soruyu da doğru cevapladınız. Yarışma burada sona erdi.");
                Console.WriteLine("1 Milyon TL'lik büyük ödülü kazandınız!");
                return;
            }

            Console.WriteLine("3 -> 5 * 2 + 8 / 2 - 2 işleminin sonucu kaçtır ?  ");
            Console.Write("A) 7" + "  " + "B) 12");
            Console.WriteLine("    ");
            Console.WriteLine("Sorunun cevabı nedir?");
            string cevap3 = Console.ReadLine().ToLower();

            if (cevap3 != null)
            {
                if (cevap3 == "a")
                    Console.WriteLine("Yanlış cevap: Doğru cevap 12 olacaktı");
                else if (cevap3 == "b")
                    Console.WriteLine("Doğru cevap 12");
                else
                    Console.WriteLine("geçersiz cevap");

            }



















        }
    }
}






















