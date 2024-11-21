using System.Data;
using Microsoft.Data.SqlClient;
namespace RealEstateCoreMVC.Utilities
{
    public class AccountDB
    {
        private DBConnect db = new DBConnect();

        public bool LoginAccount(string username, string password)
        {
            SqlCommand objCommand = new SqlCommand();
            objCommand.CommandType = System.Data.CommandType.StoredProcedure;
            objCommand.CommandText = "LoginAccount";
            objCommand.Parameters.AddWithValue("@username", username);
            objCommand.Parameters.AddWithValue("@password", password);

            DataSet myData = db.GetDataSetUsingCmdObj(objCommand);

            if (myData.Tables[0].Rows.Count < 1)
            {
                return false;
            }

            return true;
        }
    }
}
