using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace EkzmenApp
{
    public class Stel
    {
        [Key]
        public int IDСтеллажа { get; set; }
        public string НазваниеСтеллажа { get; set; }
        public int НомерПолки { get; set; }
        public int КолвоКниг { get; set; }
    }
}
