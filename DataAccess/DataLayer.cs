using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class DataLayer
    {
        public static DataSet SelectGroupes()
        {
            DataSet dataToReturn = new DataSet();
            try
            {
                using (SqlConnection oConnection = new SqlConnection())
                {
                    oConnection.ConnectionString = Utils.oConn;

                    SqlCommand command = new SqlCommand();
                    command.Connection = oConnection;
                    oConnection.Open();

                    command.CommandText = "SelectGroupes";
                    command.CommandType = CommandType.StoredProcedure;

                    SqlDataAdapter oSqlDataAdapter = new SqlDataAdapter();
                    oSqlDataAdapter.SelectCommand = command;

                    oSqlDataAdapter.Fill(dataToReturn, "Groupes");
                }
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
            catch (Exception e)
            {
                throw e;
            }

            return dataToReturn;
        }

        public static DataSet SelectRestaurantsFromGroupe(int id)
        {
            DataSet dataToReturn = new DataSet();
            try
            {
                using (SqlConnection oConnection = new SqlConnection())
                {
                    oConnection.ConnectionString = Utils.oConn;

                    SqlCommand command = new SqlCommand();
                    command.Connection = oConnection;
                    oConnection.Open();

                    command.CommandText = "SelectRestaurantsFromGroupe";
                    command.CommandType = CommandType.StoredProcedure;
                    SqlParameter param1 = new SqlParameter("@groupe", id);
                    command.Parameters.Add(param1);

                    SqlDataAdapter oSqlDataAdapter = new SqlDataAdapter();
                    oSqlDataAdapter.SelectCommand = command;

                    oSqlDataAdapter.Fill(dataToReturn, "Restaurants");
                }
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
            catch (Exception e)
            {
                throw e;
            }

            return dataToReturn;
        }

        public static DataSet SelectCarteByType(int idGroupe, int idType)
        {
            DataSet dataToReturn = new DataSet();
            try
            {
                using (SqlConnection oConnection = new SqlConnection())
                {
                    oConnection.ConnectionString = Utils.oConn;

                    SqlCommand command = new SqlCommand();
                    command.Connection = oConnection;
                    oConnection.Open();

                    command.CommandText = "SelectCarteByGroupAndType";
                    command.CommandType = CommandType.StoredProcedure;
                    SqlParameter param1 = new SqlParameter("@idType", idType);
                    SqlParameter param2 = new SqlParameter("@idGroupe", idGroupe);
                    command.Parameters.Add(param1);
                    command.Parameters.Add(param2);

                    SqlDataAdapter oSqlDataAdapter = new SqlDataAdapter();
                    oSqlDataAdapter.SelectCommand = command;

                    oSqlDataAdapter.Fill(dataToReturn, "CarteGroupe");
                }
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
            catch (Exception e)
            {
                throw e;
            }

            return dataToReturn;
        }

        public static DataSet SelectCarteRestaurantByType(int idRestaurant, int idType)
        {
            DataSet dataToReturn = new DataSet();
            try
            {
                using (SqlConnection oConnection = new SqlConnection())
                {
                    oConnection.ConnectionString = Utils.oConn;

                    SqlCommand command = new SqlCommand();
                    command.Connection = oConnection;
                    oConnection.Open();

                    command.CommandText = "SelectCarteByRestaurantAndType";
                    command.CommandType = CommandType.StoredProcedure;
                    SqlParameter param1 = new SqlParameter("@idType", idType);
                    SqlParameter param2 = new SqlParameter("@idRestaurant", idRestaurant);
                    command.Parameters.Add(param1);
                    command.Parameters.Add(param2);

                    SqlDataAdapter oSqlDataAdapter = new SqlDataAdapter();
                    oSqlDataAdapter.SelectCommand = command;

                    oSqlDataAdapter.Fill(dataToReturn, "CarteRestaurant");
                }
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
            catch (Exception e)
            {
                throw e;
            }

            return dataToReturn;
        }

        public static List<int> SelectidMenuReservation()
        {
            var lstToReturn = new List<int>();
            try
            {
                using (SqlConnection oConnection = new SqlConnection())
                {
                    oConnection.ConnectionString = Utils.oConn;

                    SqlCommand command = new SqlCommand();
                    command.Connection = oConnection;
                    oConnection.Open();

                    command.CommandText = "SelectidMenuReservation";
                    command.CommandType = CommandType.StoredProcedure;

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            if (!reader.IsDBNull(0)) // Si la valeur n'est pas null
                                lstToReturn.Add(reader.GetInt32(0));
                        }
                    }
                }
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
            catch (Exception e)
            {
                throw e;
            }

            return lstToReturn;
        }

        public static void InsertCarteRestaurant(int idRestaurant, int idCarteGroupe)
        {
            try
            {
                using (SqlConnection oConnection = new SqlConnection())
                {
                    oConnection.ConnectionString = Utils.oConn;

                    SqlCommand command = new SqlCommand();
                    command.Connection = oConnection;
                    oConnection.Open();

                    command.CommandText = "InsertCarteRestaurant";
                    command.CommandType = CommandType.StoredProcedure;
                    SqlParameter param1 = new SqlParameter("@idRestaurant", idRestaurant);
                    SqlParameter param2 = new SqlParameter("@idCarteGroupe", idCarteGroupe);
                    command.Parameters.Add(param1);
                    command.Parameters.Add(param2);

                    command.ExecuteNonQuery();
                }
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
                    case 2601:
                        throw new Exception(sqlex.Number + " : Vous avez déjà ajouté cet element !");
                    default:
                        throw new Exception(sqlex.Number + " : " + sqlex.Message);
                        break;
                }

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
                using (SqlConnection oConnection = new SqlConnection())
                {
                    oConnection.ConnectionString = Utils.oConn;

                    SqlCommand command = new SqlCommand();
                    command.Connection = oConnection;
                    oConnection.Open();

                    command.CommandText = "InsertCarteRestaurantMenu";
                    command.CommandType = CommandType.StoredProcedure;
                    SqlParameter param1 = new SqlParameter("@idMenu", idMenu);
                    SqlParameter param2 = new SqlParameter("@idCarteRestaurant", idCarteRestaurant);
                    command.Parameters.Add(param1);
                    command.Parameters.Add(param2);

                    command.ExecuteNonQuery();
                }
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
                    case 2601:
                        throw new Exception(sqlex.Number + " : Vous avez déjà ajouté cet element !");
                    default:
                        throw new Exception(sqlex.Number + " : " + sqlex.Message);
                        break;
                }

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
                using (SqlConnection oConnection = new SqlConnection())
                {
                    oConnection.ConnectionString = Utils.oConn;

                    SqlCommand command = new SqlCommand();
                    command.Connection = oConnection;
                    oConnection.Open();

                    command.CommandText = "DeleteCarteRestaurant";
                    command.CommandType = CommandType.StoredProcedure;
                    SqlParameter param1 = new SqlParameter("@idCarteRestaurant", idCarteRestaurant);
                    command.Parameters.Add(param1);

                    command.ExecuteNonQuery();
                }
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
            catch (Exception e)
            {
                throw e;
            }
        }

        public static void InsertMenu(int idRestaurant)
        {
            try
            {
                using (SqlConnection oConnection = new SqlConnection())
                {
                    oConnection.ConnectionString = Utils.oConn;

                    SqlCommand command = new SqlCommand();
                    command.Connection = oConnection;
                    oConnection.Open();

                    command.CommandText = "InsertMenu";
                    command.CommandType = CommandType.StoredProcedure;
                    SqlParameter param1 = new SqlParameter("@idRestaurant", idRestaurant);
                    command.Parameters.Add(param1);

                    command.ExecuteNonQuery();
                }
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
            catch (Exception e)
            {
                throw e;
            }
        }

        public static void DeleteMenu(int idMenu)
        {
            try
            {
                using (SqlConnection oConnection = new SqlConnection())
                {
                    oConnection.ConnectionString = Utils.oConn;

                    SqlCommand command = new SqlCommand();
                    command.Connection = oConnection;
                    oConnection.Open();

                    command.CommandText = "DeleteMenu";
                    command.CommandType = CommandType.StoredProcedure;
                    SqlParameter param1 = new SqlParameter("@idMenu", idMenu);
                    command.Parameters.Add(param1);

                    command.ExecuteNonQuery();
                }
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
            catch (Exception e)
            {
                throw e;
            }
        }

        public static void DeleteCarteRestaurantMenu(int idDetailMenu)
        {
            try
            {
                using (SqlConnection oConnection = new SqlConnection())
                {
                    oConnection.ConnectionString = Utils.oConn;

                    SqlCommand command = new SqlCommand();
                    command.Connection = oConnection;
                    oConnection.Open();

                    command.CommandText = "DeleteCarteRestaurantMenu";
                    command.CommandType = CommandType.StoredProcedure;
                    SqlParameter param1 = new SqlParameter("@idDetailMenu", idDetailMenu);
                    command.Parameters.Add(param1);

                    command.ExecuteNonQuery();
                }
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
            catch (Exception e)
            {
                throw e;
            }
        }

        public static string SelectPrixMinimumGroupe(int idCarteGroupe)
        {
            string dataToReturn = "";
            try
            {
                using (SqlConnection oConnection = new SqlConnection())
                {
                    oConnection.ConnectionString = Utils.oConn;

                    SqlCommand command = new SqlCommand();
                    command.Connection = oConnection;
                    oConnection.Open();

                    command.CommandText = "SelectPrixMinimumGroupe";
                    command.CommandType = CommandType.StoredProcedure;
                    SqlParameter param1 = new SqlParameter("@idCarteGroupe", idCarteGroupe);
                    command.Parameters.Add(param1);

                    SqlDataReader myReader = command.ExecuteReader();
                    if (myReader.Read())
                    {
                        dataToReturn = myReader["PrixMinimum"].ToString();
                    }

                    myReader.Close();
                }
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
            catch (Exception e)
            {
                throw e;
            }

            return dataToReturn;
        }

        public static string SelectPrixCarte(int idCarteRestaurant)
        {
            string dataToReturn = "";
            try
            {
                using (SqlConnection oConnection = new SqlConnection())
                {
                    oConnection.ConnectionString = Utils.oConn;

                    SqlCommand command = new SqlCommand();
                    command.Connection = oConnection;
                    oConnection.Open();

                    command.CommandText = "SelectPrixCarte";
                    command.CommandType = CommandType.StoredProcedure;
                    SqlParameter param1 = new SqlParameter("@idCarteRestaurant", idCarteRestaurant);
                    command.Parameters.Add(param1);

                    SqlDataReader myReader = command.ExecuteReader();
                    if (myReader.Read())
                    {
                        dataToReturn = myReader["Prix"].ToString();
                    }

                    myReader.Close();
                }
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
            catch (Exception e)
            {
                throw e;
            }

            return dataToReturn;
        }

        public static void UpdatePrixCarteRestaurant(int idCarteRestaurant, int prix)
        {
            try
            {
                using (SqlConnection oConnection = new SqlConnection())
                {
                    oConnection.ConnectionString = Utils.oConn;

                    SqlCommand command = new SqlCommand();
                    command.Connection = oConnection;
                    oConnection.Open();

                    command.CommandText = "SetPrixCarteRestaurant";
                    command.CommandType = CommandType.StoredProcedure;
                    SqlParameter param1 = new SqlParameter("@idCarteRestaurant", idCarteRestaurant);
                    SqlParameter param2 = new SqlParameter("@prix", prix);
                    command.Parameters.Add(param1);
                    command.Parameters.Add(param2);

                    command.ExecuteNonQuery();
                }
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
                    case 50000:
                        throw new Exception(sqlex.Message);
                    default:
                        throw new Exception(sqlex.Number + " : " + sqlex.Message);
                        break;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static DataSet SelectReservationByRestaurantAndDate(DateTime date, int idRestaurant)
        {
            DataSet dataToReturn = new DataSet();
            try
            {
                using (SqlConnection oConnection = new SqlConnection())
                {
                    oConnection.ConnectionString = Utils.oConn;

                    SqlCommand command = new SqlCommand();
                    command.Connection = oConnection;
                    oConnection.Open();

                    command.CommandText = "SelectReservationParRestaurantJour";
                    command.CommandType = CommandType.StoredProcedure;
                    SqlParameter param1 = new SqlParameter("@date", date);
                    SqlParameter param2 = new SqlParameter("@idRestaurant", idRestaurant);
                    command.Parameters.Add(param1);
                    command.Parameters.Add(param2);

                    SqlDataAdapter oSqlDataAdapter = new SqlDataAdapter();
                    oSqlDataAdapter.SelectCommand = command;

                    oSqlDataAdapter.Fill(dataToReturn, "Reservation");
                }
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
            catch (Exception e)
            {
                throw e;
            }

            return dataToReturn;
        }

        public static DataSet SelectReservationByRestaurantAndDateAndReservation(DateTime date, int idRestaurant, int idReservation)
        {
            DataSet dataToReturn = new DataSet();
            try
            {
                using (SqlConnection oConnection = new SqlConnection())
                {
                    oConnection.ConnectionString = Utils.oConn;

                    SqlCommand command = new SqlCommand();
                    command.Connection = oConnection;
                    oConnection.Open();

                    command.CommandText = "SelectReservationParRestaurantJourReservation";
                    command.CommandType = CommandType.StoredProcedure;
                    SqlParameter param1 = new SqlParameter("@date", date);
                    SqlParameter param2 = new SqlParameter("@idRestaurant", idRestaurant);
                    SqlParameter param3 = new SqlParameter("@idReservation", idReservation);
                    command.Parameters.Add(param1);
                    command.Parameters.Add(param2);
                    command.Parameters.Add(param3);

                    SqlDataAdapter oSqlDataAdapter = new SqlDataAdapter();
                    oSqlDataAdapter.SelectCommand = command;

                    oSqlDataAdapter.Fill(dataToReturn, "Reservation");
                }
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
            catch (Exception e)
            {
                throw e;
            }

            return dataToReturn;
        }

        public static DataSet SelectParticipantsParReservation(int idReservation)
        {
            DataSet dataToReturn = new DataSet();
            try
            {
                using (SqlConnection oConnection = new SqlConnection())
                {
                    oConnection.ConnectionString = Utils.oConn;

                    SqlCommand command = new SqlCommand();
                    command.Connection = oConnection;
                    oConnection.Open();

                    command.CommandText = "SelectParticipantsParReservation";
                    command.CommandType = CommandType.StoredProcedure;
                    SqlParameter param1 = new SqlParameter("@idReservation", idReservation);
                    command.Parameters.Add(param1);

                    SqlDataAdapter oSqlDataAdapter = new SqlDataAdapter();
                    oSqlDataAdapter.SelectCommand = command;

                    oSqlDataAdapter.Fill(dataToReturn, "Participants");
                }
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
            catch (Exception e)
            {
                throw e;
            }

            return dataToReturn;
        }

        public static string SelectElement(int idCarteRestaurant)
        {
            string dataToReturn = "";
            try
            {
                using (SqlConnection oConnection = new SqlConnection())
                {
                    oConnection.ConnectionString = Utils.oConn;

                    SqlCommand command = new SqlCommand();
                    command.Connection = oConnection;
                    oConnection.Open();

                    command.CommandText = "SelectElementSpecifique";
                    command.CommandType = CommandType.StoredProcedure;
                    SqlParameter param1 = new SqlParameter("@idCarteRestaurant", idCarteRestaurant);
                    command.Parameters.Add(param1);

                    SqlDataReader myReader = command.ExecuteReader();
                    if (myReader.Read())
                    {
                        dataToReturn = myReader["Element"].ToString();
                    }

                    myReader.Close();
                }
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
            catch (Exception e)
            {
                throw e;
            }

            return dataToReturn;
        }

        public static DataSet SelectMenu(int idRestaurant)
        {
            DataSet dataToReturn = new DataSet();
            try
            {
                using (SqlConnection oConnection = new SqlConnection())
                {
                    oConnection.ConnectionString = Utils.oConn;

                    SqlCommand command = new SqlCommand();
                    command.Connection = oConnection;
                    oConnection.Open();

                    command.CommandText = "SelectMenuByRestaurant";
                    command.CommandType = CommandType.StoredProcedure;
                    SqlParameter param1 = new SqlParameter("@idRestaurant", idRestaurant);
                    command.Parameters.Add(param1);

                    SqlDataAdapter oSqlDataAdapter = new SqlDataAdapter();
                    oSqlDataAdapter.SelectCommand = command;

                    oSqlDataAdapter.Fill(dataToReturn, "Menus");
                }
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
            catch (Exception e)
            {
                throw e;
            }

            return dataToReturn;
        }

        public static DataSet SelectCarteMenu(int idMenu,int idType)
        {
            DataSet dataToReturn = new DataSet();
            try
            {
                using (SqlConnection oConnection = new SqlConnection())
                {
                    oConnection.ConnectionString = Utils.oConn;

                    SqlCommand command = new SqlCommand();
                    command.Connection = oConnection;
                    oConnection.Open();

                    command.CommandText = "SelectCarteMenu";
                    command.CommandType = CommandType.StoredProcedure;
                    SqlParameter param1 = new SqlParameter("@idMenu", idMenu);
                    SqlParameter param2 = new SqlParameter("@type", idType);
                    command.Parameters.Add(param1);
                    command.Parameters.Add(param2);

                    SqlDataAdapter oSqlDataAdapter = new SqlDataAdapter();
                    oSqlDataAdapter.SelectCommand = command;

                    oSqlDataAdapter.Fill(dataToReturn, "CarteMenus");
                }
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
            catch (Exception e)
            {
                throw e;
            }

            return dataToReturn;
        }

        public static int SelectPrixElement(int idCarteRestaurant)
        {
            int dataToReturn = 0;
            try
            {
                using (SqlConnection oConnection = new SqlConnection())
                {
                    oConnection.ConnectionString = Utils.oConn;

                    SqlCommand command = new SqlCommand();
                    command.Connection = oConnection;
                    oConnection.Open();

                    command.CommandText = "SelectPrixCarte";
                    command.CommandType = CommandType.StoredProcedure;
                    SqlParameter param1 = new SqlParameter("@idCarteRestaurant", idCarteRestaurant);
                    command.Parameters.Add(param1);

                    SqlDataReader myReader = command.ExecuteReader();
                    if (myReader.Read())
                    {
                        dataToReturn = (int) myReader["Prix"];
                    }

                    myReader.Close();
                }
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
            catch (Exception e)
            {
                throw e;
            }

            return dataToReturn;
        }

        public static int SelectIdDetailMenu(int idMenu, int idCarteRestaurant)
        {
            int dataToReturn = 0;
            try
            {
                using (SqlConnection oConnection = new SqlConnection())
                {
                    oConnection.ConnectionString = Utils.oConn;

                    SqlCommand command = new SqlCommand();
                    command.Connection = oConnection;
                    oConnection.Open();

                    command.CommandText = "SelectIdDetailMenu";
                    command.CommandType = CommandType.StoredProcedure;
                    SqlParameter param1 = new SqlParameter("@idMenu", idMenu);
                    SqlParameter param2 = new SqlParameter("@idCarteRestaurant", idCarteRestaurant);
                    command.Parameters.Add(param1);
                    command.Parameters.Add(param2);

                    SqlDataReader myReader = command.ExecuteReader();
                    if (myReader.Read())
                    {
                        dataToReturn = (int)myReader["idDetailMenu"];
                    }

                    myReader.Close();
                }
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
            catch (Exception e)
            {
                throw e;
            }

            return dataToReturn;
        }
    }
}
