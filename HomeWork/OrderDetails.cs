using System.Data;

namespace TestSkill.HomeWork
{
     class OrderDetails
    {
       public int Id { get; private set; }
       public string AdressDelivery { get; private set; }
       public DateTime DataDelivery { get; private set; }
        private bool _isReady;
       public bool IsReady { get
            { 
                return IsReady;
            } 
            private set
            { 
                if(DataDelivery == DateTime.Today)
                {
                    _isReady = true;
                    return;
                }

                _isReady = false; 

            }
        }
       public EnumTypeOrder TypeOrder { get; private set; }
        public OrderDetails(string adressDelivery, DateTime dateDelivery,EnumTypeOrder typeOrder)
        {
            AdressDelivery = adressDelivery??"Unknown";
            DataDelivery = dateDelivery;
            TypeOrder = typeOrder;
            IsReady = false;
        }
        public OrderDetails() 
        {
            AdressDelivery = "Unknown";
            DataDelivery = DateTime.Now.AddDays(5);
            TypeOrder = EnumTypeOrder.Default;
            IsReady= false;
        }

        /// <summary>
        /// Обновление деталей заказа, 
        /// </summary>
        /// <param name="adressDelivery">Адрес доставки</param>
        /// <param name="dateTime">Дата доставки</param>
        public void UpdateOrderDetails(string adressDelivery,DateTime dateTime)
        {
            AdressDelivery = adressDelivery;
            DataDelivery = dateTime;
        }
        /// <summary>
        /// Обновление даты доставки 
        /// </summary>
        /// <param name="dataShipped"></param>
        /// <param name="dayOfDelivery">По умолчанию 30 дней</param>
        public void UpdateOrderDetails(DateTime dataShipped,int dayOfDelivery = 30)
        {
            DataDelivery = dataShipped.AddDays(dayOfDelivery);
        }
    }
    
    
}
