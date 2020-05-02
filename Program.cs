using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleClassConsole {
    class Program {

        public static Airplane[] airplanes;

        static void Main(string[] args) {

            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            var array = new Airplane[3];
            array[0] = new Airplane("asdasd", "asdasf as", new Date(2020, 3, 1, 0, 0), new Date(2020, 4, 1, 0, 0));
            array[1] = new Airplane("asdasd", "asdasf as", new Date(2020, 4, 1, 0, 0), new Date(2020, 7, 1, 0, 0));
            array[2] = new Airplane("asdasd", "asdasf as", new Date(2020, 2, 1, 0, 0), new Date(2020, 3, 5, 0, 0));

            airplanes = array;

            s_menu();
        }

        public static void s_menu() {
            Console.WriteLine("\n1 - Зчитати рейси");
            Console.WriteLine("2 - Вивести список рейсів");
            Console.WriteLine("3 - Вивести найбільший та найменший час подорожі");
            Console.WriteLine("4 - Посортувати рейси за спаданням дати відправлення");
            Console.WriteLine("5 - Посортувати рейси за зростанням часу подорожі");
            Console.WriteLine("Введіть номер функції");

            switch(int.Parse(Console.ReadLine())) {
                case 1:
                    Console.WriteLine("Введіть кількість зчитуємих рейсів: ");
                    airplanes = ReadAirplaneArray(int.Parse(Console.ReadLine()));
                    break;
                case 2:
                    Console.WriteLine("Список рейсів: ");
                    PrintAirplanes(airplanes);
                    break;
                case 3:
                    Airplane longer;
                    Airplane shorter;
                    GetAirplaneInfo(airplanes, out longer, out shorter);

                    Console.WriteLine("Найдовший рейс: ");
                    PrintAirplane(longer);
                    Console.WriteLine("Найкоротший рейс: ");
                    PrintAirplane(shorter);
                    break;
                case 4:
                    SortAirplanesByDate(airplanes);
                    Console.WriteLine("Сортування виконано: ");
                    break;
                case 5:
                    SortAirplanesByTotalTime(airplanes);
                    Console.WriteLine("Сортування виконано: ");
                    break;
            }
            s_menu();
        }

        public static Airplane[] ReadAirplaneArray(int n) {
            int count = 0;
            Airplane[] airplanes = new Airplane[n];

            while (count < airplanes.Length) {
                Airplane airplane = new Airplane();
                string StartCity;
                string FinishCity;
                Console.WriteLine("Введіть початкове місто (латинськими літерами): ");
                StartCity = Console.ReadLine();
                Console.WriteLine("Введіть кінцеве місто (латинськими літерами): ");
                FinishCity = Console.ReadLine();
                Console.WriteLine("Введіть початковий час через кому у відповідному порядку (рік, місяць, день, година, хвилина): ");
                string[] LineS = Console.ReadLine().Split(",");
                Console.WriteLine("Введіть кінцевий час через кому у відповідному порядку (рік, місяць, день, година, хвилина): ");
                string[] LineF = Console.ReadLine().Split(",");


                airplane.setStartCity(StartCity);
                airplane.setFinishCity(FinishCity);
                airplane.SetStartDate(new Date(int.Parse(LineS[0]), int.Parse(LineS[1]),
                    int.Parse(LineS[2]), int.Parse(LineS[3]),
                    int.Parse(LineS[4])));
                airplane.SetFinishDate(new Date(int.Parse(LineF[0]), int.Parse(LineF[1]),
                    int.Parse(LineF[2]), int.Parse(LineF[3]),
                    int.Parse(LineF[4])));

                airplanes[count] = airplane;
                count++;
                PrintAirplane(airplane);
            }
            return airplanes;
        }

        public static void PrintAirplane(Airplane airplane) {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nРейс - Початкове місто: " + airplane.getStartCity() + " | Кінцеве місто: " + airplane.getFinishCity() + "\n  Дата відправленяя: " +
                airplane.GetStartDate().ToDateTime().ToString() + " | Дата прибуття: " + airplane.GetFinishDate().ToDateTime().ToString() + "\n     "
                + "Час подорожі: " + airplane.GetTotalTime() + "\n");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static void PrintAirplanes(Airplane[] airplanes) {
            for(int i = 0; i < airplanes.Length; i++) {
                PrintAirplane(airplanes[i]);
            }
        }

        public static void GetAirplaneInfo(Airplane[] airplanes, out Airplane longerTime, out Airplane shorterTime) {
            Array.Sort(airplanes, new TravelTimeComparator());
            longerTime = airplanes[airplanes.Length - 1];
            shorterTime = airplanes[0];
        }

        public static void SortAirplanesByDate(Airplane[] airplanes) {
            Array.Sort(airplanes, new StartDateComparator());
        }

        public static void SortAirplanesByTotalTime(Airplane[] airplanes) {
            Array.Sort(airplanes, new TravelTimeComparator());
        }
    }
}
