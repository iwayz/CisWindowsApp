using System;

namespace Cis.DataContract
{
    public interface IEntity
    {
        Guid Id { get; set; }
        string CreatedBy { get; set; }
        DateTime CreatedAt { get; set; }
        string ModifiedBy { get; set; }
        DateTime ModifiedAt { get; set; }
    }
}
