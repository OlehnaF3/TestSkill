namespace TestSkill
{
    class Rectangle
    {
        private int A;
        private int B;
        /// <summary>
        /// Конструктор по умолчанию! A = 6,B = 4 
        /// </summary>
        public Rectangle() 
        { 
            A=6; B=4;
        }
        /// <summary>
        /// Коструктор если A == B
        /// </summary>
        /// <param name="a"></param>
        public Rectangle(int a)
        {
            A = a;
            B = a;
        }
        /// <summary>
        /// Коструктор если A!=B
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        public Rectangle(int a ,int b)
        {
            A = a;
            B = b;
        }
        public void Square()
        {
            Console.WriteLine(A*B);
        }

    }
}
