using System;

namespace Cis.Model
{
    public class StockMovement : BaseEntity
    {
        public DateTime MovementDate { get; set; }
        public StockMovementType MovementType { get; set; }
        public MovementDirection Direction { get; set; }
        public string ProductId { get; set; }
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public string BatchId { get; set; }
        public string BatchCode { get; set; }
        public int Qty { get; set; }
        public string ReferenceType { get; set; }
        public string ReferenceId { get; set; }
        public string Remarks { get; set; }

        public Product Product { get; set; }
    }
}
