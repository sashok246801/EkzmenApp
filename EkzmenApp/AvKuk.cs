using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace EkzmenApp
{
    public class AvKuk
    {
        [Key]
        public int IDАвтор { get; set; }
        [Key]
        public int IDКнига { get; set; }

    }
}
