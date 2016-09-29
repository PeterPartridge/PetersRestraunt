using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetersRestraunt_Models
{
   public class bookTable
    {
        public string Id { get; set; }

       [Key]
        public int bookedTable { get; set; }

        public int tableId { get; set; }

        public int orderId { get; set; }

        public int numberInParty { get; set; }

        public DateTime whenTableBooked { get; set; }

       [ForeignKey("tableId")]
        public virtual restrauntTables restrauntTable { get; set; }

       [ForeignKey("orderId")]
        public virtual Order order { get; set; }
    }
}
