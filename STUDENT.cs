using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Drawing;
using System.Windows.Forms;

namespace Hotel_Manager
{
    class STUDENT
    {
        MY_DB mydb = new MY_DB();

        public bool insertStudent(int Id, string fname, string lname, DateTime bdate, string gender, string phone, string address, MemoryStream picture)
        {
            SqlCommand command = new SqlCommand("INSERT INTO std (id, fname, lname, bdate, gender, phone, address, picture)"
                + " VALUES (@id, @fn, @ln, @bdt, @gdr, @phn, @adrs, @pic)", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = Id;
            command.Parameters.Add("@fn", SqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@ln", SqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@bdt", SqlDbType.DateTime).Value = bdate;
            command.Parameters.Add("@gdr", SqlDbType.VarChar).Value = gender;
            command.Parameters.Add("@phn", SqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@adrs", SqlDbType.VarChar).Value = address;
            command.Parameters.Add("@pic", SqlDbType.Image).Value = picture.ToArray();

            mydb.openConnection();
            try
            {
                if ((command.ExecuteNonQuery() == 1))
                {
                    mydb.closeConnection();
                    return true;                    
                }
                else
                {
                    mydb.closeConnection();
                    return false;                   
                }
            }
            catch
            {
                return false;
            }
        }
        public bool getData(int Id, ref string fname, ref string lname, ref DateTime bdate, ref string gender, ref string phone,
            ref string address, PictureBox picture)
        {
            try
            {
                SqlCommand command = new SqlCommand("SELECT * FROM std WHERE id = @id", mydb.getConnection);
                command.Parameters.Add("@id", SqlDbType.Int).Value = Id;
                mydb.openConnection();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    fname = reader["fname"].ToString();
                    lname = reader["lname"].ToString();
                    bdate = (DateTime)reader["bdate"];
                    gender = reader["gender"].ToString();
                    phone = reader["phone"].ToString();
                    address = reader["address"].ToString();
                    MemoryStream stream = new MemoryStream((byte[])reader["picture"]);
                    Image RetImage = Image.FromStream(stream);

                    picture.Image = RetImage;
                }
                reader.Close();
                mydb.closeConnection();
                return true;
            }
            catch
            {
                return false;
            }

            
        }
        public bool existUsername(string username)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM login WHERE username= @username", mydb.getConnection);
            command.Parameters.Add("@username", SqlDbType.VarChar).Value = username;
            mydb.openConnection();
            if (command.ExecuteScalar() == null)
            {
                mydb.closeConnection();
                return false;
            }
            else
            {
                mydb.closeConnection();
                return true;
            }
        }
        // neu khong co hoc sinh tra ve true, nguoc lai tra ve false.
        public bool existID(int ID)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM std WHERE id= @id", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = ID;
            mydb.openConnection();
            if (command.ExecuteScalar() == null)
            {
                mydb.closeConnection();
                return false;
            }
            else
            {
                mydb.closeConnection();
                return true;
            }                    
        }
        public bool updateStudent(int ID, string fname, string lname, DateTime bdate, string gender, string phone, string address, MemoryStream picture)
        {
            SqlCommand command = new SqlCommand("UPDATE std"
            + " SET id = @id, fname = @fn, lname = @ln, bdate = @bdt, gender = @gdr, phone = @phn, address = @adrs, picture = @pic"
            + " WHERE id = @id", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = ID;
            command.Parameters.Add("@fn", SqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@ln", SqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@bdt", SqlDbType.DateTime).Value = bdate;
            command.Parameters.Add("@gdr", SqlDbType.VarChar).Value = gender;
            command.Parameters.Add("@phn", SqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@adrs", SqlDbType.VarChar).Value = address;
            command.Parameters.Add("@pic", SqlDbType.Image).Value = picture.ToArray();

            mydb.openConnection();
            if ((command.ExecuteNonQuery() == 1))
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }
        }
        public bool deleteStudent(int Id, string fname, string lname, DateTime bdate, string phone, string address, string gender)
        {
            SqlCommand command = new SqlCommand("DELETE FROM std WHERE id= @id", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = Id;

            mydb.openConnection();
            if ((command.ExecuteNonQuery() == 1))
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }
        }
        public int studentNumber()
        {
            mydb.openConnection();
            SqlCommand sqlCommand = new SqlCommand("SELECT COUNT(*) FROM std", mydb.getConnection);
            int stdnum = Convert.ToInt32(sqlCommand.ExecuteScalar());
            
            mydb.closeConnection();
            return stdnum;
        }
    }
}
