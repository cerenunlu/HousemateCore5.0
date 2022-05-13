using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Facilities
    {
        [Key]
        public int ID { get; set; }
        public bool Smoking { get; set; }
        public bool PetsAllowed { get; set; }
        public bool WashingMachine { get; set; }
        public bool Dishwasher { get; set; }
        public bool Cabletv { get; set; }
        public bool Internet { get; set; }
        public bool Status { get; set; }

    }
}
