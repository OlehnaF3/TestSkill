namespace TestSkill
{
    class Bus
    {
        public int? Load;
        public Bus(int? load)
        {
           Load = load;
        }
        public void PrintStatus()
        {
            if (Load == null || Load <=0)
            {
                Console.WriteLine("Bus is empty");
                return;
            }
            Console.WriteLine("The bus is loaded {0}",Load);
        }
    }
}
