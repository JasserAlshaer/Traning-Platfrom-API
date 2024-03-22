using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traning_Platfrom_Core.Dtos.Testimonal
{
    public class TestimonalDTO
    {
        public int Id { get; set; }
        public string JobSeekerName { get; set; }
        public string Image { get; set; }
        public string Major { get; set; }
        public string Comment { get; set; }
        public int RateCount { get; set; }
    }
}
