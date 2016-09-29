using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetersRestraunt_Models
{
   public class Order
    {
       [Key]
        public int orderId { get; set; }

        public string Id { get; set; }

        public int bookTableId { get; set; }
       
       public int menuId { get; set; }
       
       public string menuItem { get; set; }
       
       public int menuAmount { get; set; }

       public DateTime orderMade { get; set; }
       [ForeignKey("menuId")]
       public virtual Menu menu { get; set; }

       [ForeignKey("bookTableId")]
       public virtual ICollection<bookTable> bookTable { get; set; }
   }
}
