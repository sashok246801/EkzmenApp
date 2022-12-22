using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace EkzmenApp
{
    public class Av
    {
        [Key]
        public int IDАвтора { get; set; }
        public string ФИО { get; set; }
        public DateTime ДатаРождения { get; set; }

    }
}
