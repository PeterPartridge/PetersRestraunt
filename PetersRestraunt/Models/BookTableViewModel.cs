using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PetersRestraunt_Models;

namespace PetersRestraunt.Models
{
    public class BookTableViewModel
    {
       public IEnumerable<restrauntTables> tables { get; set; }
       public int peopleInParty { get; set; }
    }
}