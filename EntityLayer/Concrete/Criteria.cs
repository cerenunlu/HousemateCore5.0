using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Criteria
    {
        [Key]
        public int ID { get; set; }
        public string PreferredGender { get; set; }
        public string Age { get; set; }
        public string Cleanliness { get; set; }
        public string Snoring { get; set; }
        public string PartyHabit { get; set; }
        public string AlcoholHabit { get; set; }
        public bool Status { get; set; }
    }
}
