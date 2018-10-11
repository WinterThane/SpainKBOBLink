using MySql.Data.MySqlClient;
using System;
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

        public List<MaterialSpainModel> SelectSpanishMaterials(string param)
        {
            var query = "SELECT id_material, material_group, short_description, co2, " +
                        "energy_consumption, raw_material, post_recycling, pre_recycling " +
                        "FROM hornetdb.spanish_material " +
                        "WHERE material_group = @group " +
                        "ORDER BY short_description ASC";

            var results = new List<MaterialSpainModel>();

            if (OpenConnection() == true)
            {
                var cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@group", param);
                var dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    results.Add(new MaterialSpainModel
                    {
                        IdMaterial = (int)dataReader["id_material"],
                        MaterialGroup = dataReader["material_group"].ToString(),
                        ShortDescription = dataReader["short_description"].ToString(),
                        CO2 = dataReader["co2"] != DBNull.Value ? (float)dataReader["co2"] : -1,
                        EnergyConsumption = dataReader["energy_consumption"] != DBNull.Value ? (float)dataReader["energy_consumption"] : -1,
                        RawMaterial = dataReader["raw_material"] != DBNull.Value ? (float)dataReader["raw_material"] : -1,
                        PostRecycling = dataReader["post_recycling"] != DBNull.Value ? (float)dataReader["post_recycling"] : -1,
                        PreRecycling = dataReader["pre_recycling"] != DBNull.Value ? (float)dataReader["pre_recycling"] : -1
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

        public List<SpainKBOBModel> SelectJoin(string param)
        {
            var query = "SELECT sk.id, s.short_description, s.energy_consumption, s.co2, s.raw_material, s.post_recycling, " +
                        "s.pre_recycling, k.id_kbob, k.surface_mass, k.surface_mass_units, k.ubp13_manufacturing, k.ubp13_disposal, " +
                        "k.renewable_production, k.renewable_disposal, k.non_renewable_production, k.non_renewable_disposal, " +
                        "k.greenhouse_gas_emissions_production, k.greenhouse_gas_emissions_disposal " +
                        "FROM hornetdb.spanish_material s " +
                        "INNER JOIN hornetdb.spanish_kbob sk " +
                        "ON s.id_material = sk.id_spanish " +
                        "INNER JOIN hornetdb.kbob_material k " +
                        "ON sk.id_kbob = k.id " +
                        "WHERE short_description = @name " +
                        "ORDER BY s.short_description ASC";

            var results = new List<SpainKBOBModel>();

            if (OpenConnection() == true)
            {
                var cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@name", param);
                var dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    results.Add(new SpainKBOBModel
                    {
                        Id = (int)dataReader["id"],
                        ShortDescription = dataReader["short_description"].ToString(),
                        EnergyConsumption = dataReader["energy_consumption"] != DBNull.Value ? (float)dataReader["energy_consumption"] : -1,
                        CO2 = dataReader["co2"] != DBNull.Value ? (float)dataReader["co2"] : -1,
                        RawMaterial = dataReader["raw_material"] != DBNull.Value ? (float)dataReader["raw_material"] : -1,
                        PostRecycling = dataReader["post_recycling"] != DBNull.Value ? (float)dataReader["post_recycling"] : -1,
                        PreRecycling = dataReader["pre_recycling"] != DBNull.Value ? (float)dataReader["pre_recycling"] : -1,
                        SurfaceMass = dataReader["surface_mass"].ToString(),
                        SurfaceMassUnit = dataReader["surface_mass_units"].ToString(),
                        Ubp13Manufacture = (float)dataReader["ubp13_manufacturing"],
                        Ubp13Disposal = (float)dataReader["ubp13_disposal"],
                        //TotalProduction = (float)dataReader["total_production"],
                        //TotalDisposal = (float)dataReader["total_disposal"],
                        RenewableProduction = (float)dataReader["renewable_production"],
                        RenewableDisposal = (float)dataReader["renewable_disposal"],
                        NonRenewableProduction = (float)dataReader["non_renewable_production"],
                        NonRenewableDisposal = (float)dataReader["non_renewable_disposal"],
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

        public void InsertLink(int spain, int kbob)
        {
            var query = "INSERT INTO hornetdb.spanish_kbob (id_spanish, id_kbob) VALUES (@id_spain, @id_kbob);";

            if (OpenConnection() == true)
            {
                var cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@id_spain", spain);
                cmd.Parameters.AddWithValue("@id_kbob", kbob);
                cmd.ExecuteNonQuery();

                CloseConnection();
            }
        }

        public void DeleteLink(int id)
        {
            var query = "DELETE FROM hornetdb.spanish_kbob WHERE id = @target";

            if (OpenConnection() == true)
            {
                var cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@target", id);
                cmd.ExecuteNonQuery();

                CloseConnection();
            }
        }
    }
}
