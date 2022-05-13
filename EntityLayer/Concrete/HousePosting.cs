using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class HousePosting
    {
        [Key]
        public int ID { get; set; }
        public string Header { get; set; }
        public string Description { get; set; }
        public string Rent { get; set; }
        public string Size { get; set; }
        public string Period { get; set; }
        public string MovingIn { get; set; }
        public string Address { get; set; }
        public string Deposit { get; set; }
        public DateTime CreateDate { get; set; }
        public string MapLocation { get; set; }
        public bool Status { get; set; }
    }
}
