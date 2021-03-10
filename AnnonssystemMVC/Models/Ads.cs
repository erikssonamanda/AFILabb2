using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AnnonssystemMVC.Models
{
    public class Ads
    {
        public int Ad_Id { get; set; }
        public int Ad_Annonsor { get; set; }
        public string Ad_Rubrik { get; set; }
        public string Ad_Innehall { get; set; }
        public int Ad_VaransPris { get; set; }
        public int Ad_AnnonsPris { get; set; }
    }
}
