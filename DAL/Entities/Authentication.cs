using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Entities
{
    public class Authentication
    {
        [Key]
        public Int32 AuthId { get; set; }
        [Required]
        public String AuthName { get; set; }
        [ForeignKey("AuthLevelRefId")]
        public ICollection<User> Users { get; set; }

    }
}
