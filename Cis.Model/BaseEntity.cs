using Cis.DataContract;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cis.Model
{
    public class BaseEntity : IEntity
    {
        public BaseEntity()
        {
            Id = Guid.NewGuid().ToString();
        }

        [Key]
        [Column("ID"), MaxLength(36)]
        public string Id { get; set; }

        [Column("CREATED_BY"), Required, MaxLength(36)]
        public string CreatedBy { get; set; }
        
        [Column("CREATED_AT"), Required, DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime CreatedAt { get; set; }
        
        [Column("MODIFIED_BY"), Required, MaxLength(36)]
        public string ModifiedBy { get; set; }
        
        [Column("MODIFIED_AT"), Required, DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime ModifiedAt { get; set; }
    }
}
