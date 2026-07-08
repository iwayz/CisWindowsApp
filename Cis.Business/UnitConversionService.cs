using Cis.Data;
using System.Collections.Generic;
using System.Linq;

namespace Cis.Business
{
    public class UnitOption
    {
        public string UnitId { get; set; }
        public string UomCode { get; set; }
        public int ConversionQty { get; set; } // how many base units 1 of this unit equals
    }

    public class UnitConversionService
    {
        private readonly CisDbContext _db;

        public UnitConversionService(CisDbContext db)
        {
            _db = db;
        }

        // Converts a quantity expressed in unitId into the product's base-unit quantity.
        // Falls back to qty unchanged if the product or a packaging factor can't be found.
        public int ToBaseQty(string productId, string unitId, int qty)
        {
            var product = _db.Products.Find(productId);
            if (product == null || unitId == product.UnitId) return qty;

            var packaging = _db.ProductPackagings
                .FirstOrDefault(p => p.ProductId == productId && p.UnitId == unitId);
            return packaging == null ? qty : qty * packaging.ConversionQty;
        }

        // Base unit (factor 1) first, followed by any packaging units defined for the product.
        public List<UnitOption> GetAvailableUnits(string productId)
        {
            var result = new List<UnitOption>();
            var product = _db.Products.Find(productId);
            if (product == null) return result;

            var baseUnit = _db.UnitOfMeasurements.Find(product.UnitId);
            result.Add(new UnitOption
            {
                UnitId = product.UnitId,
                UomCode = baseUnit?.UomCode,
                ConversionQty = 1
            });

            result.AddRange(_db.ProductPackagings
                .Where(p => p.ProductId == productId)
                .Select(p => new UnitOption
                {
                    UnitId = p.UnitId,
                    UomCode = p.Unit.UomCode,
                    ConversionQty = p.ConversionQty
                }));

            return result;
        }
    }
}
