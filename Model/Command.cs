using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Command:Base.Entity
    {
        public Command() : base()
        { }

        [Key]
        public int Id { set; get; }

        public string name { set; get; }

        [Required]
        [MaxLength(10)]
        public string line { set; get; }
    }
}
