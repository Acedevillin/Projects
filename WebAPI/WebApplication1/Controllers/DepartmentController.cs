using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Cryptography.X509Certificates;
using System.Web.Http;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class DepartmentController : ApiController
    {
        public HttpResponseMessage Get()
        {
            string query = @"select DepartmentID,DepartmentName from dbo.Department";
            DataTable table = new DataTable();
            
            using(var con= new SqlConnection(ConfigurationManager.ConnectionStrings["EmployeeAppDb"].ConnectionString))
            using(var cmd= new SqlCommand(query,con))
            using(var da= new SqlDataAdapter(cmd))
            {
                cmd.CommandType = CommandType.Text;
                da.Fill(table);
            }
            return Request.CreateResponse(HttpStatusCode.OK, table);

        }
        public string Post(Department dep)
        {
            try
            {

            }
            catch(Exception)
            {

            }

        }
    }
}
