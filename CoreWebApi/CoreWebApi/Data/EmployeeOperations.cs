using CoreWebApi.Models;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace CoreWebApi.Data
{
    public class EmployeeOperations : IEmployeeOperations
    {
        private readonly IOptions<Connection> _connection;
        SqlConnection sqlconn = null;
        SqlCommand cmd = null;

        public EmployeeOperations(IOptions<Connection> connection)
        {
            _connection = connection;
        }
        /// <summary>
        /// Connection method which initialize the sqlconnection object
        /// </summary>
        public void Connection()
        {
            string conn = _connection.Value.connectionString;
            sqlconn = new SqlConnection(conn);

        }
        /// <summary>
        /// Here we are getting the Employee Data
        /// </summary>
        /// <returns>DataSet</returns>
        public DataSet GetEmployee()
        {
            try
            {
                Connection();
                using (sqlconn)
                {
                    SqlCommand cmd = new SqlCommand("select * from TBL_EMPLOYEES", sqlconn);
                    sqlconn.Open();
                    SqlDataAdapter dadapter = new SqlDataAdapter(cmd);
                    DataSet dSet = new DataSet();
                    dadapter.Fill(dSet);

                    return dSet;
                }
            }
            catch (SqlException ex)
            {

                throw ex;

            }
            finally
            {
                sqlconn.Close();
                sqlconn.Dispose();

            }
        }
        /// <summary>
        /// Getting The Single Data Of Employee
        /// </summary>
        /// <param name="employee"></param>
        /// <returns>Dataset</returns>

            
        public DataSet GetEmp(EmployeeModel employee)
        {
            try
            {
                Connection();
                using (sqlconn)
                {
                    cmd = new SqlCommand("select * from TBL_EMPLOYEES where EMP_Name=@Empname", sqlconn);
                    cmd.Parameters.AddWithValue("@Empname", employee.EMP_Name);
                    sqlconn.Open();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    return ds;
                }

            }
            catch (SqlException)
            {

                throw;
            }
            finally
            {
                sqlconn.Close();
                sqlconn.Dispose();

            }
        }
        /// <summary>
        /// Insert employee Details
        /// </summary>
        /// <param name="employee"></param>
        /// <returns>Bool</returns>
        public bool PostInsert(EmployeeModel employee)
        {
            try
            {
                Connection();// connection method for connectionstrings
                using (sqlconn)
                {
                    sqlconn.Open();
                    SqlCommand insertCmd = new SqlCommand("USP_InsertEmployee @Emp_name,@Emp_dob,@Emp_salary,@Manager_Id,@IsTrainer", sqlconn);//insert with procedure
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
                sqlconn.Close();
                sqlconn.Dispose();

            }

        }
        /// <summary>
        /// Here Employee detail is updated
        /// </summary>
        /// <param name="employee"></param>
        /// <returns>Bool</returns>
        
        public bool PutEmp(EmployeeModel employee) { 
            try
            {

                Connection();
                using (sqlconn)
                {
                    sqlconn.Open();
                    SqlCommand putcmd = new SqlCommand("USP_UpdateEmp @Emp_Name,@Salary", sqlconn);
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
                sqlconn.Close();
                sqlconn.Dispose();
            }
        }
        /// <summary>
        /// Delete Employee from Database
        /// </summary>
        /// <param name="employee"></param>
        /// <returns>Bool</returns>
        public bool DeleteEmp(EmployeeModel employee)
        {
            try
            {

                Connection();
                using (sqlconn)
                {
                    sqlconn.Open();
                    SqlCommand deletecmd = new SqlCommand("USP_DeleteEmp @Emp_Name", sqlconn);
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
                sqlconn.Close();
                sqlconn.Dispose();
            }
        }
    }
}
