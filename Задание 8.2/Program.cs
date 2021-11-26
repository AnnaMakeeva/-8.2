using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Задание_8._2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Запись чисел в файл
            Random random = new Random();

            string path = "Logs2/Log.txt";

            StreamWriter My_File = new StreamWriter(path, true);

            My_File.Flush();

            for (int i = 1; i <= 1000; i++)
            {
                My_File.WriteLine(random.Next(0, 100));
            }

            My_File.Close();


            // Чтение чисел из файла
            int Res = 0;

            StreamReader My_File_2 = new StreamReader(path);
            while (!My_File_2.EndOfStream)
            {
                string s = My_File_2.ReadLine();
                int Num = Int32.Parse(s);
                Res = Res + Num;
            }
            My_File_2.Close();


            Console.Write("Сумма чисел в файле равна: {0}", Res);



            Console.ReadKey();

        }
    }
}
