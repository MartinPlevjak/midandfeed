using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace midandfeed.Models
{
    public class News
    {   public int ID { get; set; }
        [Display(Name = "Názov príspevku")]
        public string NewsName { get; set; }
        public string Autor { get; set; }
        [Display(Name = "Dátum pridania")]
        public DateTime CreatedAt { get; set; }
        [Display(Name = "Popis")]
        public string Body { get; set; }
    }
}
