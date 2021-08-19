using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BikesSell.Models
{
    public class Make
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }


    }
}
