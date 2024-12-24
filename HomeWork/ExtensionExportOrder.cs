namespace TestSkill.HomeWork
{ 
   static class ExtensionExportOrder
    {

        public static string ShowDeliveryTime(this ExportOrder export)
        {
            return $"{export.Id},{export.OrderDetails.DataDelivery - export.DataShipped}";
        }
    }
}
