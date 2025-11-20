using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples
{
    public interface IDiscountType
    {
        decimal GetDiscount();
    }

    public class VipType : IDiscountType
    {
        public decimal GetDiscount() => 0.8m;
    }

    public class EmployeeType : IDiscountType
    {
        public decimal GetDiscount() => 0.5m;
    }

    public class DiscountService
    {
        public decimal ApplyDiscount(IDiscountType discountType)
        {
            return discountType.GetDiscount();
        }
    }
}