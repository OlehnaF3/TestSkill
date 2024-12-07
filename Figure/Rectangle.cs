namespace TestSkill.Figure
{
    class Rectangle
    {
        public int A;

        public int B;

        /// <summary>
        /// Коснтруктор по умолчанию
        /// </summary>
        public Rectangle()
        {
            A = 4;
            B = 5;
        }

        /// <summary>
        /// Коструктор с параметрами
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>

        public Rectangle(int a, int b)
        {
            A = a;
            B = b;
        }

        /// <summary>
        /// Вычесление площади
        /// </summary>

        public void CalculationSquare()
        {
            Console.WriteLine("{0}", A * B);
        }

        /// <summary>
        /// Вычесление периметра
        /// </summary>

        public void CalculationPerimeter()
        {
            Console.WriteLine("{0}", A+B);
        }
    }
}
