using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using Helpers;

namespace BusinessLayer
{
    public class Manage
    {
        public static DataSet SelectGroupes()
        {
            try
            {
                DataSet dataToReturn = DataAccess.DataLayer.SelectGroupes();
                return dataToReturn;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static DataSet GetCarteMenuNoLinq(int idMenu, int type)
        {
            try
            {
                DataSet dataToReturn = DataAccess.DataLayer.SelectCarteMenu(idMenu, type);
                return dataToReturn;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static DataSet SelectRestaurantsFromGroupe(int id)
        {
            try
            {
                DataSet dataToReturn = DataAccess.DataLayer.SelectRestaurantsFromGroupe(id);
                return dataToReturn;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static DataSet SelectCarteByType(int idGroupe, int idType)
        {
            try
            {
                DataSet dataToReturn = DataAccess.DataLayer.SelectCarteByType(idGroupe, idType);
                return dataToReturn;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static DataSet SelectCarteRestaurantByType(int idRestaurant, int idType)
        {
            try
            {
                DataSet dataToReturn = DataAccess.DataLayer.SelectCarteRestaurantByType(idRestaurant, idType);
                return dataToReturn;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static void InsertCarteRestaurant(int idRestaurant, int idCarteGroupe)
        {
            try
            {
                DataAccess.DataLayer.InsertCarteRestaurant(idRestaurant, idCarteGroupe);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static void InsertCarteRestaurantMenu(int idMenu, int idCarteRestaurant)
        {
            try
            {
                DataAccess.DataLayer.InsertCarteRestaurantMenu(idMenu, idCarteRestaurant);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static void DeleteCarteRestaurant(int idCarteRestaurant)
        {
            try
            {
                DataAccess.DataLayer.DeleteCarteRestaurant(idCarteRestaurant);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static void InsertMenu(int idRestaurant)
        {
            try
            {
                DataAccess.DataLayer.InsertMenu(idRestaurant);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static void DeleteCarteRestaurantMenu(int idDetailMenu)
        {
            try
            {
                DataAccess.DataLayer.DeleteCarteRestaurantMenu(idDetailMenu);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static void DeleteMenu(int idMenu)
        {
            try
            {
                DataAccess.DataLayer.DeleteMenu(idMenu);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static string SelectPrixMinmumGroupe(int idCarteGroupe)
        {
            try
            {
                string dataToReturn = DataAccess.DataLayer.SelectPrixMinimumGroupe(idCarteGroupe);
                return dataToReturn;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static List<int> SelectidMenuReservation()
        {
            try
            {
                List<int> dataToReturn = DataAccess.DataLayer.SelectidMenuReservation();
                return dataToReturn;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static DataSet SelectMenuByRestaurant(int idRestaurant)
        {
            try
            {
                DataSet dataToReturn = DataAccess.DataLayer.SelectMenu(idRestaurant);
                return dataToReturn;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static string SelectPrixCarte(int idCarteRestaurant)
        {
            try
            {
                string dataToReturn = DataAccess.DataLayer.SelectPrixCarte(idCarteRestaurant);
                return dataToReturn;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static void UpdatePrixCarteRestaurant(int idCarteRestaurant, int prix)
        {
            try
            {
                DataAccess.DataLayer.UpdatePrixCarteRestaurant(idCarteRestaurant, prix);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public static int GetNbreChaise(int idTables)
        {
            try
            {
                int dataToReturn = DataAccess.DataLayerLinq.SelectNbreDeChaise(idTables);
                return dataToReturn;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static int GetIdDetailMenu(int idMenu, int idCarteRestaurant)
        {
            try
            {
                int dataToReturn = DataAccess.DataLayer.SelectIdDetailMenu(idMenu, idCarteRestaurant);
                return dataToReturn;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static DataSet GetReservationByRestaurantAndDate(DateTime date, int idRestaurant)
        {
            try
            {
                DataSet oDataSet = DataLayer.SelectReservationByRestaurantAndDate(date, idRestaurant);
                return oDataSet;

            }
            catch (Exception)
            {
                throw;
            }
        }

        public static DataSet GetReservationByRestaurantAndDateAndReservation(DateTime date, int idRestaurant, int idReservation)
        {
            try
            {
                DataSet oDataSet = DataLayer.SelectReservationByRestaurantAndDateAndReservation(date, idRestaurant, idReservation);
                return oDataSet;

            }
            catch (Exception)
            {
                throw;
            }
        }

        public static DataSet GetParticipantsParReservation(int idReservation)
        {
            try
            {
                DataSet oDataSet = DataLayer.SelectParticipantsParReservation(idReservation);
                return oDataSet;

            }
            catch (Exception)
            {
                throw;
            }
        }

        public static string GetElement(int idCarteRestaurant)
        {
            try
            {
                string dataToReturn = DataAccess.DataLayer.SelectElement(idCarteRestaurant);
                return dataToReturn;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static int GetPrixElement(int idCarteRestaurant)
        {
            try
            {
                int dataToReturn = DataAccess.DataLayer.SelectPrixElement(idCarteRestaurant);
                return dataToReturn;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static List<ReservationModel> GetListReservation()
        {
            try
            {
                var lstToReturn = new List<ReservationModel>();
                foreach (var reservation in DataLayerLinq.SelectListReservation())
                {
                    lstToReturn.Add(new ReservationModel
                    {
                        idReservation = reservation.idReservation,
                        numeroReservation = reservation.numeroReservation,
                        idTable = reservation.idTable,
                        date = reservation.date,
                        prenom = reservation.prenom,
                        nom = reservation.nom,
                        nbreDePersonnes = reservation.nbreDePersonnes,
                        prixTotal = reservation.prixTotal,
                        definitif = reservation.definitif
                    });
                }

                return lstToReturn;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static void AjouterReservation(string numero, int idTables, DateTime date, string prenom, string nom,
            int nombre)
        {
            try
            {
                DataLayerLinq.InsertReservation(numero, idTables, date, prenom, nom, nombre);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static List<AllRestaurantModel> GetAllRestaurant()
        {
            try
            {
                var lstToReturn = new List<AllRestaurantModel>();
                foreach (var restaurant in DataLayerLinq.SelectAllRestaurants())
                {
                    lstToReturn.Add(new AllRestaurantModel
                    {
                        idRestaurants = restaurant.idRestaurants,
                        RESTO = restaurant.RESTO
                    });
                }

                return lstToReturn;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static List<TablesByRestaurantModel> GetTablesByRestaurant(int idRestaurant, DateTime date)
        {
            try
            {
                var lstToReturn = new List<TablesByRestaurantModel>();
                foreach (var table in DataLayerLinq.SelectTablesByRestaurant(idRestaurant, date))
                {
                    lstToReturn.Add(new TablesByRestaurantModel
                    {
                        idTables = table.idTables,
                        TABLECHAISE = table.TABLECHAISE
                    });
                }

                return lstToReturn;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static List<TablesChaiseModel> GetTables()
        {
            try
            {
                var lstToReturn = new List<TablesChaiseModel>();
                foreach (var table in DataLayerLinq.SelectTablesChaise())
                {
                    lstToReturn.Add(new TablesChaiseModel
                    {
                        idTables = table.idTables,
                        idRestaurant = table.idRestaurant,
                        nbreDePlaces = table.nbreDePlaces
                    });
                }

                return lstToReturn;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static List<ParticipantParReservationModel> GetParticipantParReservation(int idReservation)
        {
            try
            {
                var lstToReturn = new List<ParticipantParReservationModel>();
                foreach (var participant in DataLayerLinq.SelectParticipantsParReservation(idReservation))
                {
                    lstToReturn.Add(new ParticipantParReservationModel
                    {
                        idDetailReservation = participant.idDetailReservation,
                        prenom = participant.prenom,
                        entree = participant.entree,
                        plat = participant.plat,
                        dessert = participant.dessert,
                        prixParPersonne = participant.prixParPersonne,
                        idMenu = participant.idMenu
                    });
                }

                return lstToReturn;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static List<CarteByRestaurantAndTypeModel> GetCarteByRestaurantAndType(int idRestaurant, int type)
        {
            try
            {
                var lstToReturn = new List<CarteByRestaurantAndTypeModel>();
                foreach (var carteRestaurant in DataLayerLinq.SelectCarteByRestaurantAndType(idRestaurant, type))
                {
                    lstToReturn.Add(new CarteByRestaurantAndTypeModel
                    {
                        idCarteRestaurant = carteRestaurant.idCarteRestaurant,
                        idRestaurant = carteRestaurant.idRestaurant,
                        idCarteGroupe = carteRestaurant.idCarteGroupe,
                        Element = carteRestaurant.Element
                    });
                }

                return lstToReturn;
            }
            catch (Exception)
            {
                throw;
            }
        }



        public static List<CarteMenuModel> GetCarteMenu(int idMenu, int type)
        {
            try
            {
                var lstToReturn = new List<CarteMenuModel>();
                foreach (var carteEntreeMenu in DataLayerLinq.SelectCarteMenu(idMenu, type))
                {
                    lstToReturn.Add(new CarteMenuModel
                    {
                        idCarteRestaurant = carteEntreeMenu.idCarteRestaurant,
                        idRestaurant = carteEntreeMenu.idRestaurant,
                        idCarteGroupe = carteEntreeMenu.idCarteGroupe,
                        element = carteEntreeMenu.Element
                    });
                }

                return lstToReturn;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static void ConfirmerReservation(int idReservation, int prixTotal)
        {
            try
            {
                DataLayerLinq.UpdateReservation(idReservation, prixTotal);
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
                DataLayerLinq.DeleteReservation(idReservation);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static void AjouteDetailReservation(int idReservation, string prenom, int entree, int plat, int dessert, int prix)
        {
            try
            {
                DataLayerLinq.InsertDetailReservation(idReservation, prenom, entree, plat, dessert, prix);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static List<DetailReservationModel> GetDetailReservation()
        {
            try
            {
                var lstToReturn = new List<DetailReservationModel>();
                foreach (var detail in DataLayerLinq.SelectDetailReservation())
                {
                    lstToReturn.Add(new DetailReservationModel
                    {
                        idDetailReservation = detail.idDetailReservation,
                        idReservation = detail.idReservation,
                        prenom = detail.prenom,
                        entree = detail.entree,
                        plat = detail.plat,
                        dessert = detail.dessert,
                        prixParPersonne = detail.prixParPersonne,
                        idMenu = detail.idMenu
                    });
                }

                return lstToReturn;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static void ModifierDetailReservation(int idReservation, string prenom, int entree, int plat, int dessert, int prix)
        {
            try
            {
                DataLayerLinq.UpdateDetailReservation(idReservation, prenom, entree, plat, dessert, prix);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static void ModifierDetailReservationMenu(int idReservation, string prenom, int entree, int plat, int dessert, int prix, int idMenu)
        {
            try
            {
                DataLayerLinq.UpdateDetailReservationMenu(idReservation, prenom, entree, plat, dessert, prix, idMenu);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static List<CarteRestaurantModel> GetCarteRestaurant()
        {
            try
            {
                var lstToReturn = new List<CarteRestaurantModel>();
                foreach (var carte in DataLayerLinq.SelectCarteRestaurant())
                {
                    lstToReturn.Add(new CarteRestaurantModel
                    {
                        idCarteRestaurant = carte.idCarteRestaurant,
                        idRestaurant = carte.idRestaurant,
                        idCarteGroupe = carte.idCarteGroupe,
                        Prix = carte.Prix
                    });
                }

                return lstToReturn;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static int SumPrixTotalReservation(int idReservation)
        {
            try
            {
                int valueToReturn = DataLayerLinq.SumPrixDetailReservation(idReservation);
                return valueToReturn;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static int? GetIdMenu(int idDetailReservation)
        {
            try
            {
                int? valueToReturn = DataLayerLinq.SelectIdMenu(idDetailReservation);
                return valueToReturn;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static List<MenuModel> GetMenus()
        {
            try
            {
                var lstToReturn = new List<MenuModel>();
                foreach (var menu in DataLayerLinq.SelectMenu())
                {
                    lstToReturn.Add(new MenuModel
                    {
                        idMenu = menu.idMenu,
                        idRestaurant = menu.idRestaurant
                    });
                }

                return lstToReturn;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static List<DetailMenuModel> GetDetailMenu()
        {
            try
            {
                var lstToReturn = new List<DetailMenuModel>();
                foreach (var detailMenu in DataLayerLinq.SelectDetailMenu())
                {
                    lstToReturn.Add(new DetailMenuModel
                    {
                        idDetailMenu = detailMenu.idDetailMenu,
                        idMenu = detailMenu.idMenu,
                        idCarteRestaurant = detailMenu.idCarteRestaurant
                    });
                }

                return lstToReturn;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static void AjouteDetailReservationMenu(int idReservation, string prenom, int entree, int plat, int dessert, int prix, int idMenu)
        {
            try
            {
                DataLayerLinq.InsertDetailReservationMenu(idReservation, prenom, entree, plat, dessert, prix, idMenu);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
