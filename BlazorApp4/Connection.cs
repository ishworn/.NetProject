using Npgsql;

namespace BusinessLayer
{
    public class Connection
    {
        public static NpgsqlConnection connect = null;
        public void Connect()
        {
            //connect = new NpgsqlConnection(@"Server=10.255.0.16;Port=5432;User Id=postgres;Password=prati800pm; Database=postgres;");
            connect = new NpgsqlConnection(@"Server=localhost; Port=5432;User Id=postgres;Password=123; Database=mydatabase;");

            try
            {
                connect.Open();
            }
            catch (Exception)
            {
                //nothing 
            }
        }
        public void Close()
        {

            try
            {
                connect.Close();
            }
            catch (Exception)
            {
                //nothing 
            }
        }
    }
}
