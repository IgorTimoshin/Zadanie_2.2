using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Circle
    {
        // Создадим закрытые защищённые поля
        protected double _r;                        // Радиус
        protected double _length = 0;               // Длина окружности
        protected double _s = 0;                    // Площадь круга

        // В метод конструктор передаём радиус, длину окружности, площадь круга
        public Circle(double r, double l, double s)
        {
            // присваиваем параметры соответствующим полям
            _r = r;
            _length = l;
            _s = s;
        }

        // Открытые свойства для доступа к закрытым полям данного класса
        public double R
        {
            get { return _r; }
        }
        public double Length
        {
            get { return _length; }
        }
        public double S
        {
            get { return _s; }
        }
    }
}
