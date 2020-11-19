using System;

namespace Cis.DataContract
{
    public interface IEntity
    {
        string Id { get; set; }

        // Audit fields.
        string CreatedBy { get; set; }
        DateTime CreatedAt { get; set; }
        string ModifiedBy { get; set; }
        DateTime ModifiedAt { get; set; }
    }
}
