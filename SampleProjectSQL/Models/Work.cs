using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace SampleProjectSQL.Models
{
    public class Work
    {
        public int ID { get; set; }
        public String JobTitle { get; set; }
        public String Description { get; set; }
        public int Quantity { get; set; }
        [DataType(DataType.Date)]
        public DateTime ExpireDate { get; set; }

    }
}