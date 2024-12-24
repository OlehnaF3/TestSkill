namespace TestSkill.HomeWork
{
    class Order : AbstractsOrder
    {
        private int _id;
        private string _nameOrder;
        private OrderDetails _orderdetails;
        public override int Id
        {
            get
            {
                return _id;
            }
            protected set
            {
                if (value > 0)
                {
                    _id = value;
                }

                _id =  default ;
            }
        }

        public override string NameOrder
        {
            get
            {
                return _nameOrder;
            }
           protected set
            {
                if(!string.IsNullOrEmpty(value)) 
                {
                _nameOrder = value;
                    return;
                }
                 _nameOrder = "Unkown";
            }
        }
        public override OrderDetails OrderDetails 
        {
            get
            {
                return _orderdetails;
            }
                
             protected set
            {
                if (value != null)
                {
                    _orderdetails = value;
                }
                _orderdetails = new OrderDetails();

            } 
        }
        /// <summary>
        /// Приоритет доставки! У каждого заказа свой приоритет. Базовый класс имеет значение 100
        /// </summary>
        private int _priorityDelivery;
        public override int PriorityDelivery
        {
            get
            { 
                return _priorityDelivery;
            }
            protected set
            {
                switch (OrderDetails.TypeOrder)
                {
                    case EnumTypeOrder.OrderPickup:
                        _priorityDelivery = 0;
                        break;
                    case EnumTypeOrder.ExpressOrder:
                        _priorityDelivery = 50;
                        break;
                    case EnumTypeOrder.InteriorOrder:
                        _priorityDelivery = 20;
                        break;
                    default:
                        _priorityDelivery = 100;
                        break;
                }
            }
        }


        public Order(int id, string nameOrder, OrderDetails orderdetails)
        {
            Id = id;
            NameOrder = nameOrder;
            OrderDetails = orderdetails;

        }

        public Order(OrderDetails details)
        {
            Random ran = new Random();
            Id = Convert.ToInt32(ran.Next(100));
            _orderdetails = details;
        }

        /// <summary>
        /// Отображение деталей заказа
        /// </summary>
        public virtual void ShowOrder()
        {
            Console.WriteLine($"Id = {Id},{Environment.NewLine}AdressDelivery = {OrderDetails.AdressDelivery},{Environment.NewLine},DataDelivery = {OrderDetails.DataDelivery},{Environment.NewLine} Order is ready = {CheckOrderIsReady()} ");
        }

        /// <summary>
        /// Проверка на готовность заказа
        /// </summary>
        /// <returns>Возвращает строку</returns>
        public override string CheckOrderIsReady()
        {
            return OrderDetails.IsReady ? "Yes" : "No";
        }

        public override string ToString()
        {
            return $"{Id},{_orderdetails.AdressDelivery},{_orderdetails.DataDelivery}";
        }

    }
}
