using Data.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models.Category
{
    public partial class Category : BaseModel
    { 
        [MaxLength(200)]
        [Required]
        public string Name { get; set; }
        [MaxLength(500)]
        public string Description { get; set; }
        [Required]
        public DateTime CreateOnUtc { get; set; }

        public int DisplayOrder { get; set; }
    }
}
