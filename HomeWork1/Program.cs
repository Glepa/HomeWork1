using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork1
{
    class Program
    {
        static void Main(string[] args)
        {
            string name1, name2, name3;
            int age1, age2, age3;
            int ballRus1, ballRus2, ballRus3;
            int ballHistory1, ballHistory2, ballHistory3;
            int ballMath1, ballMath2, ballMath3;
            //Ввод данных 1 сотрудника
            Console.WriteLine("1 Сотрудник:");
            Console.Write("Введите имя: ");
            name1 = Console.ReadLine();
            Console.Write("Введите возраст: ");
            age1 = int.Parse(Console.ReadLine());
            if(age1<=0||age1>120)
                Console.WriteLine("Вы ввели некорректный возраст!!!");
            Console.Write("Введите балл по русскому языку: ");
            ballRus1 = int.Parse(Console.ReadLine());
            if(ballRus1<=0||ballRus1>5)
                Console.WriteLine("Вы ввели некорректный балл!!!");
            Console.Write("Введите балл по истории: ");
            ballHistory1 = int.Parse(Console.ReadLine());
            if(ballHistory1<=0||ballHistory1>5)
                Console.WriteLine("Вы ввели некорректный балл!!!");
            Console.Write("Введите балл по математике: ");
            ballMath1 = int.Parse(Console.ReadLine());
            if (ballMath1 <= 0 || ballMath1 > 5)
                Console.WriteLine("Вы ввели некорректный балл!!!");
            Console.WriteLine();
            Console.ReadKey();

            //Ввод данных 2 сотрудника
            Console.WriteLine("2 Сотрудник:");
            Console.Write("Введите имя: ");
            name2 = Console.ReadLine();
            Console.Write("Введите возраст: ");
            age2 = int.Parse(Console.ReadLine());
            if (age2 <= 0 || age2 > 120)
                Console.WriteLine("Вы ввели некорректный возраст!!!");
            Console.Write("Введите балл по русскому языку: ");
            ballRus2 = int.Parse(Console.ReadLine());
            if (ballRus2 <= 0 || ballRus2 > 5)
                Console.WriteLine("Вы ввели некорректный балл!!!");
            Console.Write("Введите балл по истории: ");
            ballHistory2 = int.Parse(Console.ReadLine());
            if (ballHistory2 <= 0 || ballHistory2 > 5)
                Console.WriteLine("Вы ввели некорректный балл!!!");
            Console.Write("Введите балл по математике: ");
            ballMath2 = int.Parse(Console.ReadLine());
            if (ballMath2 <= 0 || ballMath2 > 5)
                Console.WriteLine("Вы ввели некорректный балл!!!");
            Console.WriteLine();
            Console.ReadKey();

            //Ввод данных 3 сотрудника
            Console.WriteLine("3 Сотрудник:");
            Console.Write("Введите имя: ");
            name3 = Console.ReadLine();
            Console.Write("Введите возраст: ");
            age3 = int.Parse(Console.ReadLine());
            if (age3 <= 0 || age3 > 120)
                Console.WriteLine("Вы ввели некорректный возраст!!!");
            Console.Write("Введите балл по русскому языку: ");
            ballRus3 = int.Parse(Console.ReadLine());
            if (ballRus3 <= 0 || ballRus3 > 5)
                Console.WriteLine("Вы ввели некорректный балл!!!");
            Console.Write("Введите балл по истории: ");
            ballHistory3 = int.Parse(Console.ReadLine());
            if (ballHistory3 <= 0 || ballHistory3 > 5)
                Console.WriteLine("Вы ввели некорректный балл!!!");
            Console.Write("Введите балл по математике ");
            ballMath3 = int.Parse(Console.ReadLine());
            if (ballMath3 <= 0 || ballMath3 > 5)
                Console.WriteLine("Вы ввели некорректный балл!!!");
            Console.WriteLine();
            Console.ReadKey();

            // Подсчет среднего балла:
            //средний балл 1 сотрудника
            double averageScore1 = (double)(ballRus1 + ballHistory1 + ballMath1) / 3;
            Console.WriteLine($"Средний бал 1 сотрудника: {averageScore1:0.0}");
            //средний балл 2 сотрудника
            double averageScore2 = (double)(ballRus2 + ballHistory2 + ballMath2) / 3;
            Console.WriteLine($"Средний бал 2 сотрудника: {averageScore2:0.0}");
            //средний балл 3 сотрудника
            double averageScore3 = (double)(ballRus3 + ballHistory3 + ballMath3) / 3;
            Console.WriteLine($"Средний бал 3 сотрудника: {averageScore3:0.0}");
            Console.WriteLine();
            Console.ReadKey();

            // Вывод информации
            // Вывод информации для 1 сотрудника (обычный вывод)
            Console.WriteLine("1 сотрудник:");
            string output1 = "Имя: " + name1 + "\nвозраст: " + age1
                              + "\nбалл по русскому языку: "
                              + ballRus1 + "\nбал по истории: "
                              + ballHistory1 + "\nбалл по математике: "
                              + ballMath1;
            Console.WriteLine(output1);
            // Вывод информации для 2 сотрудника (форматированный)
            Console.WriteLine("\n2 сотрудник:");
            string output2 = "Имя: {0}\nвозраст: {1}\nбалл по русскому языку: {2}\n" +
                              "бал по истории: {3}\nбалл по математике: {4}";
            Console.WriteLine(output2, name2, age2, ballRus2,
                                     ballHistory2, ballMath2);
            // Вывод информации для 3 сотрудника (интерполяция строк)
            Console.WriteLine("\n3 сотрудник:");
            string output3 = $"Имя: {name3}\nвозраст: {age3}\n" +
                             $"балл по русскому языку: {ballRus3}\n" +
                             $"бал по истории: {ballHistory3}\n" +
                             $"балл по математике: {ballMath3}";
            Console.WriteLine("{0,"+(Console.WindowWidth-output3.Length)/2+
                               "}",output3);
            Console.ReadKey();
            Console.WriteLine();
            // вывод данных  сотрудников по центру консоли
            string newOutput1 = name1 + "   " + age1 + "   " + ballRus1 + "   " +
                               ballHistory1 + "   " + ballMath1;
            string newOutput2 = name2 + "   " + age2 + "   " + ballRus2 + "   " +
                               ballHistory2 + "   " + ballMath2;
            string newOutput3 = name3 + "   " + age3 + "   " + ballRus3 + "   " +
                               ballHistory3 + "   " + ballMath3;
            int len = Console.WindowWidth / 2;
            Console.WriteLine("{0," + len + "}\n{1," + len + "}\n{2," + len + "}",newOutput1,
                               newOutput2,newOutput3);
        

        }
    }
}
