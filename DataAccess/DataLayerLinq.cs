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
        static ExamenSGBDEntities oExamenSgbdEntities = new ExamenSGBDEntities();

        public static int SelectNbreDeChaise(int idTables)
        {
            int nbreDePlace;
            try
            {
                nbreDePlace = oExamenSgbdEntities.TablesChaises.FirstOrDefault(x =>
                    x.idTables == idTables).nbreDePlaces;
                return nbreDePlace;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static int? SelectIdMenu(int idDetailReservation)
        {
            int? idMenu = null;
            try
            {
                if (oExamenSgbdEntities.SelectMenu(idDetailReservation).FirstOrDefault() != null)
                    idMenu = (Int32)oExamenSgbdEntities.SelectMenu(idDetailReservation).FirstOrDefault();

                return idMenu;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static List<Reservation> SelectListReservation()
        {
            try
            {
                List<Reservation> lstReservation = new List<Reservation>();
                lstReservation = oExamenSgbdEntities.Reservations.ToList();
                return lstReservation;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static void InsertReservation(string numero, int idTables, DateTime date, string prenom, string nom,
            int nombre)
        {
            try
            {
                oExamenSgbdEntities.InsertReservation(numero, idTables, date, prenom, nom, nombre);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static List<SelectAllRestaurants_Result> SelectAllRestaurants()
        {
            try
            {
                var valueToReturn = oExamenSgbdEntities.SelectAllRestaurants().ToList();
                return valueToReturn;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static List<SelectTablesByRestaurant_Result> SelectTablesByRestaurant(int idRestaurant, DateTime date)
        {
            try
            {
                var valueToReturn = oExamenSgbdEntities.SelectTablesByRestaurant(idRestaurant, date).ToList();
                return valueToReturn;
            }
            catch (Exception)
            {
                throw;
            }

        }

        public static List<TablesChaise> SelectTablesChaise()
        {
            try
            {
                var valueToReturn = oExamenSgbdEntities.TablesChaises.ToList();
                return valueToReturn;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static List<SelectParticipantsParReservation_Result> SelectParticipantsParReservation(int idReservation)
        {
            try
            {
                var valueToReturn = oExamenSgbdEntities.SelectParticipantsParReservation(idReservation).ToList();
                return valueToReturn;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static List<SelectCarteByRestaurantAndType_Result> SelectCarteByRestaurantAndType(int idRestaurant, int type)
        {
            try
            {
                var valueToReturn = oExamenSgbdEntities.SelectCarteByRestaurantAndType(idRestaurant, type).ToList();
                return valueToReturn;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static List<SelectCarteMenu_Result> SelectCarteMenu(int idMenu, int type)
        {
            try
            {
                var valueToReturn = oExamenSgbdEntities.SelectCarteMenu(idMenu, type).ToList();
                return valueToReturn;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static void UpdateReservation(int idReservation, int prixTotal)
        {
            try
            {
                oExamenSgbdEntities.ConfirmReservation(idReservation, prixTotal);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static void DeleteReservation(int idReservation)
        {
            try
            {
                oExamenSgbdEntities.DeleteReservation(idReservation);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static void InsertDetailReservation(int idReservation, string prenom, int entree, int plat, int dessert, int prix)
        {
            try
            {
                oExamenSgbdEntities.InsertDetailReservation(idReservation, prenom, entree, plat, dessert, prix);
            }
            catch (SqlException sqlex)
            {
                switch (sqlex.Number)
                {
                    case 4060:
                        throw new Exception(sqlex.Number + "Mauvaise DB");
                        break;
                    case 18456:
                        throw new Exception(sqlex.Number + "Mauvais user");
                        break;
                    case 515:
                        throw new Exception(sqlex.Number + " : Le prix ne peut être null");
                        break;
                    default:
                        throw new Exception(sqlex.Number + " : " + sqlex.Message);
                        break;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static List<DetailReservation> SelectDetailReservation()
        {
            try
            {
                var valueToReturn = oExamenSgbdEntities.DetailReservations.ToList();
                return valueToReturn;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static void UpdateDetailReservation(int idReservation, string prenom, int entree, int plat, int dessert, int prix)
        {
            try
            {
                oExamenSgbdEntities.UpdateDetailReservation(idReservation, prenom, entree, plat, dessert, prix);
            }
            catch (SqlException sqlex)
            {
                switch (sqlex.Number)
                {
                    case 4060:
                        throw new Exception(sqlex.Number + "Mauvaise DB");
                        break;
                    case 18456:
                        throw new Exception(sqlex.Number + "Mauvais user");
                        break;
                    case 515:
                        throw new Exception(sqlex.Number + " : Le prix ne peut être null");
                        break;
                    default:
                        throw new Exception(sqlex.Number + " : " + sqlex.Message);
                        break;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static void UpdateDetailReservationMenu(int idReservation, string prenom, int entree, int plat, int dessert, int prix, int idMenu)
        {
            try
            {
                oExamenSgbdEntities.UpdateDetailReservationMenu(idReservation, prenom, entree, plat, dessert, prix, idMenu);
            }
            catch (SqlException sqlex)
            {
                switch (sqlex.Number)
                {
                    case 4060:
                        throw new Exception(sqlex.Number + "Mauvaise DB");
                        break;
                    case 18456:
                        throw new Exception(sqlex.Number + "Mauvais user");
                        break;
                    case 515:
                        throw new Exception(sqlex.Number + " : Le prix ne peut être null");
                        break;
                    default:
                        throw new Exception(sqlex.Number + " : " + sqlex.Message);
                        break;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static List<CarteRestaurant> SelectCarteRestaurant()
        {
            try
            {
                var valueToReturn = oExamenSgbdEntities.CarteRestaurants.ToList();
                return valueToReturn;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static int SumPrixDetailReservation(int idReservation)
        {
            try
            {
                int valueToReturn = (Int32)oExamenSgbdEntities.SumPrixDetailReservation(idReservation).FirstOrDefault();
                return valueToReturn;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static List<Menu> SelectMenu()
        {
            try
            {
                var valueToReturn = oExamenSgbdEntities.Menus.ToList();
                return valueToReturn;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static List<DetailMenu> SelectDetailMenu()
        {
            try
            {
                var valueToReturn = oExamenSgbdEntities.DetailMenus.ToList();
                return valueToReturn;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static void InsertDetailReservationMenu(int idReservation, string prenom, int entree, int plat, int dessert, int prix, int idMenu)
        {
            try
            {
                oExamenSgbdEntities.InsertDetailReservationMenu(idReservation, prenom, entree, plat, dessert, prix, idMenu);
            }
            catch (SqlException sqlex)
            {
                switch (sqlex.Number)
                {
                    case 4060:
                        throw new Exception(sqlex.Number + "Mauvaise DB");
                        break;
                    case 18456:
                        throw new Exception(sqlex.Number + "Mauvais user");
                        break;
                    case 515:
                        throw new Exception(sqlex.Number + " : Le prix ne peut être null");
                        break;
                    default:
                        throw new Exception(sqlex.Number + " : " + sqlex.Message);
                        break;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
