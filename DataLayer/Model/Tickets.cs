using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Model
{
    //comment dev-mohamed
    public class Tickets
    {
        [Key]
        public string shortGUID { get; set; }
        public string Combination { get; set; }
        public Sessions Sessions { get; set; }
    }
}
