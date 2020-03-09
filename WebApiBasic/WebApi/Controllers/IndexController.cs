using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApi.Data;
using WebApi.Models;

namespace WebApi.Controllers
{
    public class IndexController : ApiController
    {
        Operations op = new Operations();
        //-------------------------Show method starts here------------------      
        [HttpGet]
        public IHttpActionResult Show()
        {
            DataSet dSet = op.GetEmployee();
            return Ok(dSet);
                     
        }
        //---------------------------Show method Ends here-------------------

        //----------------------------Single Data Method Starts Here-----------
        public IHttpActionResult PostSingleData(Employee emp)
        {
            DataSet dataSet = op.GetEmp(emp);
            return Ok(dataSet);
        }


        //----------------------------Single Data Method Ends Here-----------


        //-------------------------Insert Method Starts here-------------------


        public IHttpActionResult PostData(Employee emp)
        {
            bool response = op.PostInsert(emp);
            return Ok(response);
        }

        //-------------------------Insert Method Starts here-------------------

        //----------------------Update Method Starts Here------------------
        public IHttpActionResult PutData(Employee emp)
        {
            bool response = op.PutEmp(emp);
            return Ok(response);

        }
        //------------------------Delete Method starts Here------------------- 
        public IHttpActionResult DeleteData(Employee emp)
        {
            bool response = op.DeleteEmp(emp);
            return Ok(response);
        }
        //-----------------------Delete Method Ends Here-----------------------

    }
}
