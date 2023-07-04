using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Data.Domain
{
    public class BaseModel
    {
        [Key]
        public int Id { get; set; }
    }
}
