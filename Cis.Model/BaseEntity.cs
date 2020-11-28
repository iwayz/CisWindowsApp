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
        [MaxLength(36)]
        public string Id { get; set; }

        [Required, MaxLength(36)]
        public string CreatedBy { get; set; }
        
        [Required, DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime CreatedAt { get; set; }
        
        [Required, MaxLength(36)]
        public string ModifiedBy { get; set; }
        
        [Required, DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime ModifiedAt { get; set; }
    }
}
