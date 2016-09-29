using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetersRestraunt_Models
{
    public class Menu
    {
        [Key]
        public int menuId { get; set; }
        public string menuItem { get; set; }
        public bool isThisVegaterian { get; set; }
        public bool isThisGlutenFree { get; set; }
    }
}
