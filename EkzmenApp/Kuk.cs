using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace EkzmenApp
{
    public class Kuk
    {
        [Key]
        public int IDКниги { get; set; }
        public int IDИздательства { get; set; }
        public int IDЖанра { get; set; }
        public int IDСтеллажа { get; set; }
        public string Наименование { get; set; }
        public int Артикул { get; set; }
        public string ВозрастныеОграничения { get; set; }
        public string КоличествоСтраниц { get; set; }
        public decimal Цена { get; set; }
        public string Описание { get; set; }
        public string ОбложкаКниги { get; set; }
    }
}
