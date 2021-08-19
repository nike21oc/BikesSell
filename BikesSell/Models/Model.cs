using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BikesSell.Models
{
    public class Model
    {
        public int Id { get; set; }

        [Required]
        public string ModelName { get; set; }

        public Make Make { get; set; }

        [ForeignKey("Make")]
        public int MakeFk { get; set; }
    }
}
