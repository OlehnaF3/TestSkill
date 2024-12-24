namespace TestSkill.HomeWork
{
    internal abstract class AbstractsOrder
    {
        public abstract int PriorityDelivery { get; protected set; }
        public abstract int Id { get; protected set; }
        public abstract string NameOrder { get; protected set; }
        public abstract OrderDetails OrderDetails { get; protected set; }
        public abstract string CheckOrderIsReady();
    }
}