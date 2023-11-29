using System;

namespace TriangleLibrary
{
    public class TriangleType
    {
        public enum TriangleTypeEnum
        {
            Acute, // остроугольный
            Right, // прямоугольный
            Obtuse // тупоугольный
        }

        public static TriangleTypeEnum GetTriangleType(double sideA, double sideB, double sideC)
        {
            // Предварительная проверка на валидность треугольника
            if (sideA <= 0 || sideB <= 0 || sideC <= 0 ||
                sideA + sideB <= sideC || sideA + sideC <= sideB || sideB + sideC <= sideA)
            {
                throw new ArgumentException("Invalid triangle sides");
            }

            double a = Math.Min(sideA, Math.Min(sideB, sideC));
            double c = Math.Max(sideA, Math.Max(sideB, sideC));
            double b = sideA + sideB + sideC - a - c;

            // Проверяем на прямой угол 
            if (Math.Abs(a * a + b * b - c * c) < 0.0001) // добавляем погрешность для сравнения double-точности
            {
                return TriangleTypeEnum.Right;
            }

            // Проверяем тупой или острый угол
            if (a * a + b * b < c * c)
            {
                return TriangleTypeEnum.Obtuse;
            }
            else
            {
                return TriangleTypeEnum.Acute;
            }
        }
    }
}