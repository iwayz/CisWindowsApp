using System;
using System.Collections.Generic;

namespace Cis.Model
{
    public class StockOpname : BaseEntity
    {
        public string OpnameNumber { get; set; }
        public StockOpnameType OpnameType { get; set; }
        public DateTime OpnameDate { get; set; }
        public string Notes { get; set; }
        public PostingStatus PostingStatus { get; set; }
        public string UserId { get; set; }
        public string Username { get; set; }

        public User User { get; set; }

        public ICollection<StockOpnameItem> StockOpnameItems { get; set; }
    }
}
