using TestSkill.Enum;
namespace TestSkill
{
     class Pen
    {
        public EnumColor.Color Color;
        public int Cost;
       /// <summary>
       /// Коструктор с параметрами 
       /// </summary>
       /// <param name="color"></param>
       /// <param name="cost"></param>
        public Pen(EnumColor.Color color, int cost)
        {
            Color = color;
            Cost = cost;
        }
        /// <summary>
        /// Конструктор без параметров. Дефолтное значение Цвет - "Черный", а цена - "100"
        /// </summary>
        public Pen() 
        {
            Color = EnumColor.Color.Black;
            Cost = 100;
        }
    }
       
}
