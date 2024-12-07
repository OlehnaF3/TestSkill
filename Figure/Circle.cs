
namespace TestSkill.Figure
{
    class Circle
    {
            public double Radius;

        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>

            public Circle()
            {
                Radius = 5;
            }

        /// <summary>
        /// Конструктор с параметрами 
        /// </summary>
        /// <param name="radius"></param>
            public Circle(double radius)
            {
                Radius = radius;
            }

        /// <summary>
        /// Вычесление площади
        /// </summary>
            public void CalculationSquare()
            {
                Console.WriteLine("{0}", Math.PI * Math.Sqrt(Radius));
            }
        }

}
