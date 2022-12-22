using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace EkzmenApp
{
    public class Pr
    {
        [Key]
        public int IDПродажи { get; set; }
        public int КолвоПродаж { get; set; }
        public DateTime ДатаСоставления { get; set; }

    }
}
