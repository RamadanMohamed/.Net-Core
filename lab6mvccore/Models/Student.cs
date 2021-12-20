using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace lab6mvccore.Models
{
    public class Student
    {
        
        public int id{ get; set; }
        [Required,StringLength(10,MinimumLength =3)]
        public string name{ get; set; }
        [Range(10,20)]
        
        public int Age { get; set; }
        [ForeignKey ("department")]
        public int deptid { get; set; }
        public department department { get; set; }
    }
}
