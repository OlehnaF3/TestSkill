namespace TestSkill
{
    class Car
    {
        public double Fuel;
        public int Mileage;
        public Car() 
        {
            Fuel = 50;
            Mileage = 0;
        }
        public void MoveCar()
        {
            Mileage++;
            Fuel -= 0.5;
        }
        public void FillCar()
        {
            Fuel = 50;
        }
    }
}
