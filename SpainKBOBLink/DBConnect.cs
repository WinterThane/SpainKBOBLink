using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SpainKBOBLink
{
    public class DBConnect
    {
        private readonly MySqlConnection connection;

        public DBConnect()
        {
            connection = new MySqlConnection(Config.connectionString);
        }

        private bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server.");
                        break;

                    case 1045:
                        MessageBox.Show("Invalid username/password.");
                        break;
                }
                return false;
            }
        }

        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        // return all KBOB materials
        public List<MaterialKBOBModel> SelectKBOB()
        {
            var query = "SELECT id, id_kbob, name_german, surface_mass, surface_mass_units, ubp13_manufacturing, " +
                "ubp13_disposal, total_production, total_disposal, renewable_production, renewable_disposal, " +
                "non_renewable_production, non_renewable_disposal, greenhouse_gas_emissions_production, greenhouse_gas_emissions_disposal " +
                "FROM hornetdb.kbob_material " +
                "ORDER BY id_kbob";

            var results = new List<MaterialKBOBModel>();

            if (OpenConnection() == true)
            {
                var cmd = new MySqlCommand(query, connection);
                var dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    results.Add(new MaterialKBOBModel
                    {
                        IdKBOB = (int)dataReader["id"],
                        KBOB = dataReader["id_kbob"].ToString(),
                        NameGerman = dataReader["name_german"].ToString(),
                        SurfaceMass = dataReader["surface_mass"].ToString(),
                        SurfaceMassUnit = dataReader["surface_mass_units"].ToString(),
                        Ubp13Manufacture = (float)dataReader["ubp13_manufacturing"],
                        Ubp13Disposal = (float)dataReader["ubp13_disposal"],
                        TotalProduction = (float)dataReader["ubp13_disposal"],
                        TotalDisposal = (float)dataReader["ubp13_disposal"],
                        RenewableProduction = (float)dataReader["renewable_production"],
                        RenewableDisposal = (float)dataReader["renewable_disposal"],
                        NonRenewableProduction = (float)dataReader["renewable_production"],
                        NonRenewableDisposal = (float)dataReader["renewable_disposal"],
                        GreenhouseGasEmissionsProduction = (float)dataReader["greenhouse_gas_emissions_production"],
                        GreenhouseGasEmissionsDisposal = (float)dataReader["greenhouse_gas_emissions_disposal"]
                    });
                }

                dataReader.Close();
                CloseConnection();

                return results;
            }
            else
            {
                return results;
            }
        }

        public List<string> SelectGroups()
        {
            var query = "SELECT DISTINCT material_group " +
                        "FROM hornetdb.spanish_material " +
                        "ORDER BY material_group ASC";

            var results = new List<string>();

            if (OpenConnection() == true)
            {
                var cmd = new MySqlCommand(query, connection);
                var dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    results.Add(dataReader["material_group"] + "");
                }

                dataReader.Close();
                CloseConnection();

                return results;
            }
            else
            {
                return results;
            }
        }
    }
}
