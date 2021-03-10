using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AnnonssystemMVC.Models
{
    public class Prenumeranter
    {
        public int Pr_Id { get; set; }
        public string Pr_Fornamn { get; set; }
        public string Pr_Efternamn { get; set; }
        public string Pr_Utdelningsadress { get; set; }
        public int Pr_Postnummer { get; set; }
        public string Pr_Ort { get; set; }
        public string Pr_Epost { get; set; }
        public string Pr_Mobil { get; set; }
        public string Pr_Personnummer { get; set; }
    }
}
