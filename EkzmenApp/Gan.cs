using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace EkzmenApp
{
    public class Gan
    {
        [Key]
        public int IDЖанра { get; set; }
        public string НазваниеЖанра { get; set; }
    }
}
