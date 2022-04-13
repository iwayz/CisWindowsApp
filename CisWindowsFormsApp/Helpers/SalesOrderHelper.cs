using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CisWindowsFormsApp
{
    public class SalesOrderHelper
    {
        public decimal CalculateGrossValue(decimal qty, decimal nettPrice)
        {
            return Math.Round(qty * nettPrice, 0, MidpointRounding.AwayFromZero);
        }

        public decimal CalculateTaxBaseAmount(decimal grossValue, decimal discountPercent)
        {
            return Math.Round(grossValue * (1 - discountPercent), 0, MidpointRounding.AwayFromZero);
        }

        public decimal CalculateTaxBaseAmount(decimal qty, decimal nettPrice, decimal discountPercent)
        {
            var grossValue = CalculateGrossValue(qty, nettPrice);

            return Math.Round(grossValue * (1 - discountPercent), 0, MidpointRounding.AwayFromZero);
        }

        public decimal CalculateTaxBaseAmount(decimal qty, decimal nettPrice, decimal discountPercent, decimal extraDiscountAmount)
        {
            var grossValue = CalculateGrossValue(qty, nettPrice);

            return Math.Round((grossValue * (1 - Convert.ToDecimal(discountPercent)) - extraDiscountAmount), 0, MidpointRounding.AwayFromZero);
        }

        public decimal CalculateValueAddedAmount(decimal taxBaseAmount, DateTime salesDate)
        {
            if (salesDate >= new DateTime(2022, 4, 1))
                return Math.Round(taxBaseAmount * Convert.ToDecimal(0.11), 0, MidpointRounding.AwayFromZero);

            return Math.Round(taxBaseAmount * Convert.ToDecimal(0.10), 0, MidpointRounding.AwayFromZero);
        }

        public decimal CalculateNettValueAmount(decimal taxBaseAmount, decimal valueAddedAmount)
        {
            return Math.Round(taxBaseAmount + valueAddedAmount, 0, MidpointRounding.AwayFromZero);
        }


    }
}
