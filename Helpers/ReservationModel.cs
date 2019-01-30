using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helpers
{
    public class ReservationModel
    {
        public int idReservation { get; set; }
        public string numeroReservation { get; set; }
        public int idTable { get; set; }
        public System.DateTime date { get; set; }
        public string prenom { get; set; }
        public string nom { get; set; }
        public int nbreDePersonnes { get; set; }
        public Nullable<int> prixTotal { get; set; }
        public int definitif { get; set; }
    }
}
