using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace EkzmenApp
{
    public class Ot
    {
        [Key]
        public int IDОтчета { get; set; }
        public int IDПродажи { get; set; }
        public DateTime ДатаОтчета { get; set; }
        public decimal ИтогЗаМесяц { get; set; }
        public string НомерОтчета { get; set; }

    }
}
