using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetersRestraunt_Models
{
    public class restrauntTables
    {
        [Key]
        public int tableId { get; set; }
        public string tableName { get; set; }
      
    }
}
