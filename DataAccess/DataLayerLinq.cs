using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class DataLayerLinq
    {
        //static ExamenSGBDEntities oExamenSgbdEntities = new ExamenSGBDEntities();

        public static int SelectNbreDeChaise(int idTables)
        {
            int nbreDePlace;
            using (ExamenSGBDEntities oExamenSgbdEntities = new ExamenSGBDEntities())
            {
                nbreDePlace = oExamenSgbdEntities.TablesChaises.FirstOrDefault(x =>
                    x.idTables == idTables).nbreDePlaces;
            }
            return nbreDePlace;
        }

        public static int? SelectIdMenu(int idDetailReservation)
        {
            int? idMenu = null;
            using (ExamenSGBDEntities oExamenSgbdEntities = new ExamenSGBDEntities())
            {
                if (oExamenSgbdEntities.SelectMenu(idDetailReservation).FirstOrDefault() != null)
                    idMenu = (Int32) oExamenSgbdEntities.SelectMenu(idDetailReservation).FirstOrDefault();
            }

            return idMenu;
        }

        public static List<Reservation> SelectListReservation()
        {
            List<Reservation> lstReservation = new List<Reservation>();
            using (ExamenSGBDEntities oExamenSgbdEntities = new ExamenSGBDEntities())
            {
                lstReservation = oExamenSgbdEntities.Reservations.ToList();
            }

            return lstReservation;
        }

        public static void InsertReservation(string numero, int idTables, DateTime date, string prenom, string nom,
            int nombre)
        {
            using (ExamenSGBDEntities oExamenSgbdEntities = new ExamenSGBDEntities())
            {
                oExamenSgbdEntities.InsertReservation(numero, idTables, date, prenom, nom, nombre);
            }
        }

        public static List<SelectAllRestaurants_Result> SelectAllRestaurants()
        {
            List<SelectAllRestaurants_Result> valueToReturn;
            using (ExamenSGBDEntities oExamenSgbdEntities = new ExamenSGBDEntities())
            {
                valueToReturn = oExamenSgbdEntities.SelectAllRestaurants().ToList();
            }

            return valueToReturn;
        }

        public static List<SelectTablesByRestaurant_Result> SelectTablesByRestaurant(int idRestaurant, DateTime date)
        {
            List<SelectTablesByRestaurant_Result> valueToReturn;
            using (ExamenSGBDEntities oExamenSgbdEntities = new ExamenSGBDEntities())
            {
                valueToReturn = oExamenSgbdEntities.SelectTablesByRestaurant(idRestaurant, date).ToList();
            }

            return valueToReturn;
        }

        public static List<TablesChaise> SelectTablesChaise()
        {
            List<TablesChaise> valueToReturn;
            using (ExamenSGBDEntities oExamenSgbdEntities = new ExamenSGBDEntities())
            {
                valueToReturn = oExamenSgbdEntities.TablesChaises.ToList();
            }

            return valueToReturn;
        }

        public static List<SelectParticipantsParReservation_Result> SelectParticipantsParReservation(int idReservation)
        {
            List<SelectParticipantsParReservation_Result> valueToReturn;
            using (ExamenSGBDEntities oExamenSgbdEntities = new ExamenSGBDEntities())
            {
                valueToReturn = oExamenSgbdEntities.SelectParticipantsParReservation(idReservation).ToList();
            }

            return valueToReturn;
        }

        public static List<SelectCarteByRestaurantAndType_Result> SelectCarteByRestaurantAndType(int idRestaurant, int type)
        {
            List<SelectCarteByRestaurantAndType_Result> valueToReturn;
            using (ExamenSGBDEntities oExamenSgbdEntities = new ExamenSGBDEntities())
            {
                valueToReturn = oExamenSgbdEntities.SelectCarteByRestaurantAndType(idRestaurant, type).ToList();
            }

            return valueToReturn;
        }

        public static List<SelectCarteMenu_Result> SelectCarteMenu(int idMenu, int type)
        {
            List<SelectCarteMenu_Result> valueToReturn;
            using (ExamenSGBDEntities oExamenSgbdEntities = new ExamenSGBDEntities())
            {
                valueToReturn = oExamenSgbdEntities.SelectCarteMenu(idMenu, type).ToList();
            }

            return valueToReturn;
        }

        public static void UpdateReservation(int idReservation, int prixTotal)
        {
            using (ExamenSGBDEntities oExamenSgbdEntities = new ExamenSGBDEntities())
            {
                oExamenSgbdEntities.ConfirmReservation(idReservation, prixTotal);
            }
        }

        public static void DeleteReservation(int idReservation)
        {
            using (ExamenSGBDEntities oExamenSgbdEntities = new ExamenSGBDEntities())
            {
                oExamenSgbdEntities.DeleteReservation(idReservation);
            }
        }

        public static void InsertDetailReservation(int idReservation, string prenom, int entree, int plat, int dessert, int prix)
        {
            using (ExamenSGBDEntities oExamenSgbdEntities = new ExamenSGBDEntities())
            {
                oExamenSgbdEntities.InsertDetailReservation(idReservation, prenom, entree, plat, dessert, prix);
            }
        }

        public static List<DetailReservation> SelectDetailReservation()
        {
            List<DetailReservation> valueToReturn;
            using (ExamenSGBDEntities oExamenSgbdEntities = new ExamenSGBDEntities())
            {
                valueToReturn = oExamenSgbdEntities.DetailReservations.ToList();
            }

            return valueToReturn;
        }

        public static void UpdateDetailReservation(int idReservation, string prenom, int entree, int plat, int dessert, int prix)
        {
            using (ExamenSGBDEntities oExamenSgbdEntities = new ExamenSGBDEntities())
            {
                oExamenSgbdEntities.UpdateDetailReservation(idReservation, prenom, entree, plat, dessert, prix);
            }
        }

        public static void UpdateDetailReservationMenu(int idReservation, string prenom, int entree, int plat, int dessert, int prix, int idMenu)
        {
            using (ExamenSGBDEntities oExamenSgbdEntities = new ExamenSGBDEntities())
            {
                oExamenSgbdEntities.UpdateDetailReservationMenu(idReservation, prenom, entree, plat, dessert, prix,
                    idMenu);
            }
        }

        public static List<CarteRestaurant> SelectCarteRestaurant()
        {
            List<CarteRestaurant> valueToReturn;
            using (ExamenSGBDEntities oExamenSgbdEntities = new ExamenSGBDEntities())
            {
                valueToReturn = oExamenSgbdEntities.CarteRestaurants.ToList();
            }

            return valueToReturn;
        }

        public static int SumPrixDetailReservation(int idReservation)
        {
            int valueToReturn;
            using (ExamenSGBDEntities oExamenSgbdEntities = new ExamenSGBDEntities())
            {
                valueToReturn =
                    (Int32) oExamenSgbdEntities.SumPrixDetailReservation(idReservation).FirstOrDefault();
            }

            return valueToReturn;
        }

        public static List<Menu> SelectMenu()
        {
            List<Menu> valueToReturn;
            using (ExamenSGBDEntities oExamenSgbdEntities = new ExamenSGBDEntities())
            {
                valueToReturn = oExamenSgbdEntities.Menus.ToList();
            }

            return valueToReturn;
        }

        public static List<DetailMenu> SelectDetailMenu()
        {
            List<DetailMenu> valueToReturn;
            using (ExamenSGBDEntities oExamenSgbdEntities = new ExamenSGBDEntities())
            {
                valueToReturn = oExamenSgbdEntities.DetailMenus.ToList();
            }

            return valueToReturn;
        }

        public static void InsertDetailReservationMenu(int idReservation, string prenom, int entree, int plat, int dessert, int prix, int idMenu)
        {
            using (ExamenSGBDEntities oExamenSgbdEntities = new ExamenSGBDEntities())
            {
                oExamenSgbdEntities.InsertDetailReservationMenu(idReservation, prenom, entree, plat, dessert, prix,
                    idMenu);
            }
        }

        public static int SelectPrixGroupe(int idCarteRestaurant)
        {
            int valueToReturn;
            using (ExamenSGBDEntities oExamenSgbdEntities = new ExamenSGBDEntities())
            {
                valueToReturn =
                    (Int32) oExamenSgbdEntities.SelectPrixGroupe(idCarteRestaurant).FirstOrDefault();
            }

            return valueToReturn;
        }
    }
}
