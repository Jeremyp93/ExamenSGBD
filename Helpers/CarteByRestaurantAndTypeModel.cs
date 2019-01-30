using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helpers
{
    public class CarteByRestaurantAndTypeModel
    {
        public int idCarteRestaurant { get; set; }
        public int idRestaurant { get; set; }
        public int idCarteGroupe { get; set; }
        public string Element { get; set; }
    }
}
