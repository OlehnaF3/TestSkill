namespace Prog.HomeWork
{
    public class Program
    {
        public static void Main(string[] args)
        {
            OrderDetails orderDetails = new OrderDetails();
            OrderDetails orderDetails1 = new OrderDetails();
            ExportOrder export = new ExportOrder(1,orderDetails1);
            Order order = new Order(orderDetails);
            Console.WriteLine(order.ToString());
            Console.WriteLine(export.ToString());
            Console.WriteLine(export.ShowDeliveryTime());

        }
    }
}


