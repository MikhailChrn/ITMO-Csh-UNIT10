using System;

namespace Задание_01
{
    class Program
    {
        //1.Угол задан с помощью целочисленных значений gradus - градусов, min - угловых минут, sec - угловых секунд.
        //Реализовать класс, в котором указанные значения представлены в виде свойств.
        //Для свойств предусмотреть проверку корректности данных.
        //Класс должен содержать конструктор для установки начальных значений,
        //а также метод ToRadians для перевода угла в радианы.
        //Создать объект на основе разработанного класса. Осуществить использование объекта в программе.

        static void Main(string[] args)
        {
            int G;
            byte M, S;

            Console.WriteLine("Добрый день!");
            Console.WriteLine("Вас приветсвует КОНВЕРТОР угловых значений!");
            Console.WriteLine();

        ReadGradus:
            Console.WriteLine("Введите количество градусов конвертируемого значения угла: ");
            try { G = Convert.ToInt16(Console.ReadLine()); }
            catch { Console.WriteLine("Введено некорректное значение!"); goto ReadGradus; }

        ReadMin:
            Console.WriteLine("Введите количество угловых минут конвертируемого значения угла: ");
            try { M = Convert.ToByte(Console.ReadLine()); }
            catch { Console.WriteLine("Введено некорректное значение!"); goto ReadMin; }

        ReadSec:
            Console.WriteLine("Введите количество угловых минут конвертируемого значения угла: ");
            try { S = Convert.ToByte(Console.ReadLine()); }
            catch { Console.WriteLine("Введено некорректное значение!"); goto ReadSec; }

            СonvertAngleToRadian CA = new СonvertAngleToRadian(G, M, S); //Создание нового класса конвертации значений из градусов в радианы
            //
            Console.WriteLine();
            CA.ToRadians();
            Console.WriteLine();
            Console.WriteLine("До свидания!");
            Console.ReadKey();
        }
    }

    class СonvertAngleToRadian
    {
        //Контроль входных данных рааботает.
        public int Gradus
        {
            set
            {
                if (value >= 0 && value <= 359)
                {
                    gradus = value;
                }
                else
                {
                    Console.WriteLine("Значение угла должно быть положительным и менее 360 градусов");
                }
            }
        }
        private int gradus;

        public byte Min
        {
            set
            {
                if (value >= 0 && value <= 59)
                {
                    min = value;
                }
                else
                {
                    Console.WriteLine("Значение угловых минут должно быть положительным и менее 60 минтут");
                }
            }
        }
        private byte min;
        public byte Sec
        {
            set
            {
                if (value >= 0 && value <= 59)
                {
                    sec = value;
                }
                else
                {
                    Console.WriteLine("Значение угловых секунд должно быть положительным и менее 60 секунд");

                }
            }
        }
        private byte sec;

        public СonvertAngleToRadian(int gradus, byte min, byte sec)
            //Не понятно назначение конструктора, название отзеркалено с класса.
            //В уроке 7 (Методы без классов) было более интуитивно понятно.
            //Почему нельзя сразу транслировать значения в метод?
            //Осталось ощущение, что блок "конструктор" с отзеркаленым названием избыточен.
        {
            Gradus = gradus;
            Min = min;
            Sec = sec;
        }

        public void ToRadians() //Метод в составе класса, который ковертирует и выводит результ на консоль.
        {
            int secs = sec + (60 * min) + (60 * 60 * gradus);
            double rads = secs * (Math.PI / (3600 * 180));

            Console.WriteLine("Угол в {0} гр. {1}'{2}'' составляет {3:F5} радиан.", gradus, min, sec, rads);
        }
        //14.10.2021 г. Материал пока усвоился плохо.
        //Ничего не работало, пока не сделал как в видеоуроке.
        //"Прочувствовать тему" пока не удалось.
    }
}








