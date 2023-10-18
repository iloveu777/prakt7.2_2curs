using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleApp11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1
            /* Write("Введите название футбольного клуба: ");
             string club = ReadLine();
             int lenght = club.Length;
             WriteLine($"симвов в названии клуба - {lenght}");*/

            //2
            /*Write("Введите название футбольного клуба: ");
            string city = ReadLine();
            int lenght = city.Length;
            if (lenght % 2 == 0)
            {
                WriteLine("Количество символов в названии города четно");
            }
            else
            {
                WriteLine("Количество символов в названии города четно");
            } */

            //3
            /*Write("Введите первую фамилию: ");
            string surname1 = ReadLine();
            int lenght1 = surname1.Length;
            Write("Введите вторую фамилию: ");
            string surname2 = ReadLine();
            int lenght2 = surname2.Length;
            if(lenght1 > lenght2)
            {
                WriteLine("Первая фамилия длинне");

            }
            else
            {
                WriteLine("Вторая фамилия длиннее");
            }*/


            /* Write("Введите первую фамилию: ");
             string surname1 = ReadLine();
             int lenght1 = surname1.Length;
             Write("Введите вторую фамилию: ");
             string surname2 = ReadLine();
             int lenght2 = surname2.Length;
             if (lenght1 > lenght2)
             {
                 WriteLine("Первая фамилия длинне");

             }
             else
             {
                 WriteLine("Вторая фамилия длиннее");
             }*/

            //4
            /* string[] words = new string[5];
             for(int i = 0; i < words.Length; i++)
             {
                 Write($"Введите слово #{i + 1}:");
                 words[i] = ReadLine();
             }
             string longestWord = "a";
             foreach (string word in words)
             {
                 if (word.Length > longestWord.Length)
                 {
                     longestWord = word;
                 }

             }

             WriteLine("самое длинное слово:" +longestWord);
             */

            //5 
            /*  Write("Введите имя: ");
              string name = ReadLine();
              Write("Введите фамилию: ");
              string surname = ReadLine();
              string[] fioMas = new string[] { name, surname };

              string fio = string.Join(" ", fioMas);
              Console.WriteLine(fio);*/

            //6 
            /* Write("Введите какое-нибудь предложение:");
             string words = ReadLine();
             char target = 'а';

             int count = 0;

             foreach (char c in words)
             {
                 if (c == target)
                 {
                     count++;
                 }

             }
             WriteLine($"Количество искомых букв: {count}");*/

            //7
            Write("Введите предложение: ");
            string text = ReadLine();
            string[] words = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            Write($"количество слов: {words.Length}");
            ReadKey();
        }
    }
}
