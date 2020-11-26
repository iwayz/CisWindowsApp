using Cis.DataContract;
using System;
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
        [Column("ID")]
        public string Id { get; set; }

        [Column("CREATED_BY")]
        [MaxLength(20)]
        [Required]
        public string CreatedBy { get; set; }
        
        [Column("CREATED_AT")]
        [Required]
        public DateTime CreatedAt { get; set; }
        
        [Column("MODIFIED_BY")]
        [MaxLength(20)]
        [Required]
        public string ModifiedBy { get; set; }
        
        [Column("MODIFIED_AT")]
        [Required]
        public DateTime ModifiedAt { get; set; }
    }
}
