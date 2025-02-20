namespace VisionetTechTestFinal.Model
{
    public class CustomerModel
    {
        public class Customer
        {
            public int Id { get; set; }
            public string Type { get; set; }
            public int PointReward { get; set; }
            public decimal TotalPrice { get; set; }
            public decimal Discount { get; set; }
            public decimal TotalPayment {  get; set; }
            
        }

    }
}
