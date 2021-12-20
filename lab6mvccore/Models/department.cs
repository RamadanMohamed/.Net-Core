using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace lab6mvccore.Models
{
    public class department
    {
        [Key]
        public int deptid { get; set; }
        public string deptname { get; set; }
        public List <Student> students { get; set; }

    }
}
