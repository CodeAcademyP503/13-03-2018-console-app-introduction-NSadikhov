using System;

namespace tapsiriq
{
    class Program
    {
        static void Main(string[] args)
        {
            //////-----Tapsiriq_1-----//////
            //Console.Write("Deyeri girin: ");
            //int hesabla = 1;
            //var eded = Convert.ToInt32(Console.ReadLine());

            //while (eded >= 10)
            //{
            //    eded /= 10;
            //    hesabla++;

            //}
            //Console.WriteLine(hesabla + "-reqemlidir");
            //Console.Read();


            //////-----Tapsiriq_2-----//////
            //Console.Write("deyeri girin: ");
            //int n = Convert.ToInt32(Console.ReadLine());
            //int sum = 0;
            //while (n != 0)
            //{
            //    sum += n % 10;
            //    n /= 10;
            //}
            //Console.WriteLine(sum);
            //Console.Read();


            //////-----Tapsiriq_3-----//////
            //Console.Write("ifadeni girin: ");
            //string ifade = Console.ReadLine();
            //string sait = "", samit = "";

            //ifade = ifade.ToLower();

            //int sayi = ifade.Length;

            //for (int i = 0; i <= sayi - 1; i++)

            //{

            //    char herf = Convert.ToChar(ifade.Substring(i, 1));

            //    if (herf == 'a' || herf == 'i' || herf == 'o' || herf == 'u' || herf == 'e')

            //    {

            //        sait += herf + "-";

            //    }

            //    else

            //    {

            //        samit += herf + "-";

            //    }

            //}
            //Console.WriteLine("saitler: " + sait);
            //Console.WriteLine("samitler: " + samit);
            //Console.Read();


            //////-----Tapsiriq_4-----//////
            //Console.Write("Cumleni yazin: ");
            //string str = Console.ReadLine();
            //string[] cumle = str.Split(' ');
            //foreach (string soz in cumle)
            //{
            //    Console.WriteLine(soz);
            //}
            //Console.Read();


            //////-----Tapsiriq_5-----//////
            //List<string> keywords = new List<string>() { "Tenbel", "Kod yazmayan", "Yola Veren", "Esneyen", "Bekar" };
            //string cumle = Console.ReadLine();
            //for (int i=0;i<keywords.Count; i++)
            //{
            //    bool a = cumle.Contains(keywords[i]);

            //    if (a == true)
            //    {
            //        Console.WriteLine("Siz losersiniz");
            //    }
            //}
            //Console.Read();


            ////-----Tapsiriq_6-----//////
            //string str = Console.ReadLine();

            //str = str.Replace("tenbel", "loser");
            //Console.WriteLine(str);
            //Console.Read();


            ////-----Tapsiriq_7-----//////
            //List<int> integer = new List<int>() { 100, 50, 20, 10, 5, 1 };
            //List<string> word = new List<string>() { "Yuzluk", "Ellilik", "Iyirmilik", "Onluq", "Beslik", "Birlik" };
            //Console.Write("Ededi yazin: ");
            //var eded = Convert.ToInt32(Console.ReadLine());
            //for (int i = 0; i < integer.Count; i++)
            //{
            //    if (eded >= integer[i])
            //    {
            //        var reqem = eded / integer[i];
            //        eded -= reqem * integer[i];
            //        Console.WriteLine(reqem + "-" + word[i]);
            //    }
            //}
            //Console.Read();
        }
    }
}
