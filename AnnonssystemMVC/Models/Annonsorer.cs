using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AnnonssystemMVC.Models
{
    public class Annonsorer
    {
        public int An_Id { get; set; }
        public string An_Fornamn { get; set; }
        public string An_Efternamn { get; set; }
        public string An_Foretagsnamn { get; set; }
        public string An_Organisationsnummer { get; set; }
        public string An_Utdelningsadress { get; set; }
        public string An_UPostnummer { get; set; }
        public string An_UOrt { get; set; }
        public string An_Fakturaadress { get; set; }
        public string An_FPostnummer { get; set; }
        public string An_FOrt { get; set; }
        public string An_Epost { get; set; }
        public string An_Mobil { get; set; }
        public string An_Personnummer { get; set; }
        public int An_AnnonsPris { get; set; }
    }
}
