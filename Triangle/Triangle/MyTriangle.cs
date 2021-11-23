using System;

namespace Triangle
{
    public class MyTriangle
    {
        private double sideA;
        private double sideB;
        private double sideC;
        private double area;
        private double perimeter;

        public bool checkingExistence()
        {
            if (sideA + sideB > sideC & sideB + sideC > sideA & sideA + sideC > sideB)
            {
                Console.WriteLine("Трикутник iснує");
                return true;
            }
            else
            {
                Console.WriteLine("Трикутник не iснує");
                return false;
            }
        }

        private void outputSides()
        {
            Console.WriteLine($"Сторона А: {Convert.ToInt32(this.sideA)}");
            Console.WriteLine($"Сторона B: {Convert.ToInt32(this.sideB)}");
            Console.WriteLine($"Сторона С: {Convert.ToInt32(this.sideC)}");
        }
        private void getPerimeter()
        {
            double getPerimeter = this.sideA + this.sideB + this.sideC;
            Console.WriteLine($"Периметр: {getPerimeter}");
            this.perimeter = getPerimeter;
        }

        private void getArea()
        {
            double halfPerimeter = this.perimeter/ 2;
            double getArea = Math.Sqrt(halfPerimeter * (halfPerimeter - this.sideA) * (halfPerimeter - this.sideB) * (halfPerimeter - this.sideC));
            Console.WriteLine($"Площа: {getArea}");
            this.area = getArea;
        }

        private void getHeight()
        {
            double area = this.area;
            double getHeight = 2 * area / this.sideA;
            Console.WriteLine($"Висота: {getHeight}");
            
        }

        private void getBisector()
        {
            double Bisector = (Math.Sqrt(this.sideA * this.sideB * (this.sideA + this.sideB + this.sideC) * (this.sideA + this.sideB - this.sideC)) / (this.sideA + this.sideB));
            Console.WriteLine($"Бiсектриса до сторони C: {Bisector}");
        }

        private void getRadiusInscribed()
        {
            double area = this.area;
            double radiusInscribed = (this.sideA * this.sideB * this.sideC) / (4 * area);
            Console.WriteLine($"Радiус кола, описаного навколо трикутника: {radiusInscribed}");
        }

        private void getRadiusDescribed()
        {
            double area = this.area;
            double radiusDescribed = (2 * area)/(this.sideA + this.sideB + this.sideC);
            Console.WriteLine($"Радiус кола, вписаного в трикутник: {radiusDescribed}");
        }

        MyTriangle(int sideA, int sideB, int sideC)
        {
            this.sideA = sideA;
            this.sideB = sideB;
            this.sideC = sideC;
            bool check = this.checkingExistence();
            if (!check) 
            {
           
                return;
            }

            this.outputSides();
            this.getPerimeter();
            this.getArea();
            this.getHeight();
            this.getBisector();
            this.getRadiusInscribed();
            this.getRadiusDescribed();
        }

        MyTriangle(int sideA, int sideB, float angleOne)
        {
            this.sideA = sideA;
            this.sideB = sideB;

            angleOne = Convert.ToSingle((angleOne * Math.PI) / 180); 

            this.sideC = Math.Sqrt(Math.Pow(sideA, 2) + Math.Pow(sideB, 2) - 2 * sideA * sideB * Math.Cos(angleOne));

            bool check = this.checkingExistence();
            if (!check == true)
            {
                return;
            }

            this.outputSides();
            this.getPerimeter();
            this.getArea();
            this.getHeight();
            this.getBisector();
            this.getRadiusInscribed();
            this.getRadiusDescribed();
        }

        MyTriangle(int sideA, float angleOne, float angleTwo)
        {
            this.sideA = sideA;
            
            double angleThree = (180-(angleOne + angleTwo));

            angleOne = Convert.ToSingle((angleOne * Math.PI) / 180);
            angleTwo = Convert.ToSingle((angleTwo * Math.PI) / 180);
            angleThree = Convert.ToSingle((angleThree * Math.PI) / 180);

            this.sideB = (sideA * Math.Sin(angleOne)) / Math.Sin(angleThree);
            

            this.sideC = (sideA * Math.Sin(angleTwo)) / Math.Sin(angleThree);
            Console.WriteLine(this.sideC);

            bool check = this.checkingExistence();
            if (!check)
            {
                return;
            }

            this.outputSides();
            this.getPerimeter();
            this.getArea();
            this.getHeight();
            this.getBisector();
            this.getRadiusInscribed();
            this.getRadiusDescribed();
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine("За допомогою яких даних ви хочете побудувати трикутник?");
            Console.WriteLine("1. За 3 сторонами\n2. За 2 сторонами i кутом мiж ними\n3. За стороною i 2 кутами");
            string number = Console.ReadLine();

            switch (number)
            {
                case "1":
                    Console.WriteLine("Введiть 3 сторони:");
                    Console.WriteLine("Введiть першу сторону:");
                    int sideA = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введiть другу сторону:");
                    int sideB = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введiть третю сторону:");
                    int sideC = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Данi про трикутник");

                    new MyTriangle(sideA, sideB, sideC);
                    break;
                case "2":
                    Console.WriteLine("Введiть 2 сторони i кут мiж ними:");
                    Console.WriteLine("Введiть першу сторону:");
                    sideA = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введiть другу сторону:");
                    sideB = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введiть перший кут:");
                    float angleOne = Convert.ToSingle(Console.ReadLine());
                    Console.WriteLine("Данi про трикутник");

                    new MyTriangle(sideA, sideB, angleOne);
                    break;
                case "3":
                    Console.WriteLine("Введiть 1 сторону i 2 кута, якi прилягають до сторони:");
                    Console.WriteLine("Введiть першу сторону:");
                    sideA = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введiть перший кут:");
                    angleOne = Convert.ToSingle(Console.ReadLine());
                    Console.WriteLine("Введiть другий кут:");
                    float angleTwo = Convert.ToSingle(Console.ReadLine());
                    Console.WriteLine("Данi про трикутник");

                    new MyTriangle(sideA, angleOne, angleTwo);
                    break;
            }

        }
    }
}
