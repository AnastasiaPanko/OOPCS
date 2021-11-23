using System;

namespace Quadrangle
{
    public class MyTriangle
    {
        public double sideA;
        public double sideB;
        public float angleOne;
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
            double halfPerimeter = this.perimeter / 2;
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
            double radiusDescribed = (2 * area) / (this.sideA + this.sideB + this.sideC);
            Console.WriteLine($"Радiус кола, вписаного в трикутник: {radiusDescribed}");
        }

        MyTriangle(int sideA, int sideB, int sideC)
        {
            this.sideA = sideA;
            this.sideB = sideB;
            this.sideC = sideC;
            /*bool check = this.checkingExistence();
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
            this.getRadiusDescribed();*/
        }

        public MyTriangle(int sideA, int sideB, float angleOne)
        {
            this.sideA = sideA;
            this.sideB = sideB;

            angleOne = Convert.ToSingle((angleOne * Math.PI) / 180);

            this.sideC = Math.Sqrt(Math.Pow(sideA, 2) + Math.Pow(sideB, 2) - 2 * sideA * sideB * Math.Cos(angleOne));

            /*bool check = this.checkingExistence();
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
            this.getRadiusDescribed();*/
        }

        MyTriangle(int sideA, float angleOne, float angleTwo)
        {
            this.sideA = sideA;

            double angleThree = (180 - (angleOne + angleTwo));

            angleOne = Convert.ToSingle((angleOne * Math.PI) / 180);
            angleTwo = Convert.ToSingle((angleTwo * Math.PI) / 180);
            angleThree = Convert.ToSingle((angleThree * Math.PI) / 180);

            this.sideB = (sideA * Math.Sin(angleOne)) / Math.Sin(angleThree);


            this.sideC = (sideA * Math.Sin(angleTwo)) / Math.Sin(angleThree);
            Console.WriteLine(this.sideC);

            /*bool check = this.checkingExistence();
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
            this.getRadiusDescribed();*/
        }
    }
        public class MyQuadrangle : MyTriangle
    {
        private int sideA;
        private int sideB;
        private int sideC;
        private int sideD;
        private float angleOne;
        private float angleTwo;
        private float angleThree;
        private float angleFour;
       

        public int SideA
        {
            get
            {
                return sideA;
            }
            set
            {
                sideA = value;
            }
        }

        public int SideB
        {
            get
            {
                return sideB;
            }
            set
            {
                sideB = value;
            }
        }

        public int SideC
        {
            get
            {
                return sideC;
            }
            set
            {
                sideC = value;
            }
        }

        public int SideD
        {
            get
            {
                return sideD;
            }
            set
            {
                sideD = value;
            }
        }

        public bool checkingExistence()
        {

            if (this.angleOne + this.angleTwo + this.angleThree + this.angleFour  == 360)
            {
                Console.WriteLine("Чотирикутник iснує");
                return true;
            }
            else
            {
                Console.WriteLine("Чотирикутник не iснує");
                return false;
            }
        }

        public void getRadian()
        {
            this.angleTwo = Convert.ToSingle((this.angleTwo * Math.PI) / 180);
            this.angleFour = Convert.ToSingle((this.angleFour * Math.PI) / 180);
            
        }
        public void getPerimeter()
        {
            int perimeter = this.sideA + this.sideB + this.sideC + this.sideD;
            Console.WriteLine($"Периметер чотирикутника: {perimeter}");
        }

        public void getDiagonals()
        {
            getRadian();
            double firstDiagonal = Math.Sqrt(Math.Pow(sideA, 2) + Math.Pow(sideB, 2) - 2 * sideA * sideB * Math.Cos(angleTwo));
            double secondDiagonal = Math.Sqrt(Math.Pow(sideC, 2) + Math.Pow(sideD, 2) - 2 * sideC * sideD * Math.Cos(angleFour));
            Console.WriteLine($"Перша дiагональ чотирикутника: {firstDiagonal }");
            Console.WriteLine($"Друга дiагональ чотирикутника: {secondDiagonal }");


        }

        public void getArea()
        {

            getRadian();
            double firstHalfArea = 1 / 2 * (this.sideA * this.sideB * Math.Sin(angleTwo));
            double secondHalfArea = 1 / 2 * (this.sideC * this.sideD * Math.Sin(angleFour));

            double area = firstHalfArea + secondHalfArea;

            Console.WriteLine($"Площа чотирикутника: {area}");

        }
        public MyQuadrangle(int sideA, int sideB, int sideC, int sideD, float angleOne, float angleTwo, float angleThree, float angleFour)
            :base(sideA, sideB, angleOne)
        {
            this.angleOne = angleOne;
            this.angleTwo = angleTwo;
            this.angleThree = angleThree;
            this.angleFour = angleFour;

            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
            SideD = sideD;
            
           

            bool check = this.checkingExistence();
            if (!check)
            {
                return;
            }
            getPerimeter();
            getDiagonals();
            getArea();
            
            
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введiть 4 сторони i 4 кута для довiльного чотирикутника:");
            int sideA = Convert.ToInt32(Console.ReadLine());
            int sideB = Convert.ToInt32(Console.ReadLine());
            int sideC = Convert.ToInt32(Console.ReadLine());
            int sideD = Convert.ToInt32(Console.ReadLine());
            float angleOne = Convert.ToSingle(Console.ReadLine());
            float angleTwo = Convert.ToSingle(Console.ReadLine());
            float angleThree = Convert.ToSingle(Console.ReadLine());
            float angleFour = Convert.ToSingle(Console.ReadLine());

            new MyQuadrangle(sideA, sideB, sideC, sideD, angleOne, angleTwo, angleThree, angleFour);





        }
    }
}
