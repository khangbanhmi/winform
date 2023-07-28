using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace StudentManager
{
    class Modify
    {
        SqlDataAdapter dataAdapter;// se truy xuat du lieeu vao bang
        SqlCommand sqlCommand; // truy van va cap nhat CSDL

        public Modify()
        {

        }

        //dataset tra ve nhieu bang
        //datatable tra ve 1 bang

        public DataTable getAllStudent()
        {
            DataTable dataTable = new DataTable();

            // lenh SQL lay bang student
            string query = "";

            using (SqlConnection sqlConnection = Connection.getConnection())
            {
                sqlConnection.Open();
                dataAdapter = new SqlDataAdapter(query, sqlConnection);
                dataAdapter.Fill(dataTable);


                sqlConnection.Close();
            }
            return dataTable;
        }

        public bool insert(Student student)
        {
            SqlConnection sqlConnection = Connection.getConnection();
            //query them student
            string query = "";
            try
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                //change
                sqlCommand.Parameters.Add("@MASV", SqlDbType.NVarChar).Value = student.Id;
                sqlCommand.Parameters.Add("@TENSV", SqlDbType.NVarChar).Value = student.Name;
                sqlCommand.Parameters.Add("@GIOITINH", SqlDbType.NVarChar).Value = student.Sex;
                sqlCommand.Parameters.Add("@ngaysin", SqlDbType.NVarChar).Value = student.Date.ToShortDateString();
                sqlCommand.Parameters.Add("@Diachi", SqlDbType.NVarChar).Value = student.Address;
                sqlCommand.Parameters.Add("@SDT", SqlDbType.NVarChar).Value = student.Phonenumber;
                sqlCommand.ExecuteNonQuery();
            }
            catch
            {
                return false;
            }
            finally
            {
                sqlConnection.Close();
            }
            return true;
        }

        public bool update(Student student)
        {
            SqlConnection sqlConnection = Connection.getConnection();
            //query them student
            string query = "";
            try
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                //change
                sqlCommand.Parameters.Add("@MASV", SqlDbType.NVarChar).Value = student.Id;
                sqlCommand.Parameters.Add("@TENSV", SqlDbType.NVarChar).Value = student.Name;
                sqlCommand.Parameters.Add("@GIOITINH", SqlDbType.NVarChar).Value = student.Sex;
                sqlCommand.Parameters.Add("@ngaysin", SqlDbType.NVarChar).Value = student.Date.ToShortDateString();
                sqlCommand.Parameters.Add("@Diachi", SqlDbType.NVarChar).Value = student.Address;
                sqlCommand.Parameters.Add("@SDT", SqlDbType.NVarChar).Value = student.Phonenumber;
                sqlCommand.ExecuteNonQuery();
            }
            catch
            {
                return false;
            }
            finally
            {
                sqlConnection.Close();
            }
            return true;
        }

        public bool delete(string id)
        {
            SqlConnection sqlConnection = Connection.getConnection();
            //query them student
            string query = "";
            try
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                //change
                sqlCommand.Parameters.Add("@MASV", SqlDbType.NVarChar).Value = id;
                sqlCommand.ExecuteNonQuery();
            }
            catch
            {
                return false;
            }
            finally
            {
                sqlConnection.Close();
            }
            return true;
        }
    }
}
