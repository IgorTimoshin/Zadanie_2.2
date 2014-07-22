using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Program
    {
        //Создаём закрытое поле. Список предложений.
        private static List<Circle> _circles = new List<Circle>();

        static void Main(string[] args)
        {
            // Создаём 5 экземпляров класса Circle
            Circle c1 = new Circle(2.5, 6, 8);
            Circle c2 = new Circle(3, 34, 88);
            Circle c3 = new Circle(2, 12, 12);
            Circle c4 = new Circle(6.5, 67, 69);
            Circle c5 = new Circle(1, 10, 11);
            // Добавляем их в список
            _circles.Add(c1);
            _circles.Add(c2);
            _circles.Add(c3);
            _circles.Add(c4);
            _circles.Add(c5);

            // Выведем список в консоль
            Console.WriteLine("Список:");
            Print();

            // Отсортируем список по одному из критериев
            Console.WriteLine("\nВведите номер критерия! \n1. По длине окружности \n2. По площади круга \n3. По радиусу");
            string s = Console.ReadLine();
            int x = int.Parse(s);

            Sort(x);
            Console.WriteLine("\nСписок, после сортировки:");
            Print();

            // Добавим ещё одно предложение в конец списка и в заданную позицию
            _circles.Add(new Circle(1, 1.5, 3)); // Это в конец
            Console.WriteLine("\nВведите номер позиции, в которую нужно добавить новую окружность (от 0 до {0})", _circles.Count - 1);
            s = Console.ReadLine();
            int index = int.Parse(s);
            // Добывим предложение в указанное место методом Insert
            _circles.Insert(index, new Circle(13, 25, 39));

            Console.WriteLine("\nСписок, после добавления окружностей в конец и в заданную позицию списка:");
            Print();

            // Удалим 2, ранее добавленных, окружности
            _circles.RemoveAt(_circles.Count - 1);
            _circles.RemoveAt(index);

            // Сделаем небольшую задержку, чтобы пользователь смог отследить, что окружности и впрямь добавились на нужные позиции
            // После нажатия на Enter эти окружности удалятся из списка
            Console.WriteLine("\nНажмите Enter для продолжения!");
            Console.ReadLine();

            Console.WriteLine("\nСписок, после удаления двух, ранее добавленных, окружностей:");
            Print();

            // В зависимости от критерия и введённого значения, найдём указынный элемент
            Console.WriteLine("\nВведите номер критерия! \n1. По длине окружности \n2. По площади круга \n3. По радиусу");
            s = Console.ReadLine();
            x = int.Parse(s);
            Console.WriteLine("\nВведите значение параметра поиска");
            s = Console.ReadLine();
            int e = int.Parse(s);
            // Найдём элемент по заданным критериям
            if (x == 1)
                index = _circles.FindIndex(i => i.Length == e);
            else if (x == 2)
                index = _circles.FindIndex(i => i.S == e);
            else if (x == 3)
                index = _circles.FindIndex(i => i.R == e);
            else
                Console.WriteLine("\nТакого критерия/значения не существует");

            // Выведем найденный элемент в консоль
            Console.WriteLine("\nНайденный элемент поиска:\n");
            Console.WriteLine("Радиус: {0} \nДлина окружности: {1} \nПлощад круга: {2}", _circles[index].R, _circles[index].Length, _circles[index].S);

            // Очистим список
            _circles.Clear();
            Console.WriteLine("\nСписок пуст!");

            Console.ReadLine();
        }

        // Метод сортировки. В параметр передаётся номер критерия сортировки. При сортировке используется Buble Sort (сортировка методом пузырька)
        static void Sort(int x)
        {
            for (int i = 1; i < _circles.Count; i++)
            {
                for (int j = 0; j < _circles.Count - i; j++)
                {
                    if (x == 1)
                    {
                        if (_circles[j].Length > _circles[j + 1].Length)
                        {
                            Circle c = _circles[j];
                            _circles[j] = _circles[j + 1];
                            _circles[j + 1] = c;
                        }
                    }
                    else if (x == 2)
                    {
                        if (_circles[j].S > _circles[j + 1].S)
                        {
                            Circle c = _circles[j];
                            _circles[j] = _circles[j + 1];
                            _circles[j + 1] = c;
                        }
                    }
                    else if (x == 3)
                    {
                        if (_circles[j].R > _circles[j + 1].R)
                        {
                            Circle c = _circles[j];
                            _circles[j] = _circles[j + 1];
                            _circles[j + 1] = c;
                        }
                    }
                }
            }
        }

        // Метод для вывода списка в консоль
        static void Print()
        {
            for (int i = 0; i < _circles.Count; i++)
            {
                Console.WriteLine("\nРадиус = {0}", _circles[i].R);
                Console.WriteLine("Длина окружности = {0}", _circles[i].Length);
                Console.WriteLine("Площадь круга = {0}", _circles[i].S);
            }
        }
    }
}
