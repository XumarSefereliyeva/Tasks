using System.Runtime.ConstrainedExecution;

namespace Metodlara_qeder_tekrar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tapsiriq1();
            Tapsiriq2();
            Tapsiriq3();
            Tapsiriq4();
            Tapsiriq5();
            Tapsiriq6();
            Tapsiriq7();
            Tapsiriq8();
            Tapsiriq9();
            Tapsiriq10();
            Tapsiriq11();
            Tapsiriq12();
            Tapsiriq13();
            Tapsiriq14();
            Tapsiriq15();
            Tapsiriq16();
            Tapsiriq17();
            Tapsiriq18();
            Tapsiriq19();
            Tapsiriq20();
            Tapsiriq21();
            Tapsiriq22();
            Tapsiriq23();
            Tapsiriq24();
            Tapsiriq25();
            Tapsiriq26();
            Tapsiriq27();
            Tapsiriq28();
            Tapsiriq29();
            Tapsiriq30();
            Tapsiriq31();
            Tapsiriq32();

        }
        static void Tapsiriq1()
        {
            var number = 25;
            var number1 = 67;
            var sum = number + number1;

            Console.WriteLine("Cem:" + sum);
        }
        static void Tapsiriq2()
        {
            var number = 5;
            var kvadrat = number * number;

            Console.WriteLine("Ededin Kvadrati:" + kvadrat);
        }
        static void Tapsiriq3()
        {
            string name = "Xumar";
            int age = 20;

            Console.WriteLine("Salam, menim adim" + " " + name + "-dir" + " " + "ve menim" + " " + age + " yasim var.");
        }
        static void Tapsiriq4()
        {
            int a = 10;
            int b = 20;
            (a, b) = (b, a);

            Console.WriteLine("a:" + a);
            Console.WriteLine("b:" + b);
        }
        static void Tapsiriq5()
        {
            int number = 5;
            int number1 = 15;
            int number2 = 30;
            int sum = number + number1 + number2;
            int edediOrta = (number + number1 + number2) / 3;

            Console.WriteLine("Cem:" + sum);
            Console.WriteLine("Edediorta:" + edediOrta);
        }
        static void Tapsiriq6()
        {
            Console.WriteLine("Zehmet olmasa dordreqemli ededi daxil edin:");
            int number = int.Parse(Console.ReadLine());
            int sum = 0;
            int teklik = number % 10;
            int onluq = (number % 100) / 10;
            int yuzluk = (number % 1000) / 100;
            int minlik = number / 1000;
            sum = teklik + onluq + yuzluk + minlik;

            Console.WriteLine("Ededin reqemlerinin cemi:" + sum);
        }
        static void Tapsiriq7()
        {
            Console.WriteLine("Zehmet olmasa ededi daxil edin:");
            int number = int.Parse(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine("Cut ededdir");
            }
            else
            {
                Console.WriteLine("Tek ededdir");
            }
            static void Tapsiriq8()
            {
                Console.WriteLine("Ilk ededi daxil edin:");
                int number = int.Parse(Console.ReadLine());
                Console.WriteLine("Ikinci ededi daxil edin:");
                int number1 = int.Parse(Console.ReadLine());

                if (number > number1)
                {
                    Console.WriteLine("Ilk eded ikinciden boyukdur");
                }
                else
                {
                    Console.WriteLine("Ikinci eded boyukdur birinci ededden");
                }
            }
        }
        static void Tapsiriq8()
        {
            Console.WriteLine("Ilk ededi daxil edin:");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("Ikinci ededi daxil edin:");
            int number1 = int.Parse(Console.ReadLine());

            if (number > number1)
            {
                Console.WriteLine("Ilk eded ikinciden boyukdur");
            }
            else
            {
                Console.WriteLine("Ikinci eded boyukdur birinci ededden");
            }
        }
        static void Tapsiriq9()
        {
            Console.WriteLine("Ededi daxil edin");
            double number = double.Parse(Console.ReadLine());

            if (number == 0)
            {
                Console.WriteLine("Eded sifira beraberdir");
            }
            else if (number > 0)
            {
                Console.WriteLine("Eded musbetdir");
            }
            else
            {
                Console.WriteLine("Eded menfidir");
            }
        }
        static void Tapsiriq10()
        {
            Console.WriteLine("ededi daxil edin:");
            int number = int.Parse(Console.ReadLine());

            if (number % 15 == 0)
            {
                Console.WriteLine("Eded 3-e ve 5-e bolunur");
            }
            else
            {
                Console.WriteLine("Eded eyni zamanda  3-e ve 5-e bolunmur");
            }
        }
        static void Tapsiriq11()
        {
            Console.WriteLine("Ededi daxil edin:");
            int number = int.Parse(Console.ReadLine());

            if (number % 2 == 0 && number % 3 == 0)
            {
                Console.WriteLine("Eded 2-e ve 3-e bolunur");
            }
            else
            {
                Console.WriteLine("Eded eyni zamanda 2-e ve 3-e bolunmur");
            }
        }
        static void Tapsiriq12()
        {
            Console.Write("Zehmet olmasa  necenci ay lazimdirsa daxil edin:");
            int ay = int.Parse(Console.ReadLine());

            switch (ay)
            {
                case 1:
                    Console.WriteLine("Yanvar");
                    break;

                case 2:
                    Console.WriteLine("Fevral");
                    break;
                case 3:
                    Console.WriteLine("Mart");
                    break;
                case 4:
                    Console.WriteLine("Aprel");
                    break;
                case 5:
                    Console.WriteLine("May");
                    break;
                case 6:
                    Console.WriteLine("Iyun");
                    break;
                case 7:
                    Console.WriteLine("Iyul");
                    break;
                case 8:
                    Console.WriteLine("Avqust");
                    break;
                case 9:
                    Console.WriteLine("Sentyabr");
                    break;
                case 10:
                    Console.WriteLine("Oktyabr");
                    break;
                case 11:
                    Console.WriteLine("Noyabr");
                    break;
                case 12:
                    Console.WriteLine("Dekabr");
                    break;
                default:
                    Console.WriteLine("YANLIS AY QEYD ETDIZ");
                    break;

            }
        }
        static void Tapsiriq13()
        {
            Console.WriteLine("Qiymetinizi daxil edin:");
            int qiymet = int.Parse(Console.ReadLine());
            char symbol;

            if (qiymet >= 50)
            {
                Console.WriteLine('E');
            }
            else if (qiymet >= 60)
            {
                Console.WriteLine('D');
            }
            else if (qiymet >= 70)
            {
                Console.WriteLine('C');
            }
            else if (qiymet >= 80)
            {
                Console.WriteLine('B');
            }
            else if (qiymet >= 90)
            {
                Console.WriteLine('A');
            }
            else
            {
                Console.WriteLine("Kesildiniz");
            }
        }
        static void Tapsiriq14()
        {
            char symbol;
            Console.WriteLine("Ilk ededi daxil edin:");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("Ikinci ededi daxil edin:");
            int number1 = int.Parse(Console.ReadLine());
            Console.WriteLine(" istediyiniz emeliyyati daxil edin:");
            symbol = char.Parse(Console.ReadLine());


            switch (symbol)
            {
                case '+':
                    int toplama = number + number1;
                    Console.WriteLine("Cem:" + toplama);
                    break;
                case '_':
                    int cixma = number - number1;
                    Console.WriteLine("Cixma:" + cixma);
                    break;
                case '*':
                    int hasil = number * number1;
                    Console.WriteLine("Hasil:" + hasil);
                    break;
                case '/':
                    int bolme = number / number1;
                    Console.WriteLine("Bolme:" + bolme);
                    break;
            }
        }
        static void Tapsiriq15()
        {
            Console.WriteLine("Mebleginizi daxil edin:");
            int mebleg = int.Parse(Console.ReadLine());

            if (mebleg >= 100)
            {
                Console.WriteLine("Tebrikler 10% endirim qazandiniz " + "/" + "Mehsulun qiymeti:120 AZN . Odeyeceyiniz mebleg:108 AZN. (10% endirim tetbiq edildi)");
            }
            else if (mebleg >= 50 && mebleg <= 99)
            {
                Console.WriteLine("Tebrikler 5% endirim qazandiniz" + "/" + "Mehsulun qiymetti: 120 AZN .Odeyeceyiniz mebleg:114 AZN .(5% endirim tetbiq edildi)");
            }
            else
            {
                Console.WriteLine("Malesef endirim yoxdur");
            }
        }
        static void Tapsiriq16()
        {
            Console.WriteLine("Adinizi daxil edin:");
            string name = Console.ReadLine();
            Console.WriteLine("Parolunuzu daxil edin:");
            int password = int.Parse(Console.ReadLine());

            if (name == "admin" && password == 2222)
            {
                Console.WriteLine("Xosh gelmisiniz");
            }
            else
            {
                Console.WriteLine("Daxil ola bilmersiniz");
            }
        }
        static void Tapsiriq17()
        {
            Console.WriteLine("Meblegi daxil edin :");
            double mebleg = double.Parse(Console.ReadLine());

            Console.WriteLine("Pul vahidinizi daxil edin:");
            string pulvahidi = Console.ReadLine();
            double AZN;
            double USD;
            switch (pulvahidi)
            {
                case "AZN":
                    AZN = 0.59 * mebleg;


                    Console.WriteLine("Mebleginiz USD olaraq geri qaytarilir:" + AZN + "USD");
                    break;
                case "USD":
                    USD = 1.7 * mebleg;

                    Console.WriteLine("Mebleginiz AZN olaraq " + USD + "AZN");
                    break;
            }
        }
        static void Tapsiriq18()
        {
            float ceki;
            float boy;

            Console.Write("Ceki daxil edin: ");
            ceki = float.Parse(Console.ReadLine());

            if (ceki <= 0)
            {
                Console.WriteLine("Ceki 0 ola bilmez!");
                return;
            }

            Console.Write("Boy daxil edin: ");
            boy = float.Parse(Console.ReadLine());

            if (boy <= 0)
            {
                Console.WriteLine("Boy 0 ola bilmez!");
                return;
            }

            float BMI = ceki / (boy * boy);

            Console.WriteLine($"BMI: {BMI}");

            if (BMI < 18.5f)
            {
                Console.WriteLine("Çəki azlığı");
            }
            else if (BMI <= 24.9f)
            {
                Console.WriteLine("Normal çəki");
            }
            else if (BMI <= 29.9f)
            {
                Console.WriteLine("Artıq çəki");
            }
            else
            {
                Console.WriteLine("Piylənmə");
            }
        }
        static void Tapsiriq19()
        {
            double balans = 2000;
            double mebleg;
            char option;


            bool exit = false;
            while (!exit)
            {

                Console.Write("$");
                option = char.Parse(Console.ReadLine());
                switch (option)
                {
                    case '1':
                        Console.WriteLine($"Balans: {balans}");
                        break;

                    case '2':
                        Console.Write("Meblegi daxil edin: ");
                        mebleg = double.Parse(Console.ReadLine());
                        if (mebleg > balans)
                        {
                            Console.WriteLine("Mebleg balansdan coxdur");
                        }
                        else if (mebleg < 0)
                        {
                            Console.WriteLine("Mebleg menfi ola bilmez!");
                        }
                        else
                        {
                            balans -= mebleg;
                        }
                        break;
                    case '3':
                        Console.Write("Meblegi daxil edin: ");
                        mebleg = double.Parse(Console.ReadLine());
                        if (mebleg < 0)
                        {
                            Console.WriteLine("Mebleg menfi ola bilmez!");
                        }
                        else
                        {
                            balans += mebleg;
                        }
                        break;

                    case '0':
                        exit = true;
                        break;

                    default:
                        Console.WriteLine("Bilinmeyen parametr daxil edildi!\n Bir daha sinayin");
                        break;
                }
            }
           

        }
        static void Tapsiriq20()
        {
            int[] numbers = { 2, 7, 89, 5, 8, 3, 45, 6 };
            for (int i = 0; i <= numbers.Length; i++)
                Console.WriteLine("Massivin elementleri:" + numbers[i]);
        }
        static void Tapsiriq21()
        {
            int[] numbers = { 1, 5, 7, 8, 4, 3, 9, };
            int sum = 0;
            for (int i = 1; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            Console.WriteLine("Elementlerin cemi:" + sum);
        }
        static void Tapsiriq22()
        {
            int[] tamSayilar = { 3, 6, 5, 8, 9, 4, 7 };
            int sum = 0;
            double edediOrta = sum / tamSayilar.Length;
            for (int i = 0; i < tamSayilar.Length; i++)
            {
                sum += tamSayilar[i];
                edediOrta = sum / tamSayilar.Length;
            }
            Console.WriteLine("Elementlerin ortalamasi:" + edediOrta);
        }
        static void Tapsiriq23()
        {
            int[] numbers = { 4, 8, 9, 3, 67, 89, 2, 1 };

            int index = Array.IndexOf(numbers, numbers.Max());
            int index1 = Array.IndexOf(numbers, numbers.Min());

            Console.WriteLine("En boyuk eded:" + numbers.Max() + " " + "En kicik eded:" + numbers.Min());
            Console.WriteLine("En boyuk ededin index-i:" + index);
            Console.WriteLine("En kicik ededin index-i:" + index1);
        }
        static void Tapsiriq24()
        {
            int[] tamSayilar = { 3, 7, 5, 4, 8, 34, 22, 90, 44, 67 };

            for (int i = 0; i < tamSayilar.Length; i++)
            {
                if (tamSayilar[i] % 2 == 0)
                {
                    Console.WriteLine("Cut ededler:" + tamSayilar[i]);
                }
            }
        }
        static void Tapsiriq25()
        {
            string[] names = { "Xumar", "Sona", "Nermin", "Zehra", "Gunel" };
            Array.Reverse(names);
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine("Yeni array sirasi:" + names[i]);
            }
        }
        static void Tapsiriq26()
        {
            int[] numbers = { 3, 6, 78, 34, 9, 1, 5, 7 };

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == 7)
                {
                    Console.WriteLine("Eded movcuddur");
                    int index = Array.IndexOf(numbers, numbers[i]);
                    Console.WriteLine("Ededin index-i:" + index);
                }
            }
        }
        static void Tapsiriq27()
        {
            int[] numbers = { 2, 6, 4, 7, 89, 5, 2, 4 };
            int tekrarlanan = numbers[0];
            for (int i = 0; i < numbers.Length; i++)
            {

                if (tekrarlanan == numbers[i])
                {
                    Console.WriteLine("Tekrarlanan ededler:" + numbers[i]);
                }

            }
        }
        static void Tapsiriq28()
        {
            int[] numbers = { 1, 5, 7, 89, 56, 4, 3, 2 };
            Array.Sort(numbers);
            Array.Reverse(numbers);
            for (int i = 0; i < numbers.Length; i++)
                Console.WriteLine(numbers[i]);
            Console.WriteLine("En boyuk eded:" + numbers.Max());
            Console.WriteLine("Ikinci en boyuk eded:" + numbers[1]);
        }
        static void Tapsiriq29()
        {
            int num = int.Parse(Console.ReadLine());
            int cem = 0;
            int qaliq = 0;

            while (num != 0)
            {
                qaliq = num % 10;
                cem += qaliq;
                num /= 10;
            }

                Console.WriteLine(cem);
            } 
        static void Tapsiriq30()
        {
            int num = int.Parse(Console.ReadLine());
            int say= 0;
            while (num != 0)
            {
                num /= 10;
                say++;
            }
            Console.WriteLine(say);
        }
        static void Tapsiriq31()
        {
            int num = int.Parse(Console.ReadLine());

            if (num != 1 && num % num == 0)
            {
                Console.WriteLine("Eded sadedir");
            }
            else if (num == 1)
            {
                Console.WriteLine("Eded ne sadedir ne de murekkeb yeni 1-e beraberdir ");
            }
            else
            {
                Console.WriteLine("Eded murekkkebdir");
            }
        }
        static void Tapsiriq32()
        {
            int num = int.Parse(Console.ReadLine());
            int tempNum = num;
            int qaliq = 0;
            int reverse = 0;
            while (tempNum != 0)
            {
                qaliq = tempNum % 10;
                reverse = reverse * 10 + qaliq;
                tempNum /= 10;
            }
            if (num == reverse)
            {
                Console.WriteLine("Polindrom ededdir");
            }
            else
            {
                Console.WriteLine(num);
            }
        }
        static void Tapsiriq33()
        {
            int n = int.Parse(Console.ReadLine());
          
            int num = 0;
            int num1 = 1;
            int sum = 0;
            Console.Write($"{num} { num1}");
            for(int i = 0; i < n; i++)
            {
                sum = num + num1;
                num = num1;
                num1 = sum;
            }
            
        }
    }

}