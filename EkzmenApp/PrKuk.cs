using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace EkzmenApp
{
    public class PrKuk
    {
        [Key]
        public int IDПродажи { get; set; }
        [Key]
        public int IDКнига { get; set; }
    }
}
