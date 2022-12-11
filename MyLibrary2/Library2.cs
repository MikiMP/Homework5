using System;

namespace MyLibrary2
{
    //2.	Создайте ClassLibrary с типом Cone.Конструктор типа принимает 2 параметра: радиус(r) и высоту(h).
    //    Так же в типе есть два метода, которые высчитывают площадь поверхности осования и полную площать.
    public class Cone
    {
       // const double pi = 3.1415926535897931; //Константы тоже с маленькой буквы?
        private double _radius = 0d;
        private double _height = 0d;
        private double _result = 0d;
        private double _generatrix = 0d;

        public Cone(double radius, double height) 
        {
            _radius = radius;
            _height = height;
        }  
        
        public double getCircleArea()
        {
            return Math.Pow(_radius, 2) * Math.PI;
        }

        //AB^2 = OB^2 + AO^2
        //PiRl + PiR^2
        public double getConeArea()
        {
            _generatrix = Math.Pow(_radius, 2) + Math.Pow(_height, 2);
            _generatrix = Math.Sqrt(_generatrix);

            _result = (Math.Pow(_radius, 2) * Math.PI) + (Math.PI * _radius * _generatrix);

            return _result;
        }

    }

}
