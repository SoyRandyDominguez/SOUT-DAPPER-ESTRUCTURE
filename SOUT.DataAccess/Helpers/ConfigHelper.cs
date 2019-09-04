using System;
using System.Collections.Generic;
using System.Text;

namespace SOUT.DataAccess.Helpers
{
    public class ConfigHelper
    {
        public static class ConfigReader
        {
            public static string ReadString(SOUT.Config.ConfigEnums pConfigId)
            {
                return SOUT.DataAccess.Encryption.Encryptor.DecryptConfig(SOUT.Config.Reader.ReadString(pConfigId));
            }
        }
        public static System.Data.SqlClient.SqlConnection GetSqlConnection()
        {
            return new System.Data.SqlClient.SqlConnection(ConfigReader.ReadString(SOUT.Config.ConfigEnums.DBConnection1));
        }




    }
}
