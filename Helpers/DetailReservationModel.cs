using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helpers
{
    public class DetailReservationModel
    {
        public int idDetailReservation { get; set; }
        public int idReservation { get; set; }
        public string prenom { get; set; }
        public int entree { get; set; }
        public int plat { get; set; }
        public int dessert { get; set; }
        public int prixParPersonne { get; set; }

        public int? idMenu { get; set; }
    }
}
