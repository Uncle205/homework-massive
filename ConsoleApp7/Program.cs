using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {

            Program program = new Program();
            program.Main2();


        }
        public void Main2()
        {//2.	Ввести с клавиатуры номер трамвайного билета (6-значное число) и про-верить является ли данный
         //билет счастливым (если на билете напечатано шестизначное число, и сумма первых трёх цифр равна сумме последних трёх, то этот билет считается счастливым).
            string ticket;
            Console.WriteLine("Enter bus ticket");
            ticket = Console.ReadLine();
            int result = int.Parse(ticket);
            int one = result / 1000;
            int two = (result / 1000 - one) * 1000;
            int one1 = one / 100;
            int one2 = one / 10 - (one1 * 10);
            int one3 = one - (one1 * 100 + (one2 * 10));

            int two1 = two / 100;
            int two2 = two / 10 - (two1 * 10);
            int two3 = two - (two1 * 100 + (two2 * 10));
            int one4 = one1 + one2 + one3;
            int two4 = two1 + two2 + two3;
            if (one4 == two4)
            {
                Console.WriteLine("you have a lucky ticket");
            }
            else
            {
                Console.WriteLine("you have not lucky ticket");

            }
        }
        public void Main3()
        {
            int e, count = 0;
            char i;
            for (; ; )
            {
                Console.WriteLine("Введите символ");
                e = Console.Read();

                if (e >= 65 && e <= 90)
                {
                    e += 32;
                    i = (char)e;
                    Console.WriteLine(i);

                }
                else if (e >= 97 && e <= 122)
                {
                    e -= 32;
                    i = (char)e;
                    Console.WriteLine(i);
                }
                else if (e == 46)
                {
                    break;
                }
                else
                {
                    i = (char)e;
                    Console.WriteLine(i);
                }
                count++;

            }
            Console.WriteLine("Всего введено " + count + " символов");


        }
        public void Main1()
        {
            ConsoleKeyInfo QWERTY;
            Console.WriteLine("Enter words and push .");
            while (true)
            {
                QWERTY = Console.ReadKey();

                if (QWERTY.KeyChar == '.')
                {
                    Environment.Exit(0);
                }
            }



        }
        public void Main4()
        {
            int A = 2;
            int B = 5;
            for (int i = A; i < B; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine("\n");




            }


        }
        public void Main5()
        {
            Console.WriteLine("Введите N");
            int N = int.Parse(Console.ReadLine());
            string obr = "";

            while (N > 9)
            {
                obr += (N % 10).ToString();
                N = N / 10;
            }

            obr += N.ToString();
            Console.WriteLine("Число наоборот " + obr);

        }

    }
}
