namespace TestSkill.Figure
{
    class Triangle
    {
        public double A, B, C;
        public double HeigthTriangle {  get; private set; }
        public double Halfmeter  {get; private set; }
        public double HeightTriangle { get; private set; }
        public double SquareTrianlge { get; private set; }
        /// <summary>
        /// Коструктор по умолчанию A = 5,B = 5, C = 5;
        /// </summary>
        public Triangle()
        {
            A = 5;
            B = 5;
            C = 5;
            HeigthTriangle = CalculationHeigth();
            Halfmeter = CalculateHalfmeter();
            HeightTriangle = CalculationHeigth();
            SquareTrianlge = CalculationSquare();
        }
        /// <summary>
        /// Конструктор с параметрами
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        public Triangle(int a,int b,int c)
        {
            A=a; B=b; C=c;
            HeigthTriangle = CalculationHeigth();
            Halfmeter = CalculateHalfmeter();
            HeightTriangle = CalculationHeigth();
            SquareTrianlge = CalculationSquare();
        }
        /// <summary>
        /// Площать треугольника
        /// </summary>
        private float CalculationSquare()
        {
            return Convert.ToSingle(0.5 * A * HeightTriangle) ;
        }
        /// <summary>
        /// Периметр треугольника 
        /// </summary>
        /// <returns></returns>
        private double CalculationPerimeter() 
        {
            return A+B+C;  
        } 

        /// <summary>
        /// Вычесление полупериметра!
        /// </summary>
        /// <returns></returns>
        private double CalculateHalfmeter()
        {
            return CalculationPerimeter() / 2;
        }
        /// <summary>
        /// Вычисление высоты треугольника!
        /// </summary>
        /// <returns></returns>
        private double CalculationHeigth()
        {
            return 2 / A + Math.Sqrt(Halfmeter * (Halfmeter - A) * (Halfmeter - B) * (Halfmeter - C));
        }
        /// <summary>
        /// Пишет все свойства треугольника!
        /// </summary>
 
        public void ShowTriangleSize()
        {
            Console.WriteLine($"A = {A}\nB = {B}\nC = {C}\nHeigthTriangle = {HeightTriangle:F}\nSquare Trianlge = {SquareTrianlge:F}\nHalf meter = {Halfmeter:F}");
        }
    }
}
