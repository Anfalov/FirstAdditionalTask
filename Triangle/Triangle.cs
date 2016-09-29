using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    public class Triangle
    {
        double a, b, c;
        Triangle(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public static Triangle Sides(double sideA, double sideB, double sideC)
        {
            if (sideA <= 0 || sideB <= 0 || sideC <= 0)
                throw new ArgumentException("Side can't be less than 0.");
            if (sideA + sideB <= sideC || sideA + sideC <= sideB || sideB + sideC <= sideA)
                throw new ArgumentException("Sum of two sides can't be less than third side.");
            return new Triangle(sideA, sideB, sideC);
        }
        public static Triangle AngleAnd2Sides(double angleA, double sideB, double sideC)
        {
            if (sideB <= 0 || sideC <= 0)
                throw new ArgumentException("Side can't be less than 0.");
            if (angleA <= 0 || angleA >= 180)
                throw new ArgumentException("Angle must be between 0 and 180 degrees.");
            double sideA = Math.Sqrt(Math.Pow(sideB, 2) + Math.Pow(sideC, 2) - 2 * sideB * sideC * Math.Cos(angleA * Math.PI / 180));
            return new Triangle(sideA, sideB, sideC);
        }
        public static Triangle SideAnd2Angles(double sideA, double angleB, double angleC)
        {
            if (sideA <= 0)
                throw new ArgumentException("Side can't be less than 0.");
            if (angleB <= 0 || angleC <= 0)
                throw new ArgumentException("Angle can't be less than 0.");
            if (angleB + angleC >= 180)
                throw new ArgumentException("Sum of two angles can't be more than 180 degrees.");
            double angleA = 180 - (angleB + angleC);
            angleA *= Math.PI / 180;
            angleB *= Math.PI / 180;
            angleC *= Math.PI / 180;
            return new Triangle(sideA, sideA * Math.Sin(angleB) / Math.Sin(angleA), sideA * Math.Sin(angleC) / Math.Sin(angleA));
        }
        public double Area()
        {
            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
    }
}
