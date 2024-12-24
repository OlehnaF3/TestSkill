namespace TestSkill.HomeWork
{   class ExportOrder : Order
    {
        public int NumberContainer { get; private set; }
        public DateTime DataShipped { get; private set; }
        public override void ShowOrder()
        {
            Console.WriteLine("Class ExportOrder");
        }
        public ExportOrder(int numberContainer, OrderDetails details) : base(details)
        {
            NumberContainer = numberContainer;
            DataShipped = DateTime.Now;
            details.UpdateOrderDetails(DataShipped);
        }
        public override string ToString()
        {
            return $"{Id},{OrderDetails.AdressDelivery},{OrderDetails.DataDelivery},{DataShipped},{NumberContainer}";
        }
    }
}
