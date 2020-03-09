using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using WebApi.Models;

namespace WebApi.Data
{
    public class Operations
    {
        private SqlConnection conn;
        private SqlCommand cmd;
        private void ConnectionStr()
        {
            string connection = ConfigurationManager.ConnectionStrings["sqlconn"].ConnectionString;
            conn = new SqlConnection(connection);
        }
        /* ----------------------------------Get Employee-----------------------------   */
        public DataSet GetEmployee()
        {
            try
            {
                ConnectionStr();// connection method for connectionstrings
                using (conn)//conn is the connection object
                {
                    cmd = new SqlCommand("select * from TBL_EMPLOYEES", conn);
                    conn.Open();
                    SqlDataAdapter dadapter = new SqlDataAdapter(cmd);
                    DataSet dSet = new DataSet();
                    dadapter.Fill(dSet);

                    return dSet;
                }
            }
            catch (Exception ex)
            {

                throw ex;
               
            }
            finally
            {
                conn.Close();//closing the connection
                conn.Dispose();//dispose the connection object for GC

            }
        }

        /* ----------------------------------Get Employee Ends-----------------------------   */

            /*------------------------------------Single Data Method Starts Here--------------------------------*/
            public DataSet GetEmp(Employee employee)
        {
            try
            {
                ConnectionStr();// connection method for connectionstrings
                using (conn)//conn is the connection object
                {
                    cmd = new SqlCommand("select * from TBL_EMPLOYEES where EMP_Name=@Empname", conn);
                    cmd.Parameters.AddWithValue("@Empname", employee.EMP_Name);
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    return ds;
                    //SqlDataReader SingleDr = cmd.ExecuteReader();
                    //return SingleDr;
                }

    }
            catch (SqlException)
            {

                throw;
            }
            finally
            {
                conn.Close();//closing the connection
                conn.Dispose();//dispose the connection object for GC

            }
        }

        public bool PostInsert(Employee employee)
        {
            try
            {
                ConnectionStr();// connection method for connectionstrings
                using (conn)
                {
                    conn.Open();
                    SqlCommand insertCmd = new SqlCommand("USP_InsertEmployee @Emp_name,@Emp_dob,@Emp_salary,@Manager_Id,@IsTrainer", conn);//insert with procedure
                    insertCmd.Parameters.AddWithValue("@Emp_name", employee.EMP_Name);
                    insertCmd.Parameters.AddWithValue("@Emp_dob", employee.EMP_DOB);
                    insertCmd.Parameters.AddWithValue("@Emp_salary", employee.SALARY);
                    insertCmd.Parameters.AddWithValue("@Manager_Id", employee.Manager_Id);
                    insertCmd.Parameters.AddWithValue("@IsTrainer", employee.IsTrainer);
                    int response = insertCmd.ExecuteNonQuery();
                    if (response > 0)
                        return true;
                    else
                        return false;
                }

            }
            catch (SqlException)
            {

                throw;
            }
            finally
            {
                conn.Close();//closing the connection
                conn.Dispose();//dispose the connection object for GC

            }

        }

        //-----------------------------------------------update data method starts---------------------
        public bool PutEmp(Employee employee) //update the data 
        {
            try
            {

                ConnectionStr();
                using (conn)
                {
                    conn.Open();
                    SqlCommand putcmd = new SqlCommand("USP_UpdateEmp @Emp_Name,@Salary", conn);
                    putcmd.Parameters.AddWithValue("@Emp_Name", employee.EMP_Name);
                    putcmd.Parameters.AddWithValue("@Salary", employee.SALARY);
                    int response = putcmd.ExecuteNonQuery();
                    if (response > 0)
                        return true;
                    else
                        return false;
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                conn.Close();//closing the connection
                conn.Dispose();//dispose the connection object for GC
            }
        }

        public bool DeleteEmp(Employee employee)//--------------Delete Data--------------------
        {
            try
            {

                ConnectionStr();
                using (conn)
                {
                    conn.Open();
                    SqlCommand deletecmd = new SqlCommand("USP_DeleteEmp @Emp_Name", conn);
                    deletecmd.Parameters.AddWithValue("@Emp_Name", employee.EMP_Name);
                    int response = deletecmd.ExecuteNonQuery();
                    if (response > 0)
                        return true;
                    else
                        return false;
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                conn.Close();//closing the connection
                conn.Dispose();//dispose the connection object for GC
            }
        }
    }
}