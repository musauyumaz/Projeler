using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace DataTrackingForm
{
    public class DataDal
    {
        SqlConnection connection = new SqlConnection(@"Server = DataTrackingDb.mssql.somee.com ;Database = DataTrackingDb ; user = dataTracking_SQLLogin_2; password = e1g7cqijyj");
   
        public void DataTransferToDatabase(string[] splittedData, Data data)
        {
            data.MachineId = (splittedData[0] == null) ? 3 : Convert.ToInt32(splittedData[0]);
            data.Data1 = (splittedData[1] == null) ? -1 : Convert.ToDouble(splittedData[1]);
            data.Data2 = (splittedData[2] == null) ? -1 : Convert.ToDouble(splittedData[2]);
            data.Data3 = (splittedData[3] == null) ? -1 : Convert.ToDouble(splittedData[3]);
            data.Data4 = (splittedData[4] == null) ? -1 : Convert.ToDouble(splittedData[4]);
            data.Data5 = (splittedData[5] == null) ? -1 : Convert.ToDouble(splittedData[5]);
            data.Data6 = (splittedData[6] == null) ? -1 : Convert.ToDouble(splittedData[6]);
            data.Data7 = (splittedData[7] == null) ? -1 : Convert.ToDouble(splittedData[7]);
            data.Data8 = (splittedData[8] == null) ? -1 : Convert.ToDouble(splittedData[8]);
            data.Data9 = (splittedData[9] == null) ? -1 : Convert.ToDouble(splittedData[9]);
            data.Data10 = (splittedData[10] == null) ? -1 : Convert.ToDouble(splittedData[10]);
            data.Data11 = (splittedData[11] == null) ? -1 : Convert.ToDouble(splittedData[11]);
            data.Data12 = (splittedData[12] == null) ? -1 : Convert.ToDouble(splittedData[12]);


            connection.Open();
            SqlCommand komut = new SqlCommand("insert into Data (MachineId,Data1,Data2,Data3,Data4,Data5,Data6,Data7,Data8,Data9,Data10,Data11,Data12)" +
                " values('" + data.MachineId + "','" + data.Data1 + "','" + data.Data2 + "','" + data.Data3 + "','" + data.Data4 + "','" + data.Data5 + "'" +
                ",'" + data.Data6 + "','" + data.Data7 + "','" + data.Data8 + "','" + data.Data9 + "','" + data.Data10 + "','" + data.Data11 + "'" +
                ",'" + data.Data12 + "')", connection);
            komut.ExecuteNonQuery();
            connection.Close();
        }

        public Data ShowMachineData(int machineId)
        {
            Data data = new Data();
            connection.Open();
            SqlCommand komut = new SqlCommand("SELECT TOP 1 * FROM DATA WHERE MachineId = @p1 ORDER BY Id DESC", connection);
            komut.Parameters.AddWithValue("@p1", machineId);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                data.MachineId = int.Parse(oku["MachineId"].ToString());
                data.Data1 = double.Parse(oku["Data1"].ToString());
                data.Data2 = double.Parse(oku["Data2"].ToString());
                data.Data3 = double.Parse(oku["Data3"].ToString());
                data.Data4 = double.Parse(oku["Data4"].ToString());
                data.Data5 = double.Parse(oku["Data5"].ToString());
                data.Data6 = double.Parse(oku["Data6"].ToString());
                data.Data7 = double.Parse(oku["Data7"].ToString());
                data.Data8 = double.Parse(oku["Data8"].ToString());
                data.Data9 = double.Parse(oku["Data9"].ToString());
                data.Data10 = double.Parse(oku["Data10"].ToString());
                data.Data11 = double.Parse(oku["Data11"].ToString());
                data.Data12 = double.Parse(oku["Data12"].ToString());
            }
            connection.Close();
            return data;
        }
        
    }
}
