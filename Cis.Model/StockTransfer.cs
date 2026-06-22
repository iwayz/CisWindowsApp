using System;
using System.Collections.Generic;

namespace Cis.Model
{
    public class StockTransfer : BaseEntity
    {
        public string TransferNumber { get; set; }
        public StockTransferType TransferType { get; set; }
        public string BranchName { get; set; }
        public DateTime TransferDate { get; set; }
        public string Notes { get; set; }
        public PostingStatus PostingStatus { get; set; }
        public string UserId { get; set; }
        public string Username { get; set; }

        public User User { get; set; }

        public ICollection<StockTransferItem> StockTransferItems { get; set; }
    }
}
