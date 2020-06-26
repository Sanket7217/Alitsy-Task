using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace AlitsyTask.Models

{
    public class ImportElectricityRepository
    {
        private const string INSER_ROW = "INSERT INTO ImportElectricity " +
                            "(BillType_Name, EntryMethod_Name, PeakCharge, PeakQuantity, PeakEnergyRate, ShoulderCharge, ShoulderQuantity," +
                            "ShoulderEnergyRate, OffPeakCharge, OffPeakQuantity, OffPeakEnergyRate, GST)" +
                            "VALUES (@BillType_Name, @EntryMethod_Name, @PeakCharge, @PeakQuantity, @PeakEnergyRate, @ShoulderCharge, @ShoulderQuantity, @ShoulderEnergyRate, @OffPeakCharge, @OffPeakQuantity, @OffPeakEnergyRate, @GST) ";

        public bool SaveRecord(ImportElectricity objData)
            {
                try
                {
                    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Connection"].ToString());
                    con.Open();

                    string query = INSER_ROW;

                    SqlCommand cmd = new SqlCommand(query, con);
                    
                    cmd.Parameters.AddWithValue("@BillType_Name", objData.BillType_Name);
                    cmd.Parameters.AddWithValue("@EntryMethod_Name", objData.EntryMethod_Name);
                    cmd.Parameters.AddWithValue("@PeakCharge", objData.PeakCharge);
                    cmd.Parameters.AddWithValue("@PeakQuantity", objData.PeakQuantity);
                    cmd.Parameters.AddWithValue("@PeakEnergyRate", objData.PeakEnergyRate);
                    cmd.Parameters.AddWithValue("@ShoulderCharge", objData.ShoulderCharge);
                    cmd.Parameters.AddWithValue("@ShoulderQuantity", objData.ShoulderQuantity);
                    cmd.Parameters.AddWithValue("@ShoulderEnergyRate", objData.ShoulderEnergyRate);
                    cmd.Parameters.AddWithValue("@OffPeakCharge", objData.OffPeakCharge);
                    cmd.Parameters.AddWithValue("@OffPeakQuantity", objData.OffPeakQuantity);
                    cmd.Parameters.AddWithValue("@OffPeakEnergyRate", objData.OffPeakEnergyRate);
                    cmd.Parameters.AddWithValue("@GST", objData.GST);
                    cmd.ExecuteNonQuery();
                    con.Close();

                }
                catch (Exception ex)
                {

                throw ex;
            }
                return true;
            }

        

    }
}
