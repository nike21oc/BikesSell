using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BikesSell.Models.ViewModel
{
    public class MakeModelViewModel
    {
        public Model Model { get; set; }

        public IEnumerable<Make> Makes { get; set; }
    }
}
