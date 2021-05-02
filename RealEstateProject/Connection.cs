using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateProject
{

    class Connection
    {

        MySqlConnection countryList = new MySqlConnection("server=localhost;user=root;database=CountryList;port=3306;password=;");
        MySqlConnection realEstate = new MySqlConnection("server=localhost;user=root;database=realestate;port=3306;password=;convert zero datetime=True;CHARSET=utf8;");
        public Connection()
        {
            //your MySQL connection string

            try
            {
                Console.WriteLine("Connecting to MySQL...");
                realEstate.Open();
                countryList.Open();
                Console.WriteLine("Connected");

            }
            catch (Exception err)
            {
                Console.WriteLine(err.ToString());
            }

        }

        internal DataTable getPaymentMethods()
        {
            DataSet dataset = new DataSet();

            MySqlCommand sqlCommand = new MySqlCommand("getPaymentMethods");
            sqlCommand.Connection = realEstate;
            sqlCommand.CommandType = CommandType.StoredProcedure;
            MySqlDataAdapter sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dataset);
            return dataset.Tables[0];
        }

        internal DataTable getBanks()
        {
            DataSet dataset = new DataSet();

            MySqlCommand sqlCommand = new MySqlCommand("getBanks");
            sqlCommand.Connection = realEstate;
            sqlCommand.CommandType = CommandType.StoredProcedure;
            MySqlDataAdapter sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dataset);
            return dataset.Tables[0];
        }

        internal DataTable getRentalTypes()
        {
            DataSet dataset = new DataSet();

            MySqlCommand sqlCommand = new MySqlCommand("getRentalTypes");
            sqlCommand.Connection = realEstate;
            sqlCommand.CommandType = CommandType.StoredProcedure;
            MySqlDataAdapter sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dataset);
            return dataset.Tables[0];
        }

        internal int deleteAppartment(string v)
        {
            MySqlCommand sqlCommand = new MySqlCommand("deleteAppartment");
            sqlCommand.Connection = realEstate;
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("AppartmentID", v);
            int a = sqlCommand.ExecuteNonQuery();
            return a;
        }

        internal void deleteRental(string v)
        {
            MySqlCommand sqlCommand = new MySqlCommand("deleteRental");
            sqlCommand.Connection = realEstate;
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("rentalID", v);
            int a = sqlCommand.ExecuteNonQuery();
        }

        internal void deletePerson(string v)
        {
            MySqlCommand sqlCommand = new MySqlCommand("deletePerson");
            sqlCommand.Connection = realEstate;
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("personID", v);
            int a = sqlCommand.ExecuteNonQuery();
        }

        internal DataTable getExpenseTypes()
        {
            DataSet dataset = new DataSet();

            MySqlCommand sqlCommand = new MySqlCommand("getExpencesTypes");
            sqlCommand.Connection = realEstate;
            sqlCommand.CommandType = CommandType.StoredProcedure;
            MySqlDataAdapter sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dataset);
            return dataset.Tables[0];
        }

        internal DataTable getRenterPersons()
        {
            DataSet dataset = new DataSet();

            MySqlCommand sqlCommand = new MySqlCommand("allRenters");
            sqlCommand.Connection = realEstate;
            sqlCommand.CommandType = CommandType.StoredProcedure;
            MySqlDataAdapter sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dataset);
            return dataset.Tables[0];
        }

        internal int updatePerson(string text1, string text2, string text3, string text4, string text5, string text6, string text7, string text8, string text9, string text10, string text)
        {
            MySqlCommand sqlCommand = new MySqlCommand("updatePerson");
            sqlCommand.Connection = realEstate;
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("personID", text1);
            sqlCommand.Parameters.AddWithValue("fName", text2);
            sqlCommand.Parameters.AddWithValue("mName", text3);
            sqlCommand.Parameters.AddWithValue("lName", text4);
            sqlCommand.Parameters.AddWithValue("country", text5);
            sqlCommand.Parameters.AddWithValue("state", text6);
            sqlCommand.Parameters.AddWithValue("city", text7);
            sqlCommand.Parameters.AddWithValue("address", text8);
            sqlCommand.Parameters.AddWithValue("phone", text9);
            sqlCommand.Parameters.AddWithValue("email", text10);
            sqlCommand.Parameters.AddWithValue("role", text);
            int a = sqlCommand.ExecuteNonQuery();
            return a;
        }

        internal int updateRental(string v1, string v2, string text1, string v3, string text2, string text3, string text4, string text5)
        {
            MySqlCommand sqlCommand = new MySqlCommand("updateRental");
            sqlCommand.Connection = realEstate;
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("rentalID", v1);
            sqlCommand.Parameters.AddWithValue("renterID", v2);
            sqlCommand.Parameters.AddWithValue("type", text1);
            sqlCommand.Parameters.AddWithValue("rentDuration", v3);
            sqlCommand.Parameters.AddWithValue("rentalType", text2);
            sqlCommand.Parameters.AddWithValue("details", text3);
            sqlCommand.Parameters.AddWithValue("rentDate", text4);
            sqlCommand.Parameters.AddWithValue("paymentMethod", text5);
    
            int a = sqlCommand.ExecuteNonQuery();
            return a;
        }

        internal int updateDepartment(string v1, string v2, string text1, string v3, string text2, string v4, string text3, string text4, string text5, string text6, string text7, string text8, string text9)
        {
            MySqlCommand sqlCommand = new MySqlCommand("updateAppartment");
            sqlCommand.Connection = realEstate;
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("appartmentID", v1);
            sqlCommand.Parameters.AddWithValue("ownerID", v2);
            sqlCommand.Parameters.AddWithValue("floor", text1);
            sqlCommand.Parameters.AddWithValue("type", v3);
            sqlCommand.Parameters.AddWithValue("numberOfRooms", v4);
            sqlCommand.Parameters.AddWithValue("dailyRentalInDollar", text3);
            sqlCommand.Parameters.AddWithValue("monthlyRentalInDollar", text4);
            sqlCommand.Parameters.AddWithValue("yearlyRentalInDollar", text5);
            sqlCommand.Parameters.AddWithValue("dailyRentalInLera", text6);
            sqlCommand.Parameters.AddWithValue("monthlyRentalInLera", text7);
            sqlCommand.Parameters.AddWithValue("yearlyRentalInLera", text8);
            sqlCommand.Parameters.AddWithValue("details", text9);
            int a = sqlCommand.ExecuteNonQuery();
            return a;
        }

        public DataTable getCountries()
        {
            DataSet dataset = new DataSet();

            MySqlCommand sqlCommand = new MySqlCommand("contries");
            sqlCommand.Connection = countryList;
            sqlCommand.CommandType = CommandType.StoredProcedure;
            MySqlDataAdapter sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dataset);

            return dataset.Tables[0];
        }

        internal int deleteRealEstate(string id)
        {
            MySqlCommand sqlCommand = new MySqlCommand("deleteRealEstate");
            sqlCommand.Connection = realEstate;
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("realEsateID", id);
            int a = sqlCommand.ExecuteNonQuery();
            return a;
        }

        public DataTable getStates(string id)
        {
            if (!String.IsNullOrEmpty(id))
            {
                DataSet dataset = new DataSet();

                MySqlCommand sqlCommand = new MySqlCommand("states");
                sqlCommand.Connection = countryList;
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("id", id);
                MySqlDataAdapter sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
                sqlDataAdapter.Fill(dataset);

                return dataset.Tables[0];
            }
            return null;

        }

        internal int updateRealEstate(string v1, string text1, string text2, string text3, string text4, string text5, string text6, string text7, string text8, string v2, string v3)
        {
            MySqlCommand sqlCommand = new MySqlCommand("updateRealEstate");
            sqlCommand.Connection = realEstate;
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("estateID", v1);
            sqlCommand.Parameters.AddWithValue("buildingNumber", text1);
            sqlCommand.Parameters.AddWithValue("country", text2);
            sqlCommand.Parameters.AddWithValue("state", text3);
            sqlCommand.Parameters.AddWithValue("city", text4);
            sqlCommand.Parameters.AddWithValue("neigborhood", text5);
            sqlCommand.Parameters.AddWithValue("address", text6);
            sqlCommand.Parameters.AddWithValue("currentState", text7);
            sqlCommand.Parameters.AddWithValue("value", text8);
            sqlCommand.Parameters.AddWithValue("collectorPercentage", v2);
            sqlCommand.Parameters.AddWithValue("ownerID", v3);
            int a = sqlCommand.ExecuteNonQuery();
            return a;
        }

        public DataTable getRealEstates()
        {

            DataSet dataset = new DataSet();

            MySqlCommand sqlCommand = new MySqlCommand("realEstates");
            sqlCommand.Connection = realEstate;
            sqlCommand.CommandType = CommandType.StoredProcedure;
            MySqlDataAdapter sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dataset);
            return dataset.Tables[0];


        }
        public DataTable getAllPerson()
        {

            DataSet dataset = new DataSet();

            MySqlCommand sqlCommand = new MySqlCommand("allPersons");
            sqlCommand.Connection = realEstate;
            sqlCommand.CommandType = CommandType.StoredProcedure;
            MySqlDataAdapter sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dataset);
            return dataset.Tables[0];


        }
        public DataTable getOwnerPersons()
        {
            DataSet dataset = new DataSet();

            MySqlCommand sqlCommand = new MySqlCommand("persons");
            sqlCommand.Connection = realEstate;
            sqlCommand.CommandType = CommandType.StoredProcedure;
            MySqlDataAdapter sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dataset);
            return dataset.Tables[0];

        }
        public DataTable getAppartments()
        {
            DataSet dataset = new DataSet();

            MySqlCommand sqlCommand = new MySqlCommand("allAppartments");
            sqlCommand.Connection = realEstate;
            sqlCommand.CommandType = CommandType.StoredProcedure;
            MySqlDataAdapter sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dataset);
            return dataset.Tables[0];

        }
        public DataTable getAppartments(string id)
        {
            DataSet dataset = new DataSet();

            MySqlCommand sqlCommand = new MySqlCommand("getAppartmentNumbers");
            sqlCommand.Connection = realEstate;
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("id", id);
            MySqlDataAdapter sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dataset);
            return dataset.Tables[0];

        }
        public DataTable getRentals()
        {
            DataSet dataset = new DataSet();

            MySqlCommand sqlCommand = new MySqlCommand("allRental");
            sqlCommand.Connection = realEstate;
            sqlCommand.CommandType = CommandType.StoredProcedure;
            MySqlDataAdapter sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dataset);
            return dataset.Tables[0];

        }
        public DataTable getMonthlyRentalpayments()
        {
            DataSet dataset = new DataSet();

            MySqlCommand sqlCommand = new MySqlCommand("allMonthlyRentalPayment");
            sqlCommand.Connection = realEstate;
            sqlCommand.CommandType = CommandType.StoredProcedure;
            MySqlDataAdapter sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dataset);
            return dataset.Tables[0];

        }        public DataTable getOptions()
        {
            DataSet dataset = new DataSet();

            MySqlCommand sqlCommand = new MySqlCommand("getOptions");
            sqlCommand.Connection = realEstate;
            sqlCommand.CommandType = CommandType.StoredProcedure;
            MySqlDataAdapter sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dataset);
            return dataset.Tables[0];

        }
        public DataTable getRealestateExpenses()
        {
            DataSet dataset = new DataSet();

            MySqlCommand sqlCommand = new MySqlCommand("allRealestateExpenses");
            sqlCommand.Connection = realEstate;
            sqlCommand.CommandType = CommandType.StoredProcedure;
            MySqlDataAdapter sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dataset);
            return dataset.Tables[0];

        }
        public int insertRealEstate(string estateNumber, string buildingNumber, string country, string state, string city, string neigborhood, string address, string currentState, string value, string collectorPercentage, string ownerID)
        {

            MySqlCommand sqlCommand = new MySqlCommand("inserRealEstate");
            sqlCommand.Connection = realEstate;
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("estateNumber", estateNumber);
            sqlCommand.Parameters.AddWithValue("buildingNumber", buildingNumber);
            sqlCommand.Parameters.AddWithValue("country", country);
            sqlCommand.Parameters.AddWithValue("state", state);
            sqlCommand.Parameters.AddWithValue("city", city);
            sqlCommand.Parameters.AddWithValue("neigborhood", neigborhood);
            sqlCommand.Parameters.AddWithValue("address", address);
            sqlCommand.Parameters.AddWithValue("currentState", currentState);
            sqlCommand.Parameters.AddWithValue("value", value);
            sqlCommand.Parameters.AddWithValue("collectorPercentage", collectorPercentage);
            sqlCommand.Parameters.AddWithValue("ownerID", ownerID);
            int a = sqlCommand.ExecuteNonQuery();
            return a;
     
        }
        public int insertRealEstateExpense
            (string realestateID, string personID, string ExpenseType, string amount, string date, string detail, string moneyType)
        {
            if (!checkEmpty(realestateID, personID, ExpenseType, amount, date, detail))
            {
                //inserRealEstate
                MySqlCommand sqlCommand = new MySqlCommand("addRealestaeExpence");
                sqlCommand.Connection = realEstate;
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("realestateID", realestateID);
                sqlCommand.Parameters.AddWithValue("personID", personID);
                sqlCommand.Parameters.AddWithValue("ExpenseType", ExpenseType);
                sqlCommand.Parameters.AddWithValue("amount", amount);
                sqlCommand.Parameters.AddWithValue("date", date);
                sqlCommand.Parameters.AddWithValue("detail", detail);
                sqlCommand.Parameters.AddWithValue("moneyType", moneyType);

                int a = sqlCommand.ExecuteNonQuery();
                return a;
            }
            else
                return 2;
        }

        public int insertPerson(string fName, string mName, string lName, string country, string state, string city, string address, string phone, string email, string role)
        {
            if (!checkEmpty(fName, mName, lName, address, phone, email))
            {
                //fName, mName, lName, phone, country, state, city, address, email, role
                MySqlCommand sqlCommand = new MySqlCommand("addPerson");
                sqlCommand.Connection = realEstate;
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("fName", fName);
                sqlCommand.Parameters.AddWithValue("mName", mName);
                sqlCommand.Parameters.AddWithValue("lName", lName);
                sqlCommand.Parameters.AddWithValue("country", country);
                sqlCommand.Parameters.AddWithValue("state", state);
                sqlCommand.Parameters.AddWithValue("city", city);
                sqlCommand.Parameters.AddWithValue("address", address);
                sqlCommand.Parameters.AddWithValue("phone", phone);
                sqlCommand.Parameters.AddWithValue("role", role);
                sqlCommand.Parameters.AddWithValue("email", email);
                int a = sqlCommand.ExecuteNonQuery();
                return a;
            }
            else
                return 2;
        }
        public int insertDepartment(string appartmentNumber, string ownerID, string floor, string buildingID, string type, string numberOfRooms, string dailyRentalInDollar, string monthlyRentalInDollar, string yearlyRentalInDollar, string dailyRentalInLera, string monthlyRentalInLera, string yearlyRentalInLera, string details)

        {

            // VALUES (ownerID, floor, buildingID, type, numberOfRooms, dailyRentalInDollar, monthlyRentalInDollar, yearlyRentalInDollar, dailyRentalInLera, monthlyRentalInLera, yearlyRentalInLera, details);

            MySqlCommand sqlCommand = new MySqlCommand("addDepartment");
            sqlCommand.Connection = realEstate;
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("appartmentNumber", appartmentNumber);
            sqlCommand.Parameters.AddWithValue("ownerID", ownerID);
            sqlCommand.Parameters.AddWithValue("floor", floor);
            sqlCommand.Parameters.AddWithValue("buildingID", buildingID);
            sqlCommand.Parameters.AddWithValue("type", type);
            sqlCommand.Parameters.AddWithValue("numberOfRooms", numberOfRooms);
            sqlCommand.Parameters.AddWithValue("dailyRentalInDollar", dailyRentalInDollar);
            sqlCommand.Parameters.AddWithValue("monthlyRentalInDollar", monthlyRentalInDollar);
            sqlCommand.Parameters.AddWithValue("yearlyRentalInDollar", yearlyRentalInDollar);
            sqlCommand.Parameters.AddWithValue("dailyRentalInLera", dailyRentalInLera);
            sqlCommand.Parameters.AddWithValue("monthlyRentalInLera", monthlyRentalInLera);
            sqlCommand.Parameters.AddWithValue("yearlyRentalInLera", yearlyRentalInLera);
            sqlCommand.Parameters.AddWithValue("details", details);
            int a = sqlCommand.ExecuteNonQuery();
            return a;

        }
        public int insertRental(string renterID, string appartmentNumber, string type,
            string rentDuration, string rentalType, string details, string rentDate,
            string paymentMethod)

        {

            //VALUES(renterID, appartmentNumber, type, rentDuration, rentalType, details, rentDate, paymentMethod);

            MySqlCommand sqlCommand = new MySqlCommand("addRental");
            sqlCommand.Connection = realEstate;
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("renterID", renterID);
            sqlCommand.Parameters.AddWithValue("appartmentNumber", appartmentNumber);
            sqlCommand.Parameters.AddWithValue("type", type);
            sqlCommand.Parameters.AddWithValue("rentDuration", rentDuration);
            sqlCommand.Parameters.AddWithValue("rentalType", rentalType);
            sqlCommand.Parameters.AddWithValue("details", details);
            sqlCommand.Parameters.AddWithValue("rentDate", rentDate);
            sqlCommand.Parameters.AddWithValue("paymentMethod", paymentMethod);
            int a = sqlCommand.ExecuteNonQuery();
            return a;



        }
        public int insertMonthlyRentalPayments(string renterID, string appartmentID, string amount,
            string date, string details, string payMethod, string checkNumber, string bank)

        {

            //(renterID, appartmentID, amount, date, details, payMethod, checkNumber, bank)
            MySqlCommand sqlCommand = new MySqlCommand("addMonthlyRentalPayment");
            sqlCommand.Connection = realEstate;
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("renterID", renterID);
            sqlCommand.Parameters.AddWithValue("appartmentID", appartmentID);
            sqlCommand.Parameters.AddWithValue("amount", amount);
            sqlCommand.Parameters.AddWithValue("date", date);
            sqlCommand.Parameters.AddWithValue("details", details);
            sqlCommand.Parameters.AddWithValue("payMethod", payMethod);
            sqlCommand.Parameters.AddWithValue("checkNumber", checkNumber);
            sqlCommand.Parameters.AddWithValue("bank", bank);
            int a = sqlCommand.ExecuteNonQuery();
            return a;



        }
        public int insertMethodPayments(string name)

        {

            MySqlCommand sqlCommand = new MySqlCommand("addMonthlyRentalPayment");
            sqlCommand.Connection = realEstate;
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("name", name);
            int a = sqlCommand.ExecuteNonQuery();
            return a;
        }
        public DataTable getPaymetMethods()
        {
            DataSet dataset = new DataSet();

            MySqlCommand sqlCommand = new MySqlCommand("getPaymentMethods");
            sqlCommand.Connection = realEstate;
            sqlCommand.CommandType = CommandType.StoredProcedure;
            MySqlDataAdapter sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dataset);
            return dataset.Tables[0];

        }
        private bool checkEmpty(string estateNumber, string buildingNumber, string neigborhood, string address, string currentState, string value)
        {
            return String.IsNullOrEmpty(estateNumber) ||
                String.IsNullOrEmpty(buildingNumber) ||
                String.IsNullOrEmpty(neigborhood) ||
                String.IsNullOrEmpty(address) ||
                String.IsNullOrEmpty(currentState) ||
                String.IsNullOrEmpty(value);
        }
        public int AddPredefinedOption(int position , string value)

        {
            string table="";
            switch (position)
            {
                case 1: table = "addBank";
                    break;
                case 2: table = "addDocumentType";
                    break;
                case 3: table = "addExpenseType";
                    break;
                case 4:
                    table = "addPaymentMethod";
                    break;
                case 5:
                    table = "addPropertyType";
                    break;
                case 6:
                    table = "addRentalTypes";
                    break;
                case 7:
                    table = "addOtherExpenseType";
                    break;
            }
            MySqlCommand sqlCommand = new MySqlCommand(table);
            sqlCommand.Connection = realEstate;
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("name", value);
            int a = sqlCommand.ExecuteNonQuery();
            return 0;
        }

    }

}
