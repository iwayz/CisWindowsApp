using System;
using System.Collections.Generic;

namespace Cis.Model
{
    public class StockAdjustment : BaseEntity
    {
        public string AdjustmentNumber { get; set; }
        public DateTime AdjustmentDate { get; set; }
        public AdjustmentReason Reason { get; set; }
        public string Notes { get; set; }
        public PostingStatus PostingStatus { get; set; }
        public string UserId { get; set; }
        public string Username { get; set; }
        public string StockOpnameId { get; set; }

        public User User { get; set; }
        public StockOpname StockOpname { get; set; }

        public ICollection<StockAdjustmentItem> StockAdjustmentItems { get; set; }
    }
}
