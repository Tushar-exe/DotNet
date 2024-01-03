namespace DAL;
using BOL;

using MySql.Data.MySqlClient;


public static class DBManager
{
    public static string conString ="server=localhost;port=3306;user=root;password=root;database=dac45";

    public static MySqlConnection conn=null;

    public static List<User> Validate()
    {
        List<User>ulist=new List<User>();
        conn=new MySqlConnection();
        conn.ConnectionString=conString;
        string query="select * from user;";
          MySqlCommand cmd=new MySqlCommand(query,conn); 
        try{
             conn.Open();

             MySqlDataReader reader=cmd.ExecuteReader();

             while(reader.Read())
             {
                ulist.Add(new User(reader["uname"].ToString(),reader["password"].ToString()));
             }
          
            reader.Close();
            
        }catch(Exception e)
        {
            Console.WriteLine(e.Message);
        }finally{
            conn.Close();
        }
        return ulist;

    }


    public static void Register(User uobj)
    {
        conn=new MySqlConnection();

        conn.ConnectionString=conString;

        string query="insert into user values(@uname,@password,@emailId);";

        MySqlCommand cmd=new MySqlCommand(query,conn);

         cmd.Parameters.AddWithValue("uname",uobj.uname);
            cmd.Parameters.AddWithValue("password",uobj.password);
            cmd.Parameters.AddWithValue("emailId",uobj.emailId);

        try{
            conn.Open();

           

            cmd.ExecuteNonQuery();
        }catch(Exception e)
        {
            Console.WriteLine(e.Message);
        }
        finally{
            conn.Close();
        }
    }

}
