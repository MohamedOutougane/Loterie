using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Model
{
    public class Sessions
    {
        [Key]
        public int Id { get; set; }
        public string Draw { get; set; }
        public int Jackpot { get; set; }
        public DateTime Date { get; set; }

        // stranger keys
        public List<Tickets> Tickets { get; set; } 
    }
}
