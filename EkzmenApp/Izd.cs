using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace EkzmenApp
{
    public class Izd
    {
        [Key]
        public int IDИздательство { get; set; }
        public string Наименование { get; set; }
        public string Адрес { get; set; }
        public string Телефон { get; set; }
    }
}
