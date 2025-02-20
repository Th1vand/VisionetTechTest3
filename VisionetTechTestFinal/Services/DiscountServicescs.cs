using VisionetTechTestFinal.Model;
using static VisionetTechTestFinal.Model.CustomerModel;

namespace VisionetTechTestFinal.Services
{
    public class DiscountServicescs
    {
        public Customer CalculateDiscount(Customer customer)
        {
            if(customer.Type.ToLower() == "platinum") 
            { 
                if( customer.PointReward >= 100 && customer.PointReward <= 300)
                {
                    customer.Discount = customer.TotalPrice * (50m / 100) + 35;
                }
                else if (customer.PointReward >= 301 && customer.PointReward <= 500)
                {
                    customer.Discount = customer.TotalPrice * (50m / 100) + 50;
                }
                else if (customer.PointReward > 500)
                {
                    customer.Discount = customer.TotalPrice * (50m / 100) + 68;
                }
            }
            else if(customer.Type.ToLower() == "gold")
            {
                if (customer.PointReward >= 100 && customer.PointReward <= 300)
                {
                    customer.Discount = customer.TotalPrice * (25m / 100) + 25;
                }
                else if (customer.PointReward >= 301 && customer.PointReward <= 500)
                {
                    customer.Discount = customer.TotalPrice * (25m / 100) + 34;
                }
                else if (customer.PointReward > 500)
                {
                    customer.Discount = customer.TotalPrice * (25m / 100) + 52;
                }
            }
            else if (customer.Type.ToLower() == "silver")
            {
                if (customer.PointReward >= 100 && customer.PointReward <= 300)
                {
                    customer.Discount = customer.TotalPrice * (10m / 100) + 12;
                }
                else if (customer.PointReward >= 301 && customer.PointReward <= 500)
                {
                    customer.Discount = customer.TotalPrice * (10m / 100) + 27;
                }
                else if (customer.PointReward > 500)
                {
                    customer.Discount = customer.TotalPrice * (10m / 100) + 39;
                }
            }

            customer.TotalPayment = customer.TotalPrice - customer.Discount;



            return customer;

        }
    }
}
