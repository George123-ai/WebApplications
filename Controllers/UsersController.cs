using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore.Storage;
using WebApplication1.models;
using System.Data.SqlClient;


namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        
        [HttpGet("222222")]
        public int GetAll() //encapsulation doma posmotret
        {
            return 111;
        }

        [HttpGet("333333")]
        public int Get3333() //encapsulation doma posmotret
        {
            return 888;
        }

        [HttpPost("PostAllData")]
        public ResponseModel PostAll(TestModel testModel)
        {

            ResponseModel responseModel = new ResponseModel();

            responseModel.Id = testModel.Name1 + 100;
            responseModel.Name = testModel.Name2 + "testing";
            responseModel.Description = testModel.Name2 + "testing description";

            //var a = testModel.Name1;
            //var b = testModel.Name2;


            return responseModel;
        }

        //[HttpDelete("DeletePost")]
        //public ResponseModel DeleteAll(TestModel testModel)
        //{

        //    ResponseModel responseModel = new ResponseModel();

        //    responseModel.Id = testModel.Name1 + 100;
        //    responseModel.Name = testModel.Name2 + "testing";
        //    responseModel.Description = testModel.Name2 + "testing description";

        //    //var a = testModel.Name1;
        //    //var b = testModel.Name2;


        //    return responseModel;
        //}
        //public DeleteModel DeleteAll(TestModel testModel) //encapsulation doma posmotret
        //{

        //    DeleteModel deleteModel = new DeleteModel();


        //    //responseModel.Id = testModel.Name1 + 100;
        //    //responseModel.Name = testModel.Name2 + "testing";
        //    //responseModel.Description = testModel.Name2 + "testing description";

        //    //var a = testModel.Name1;
        //    //var b = testModel.Name2;


        //    return deleteModel;
        //}
        //List<int> list = new List<int> { 1,2,3};

        //[HttpGet("GetNumbers")]
        //public List<int> Get()
        //{
        //    return list;
        //}

        //[HttpDelete("DeleteNumbers")]
        //public List<int> Delete(int n)
        //{
        //    list.Remove(n);
        //    return list;
        //}
        //SqlConnection con = new SqlConnection("Data Source=MSI;Initial Catalog=VegaVestaNew;Persist Security Info=True;User ID=sa;Password=***********");

        //[HttpGet("SqlData")]
        //public string GetSqlData()
        //{
        //    string result = "";
        //    SqlConnection con = new SqlConnection("Data Source=MSI;Initial Catalog=VegaVestaNew;Persist Security Info=True;User ID=sa;Password=goshan2034;TrustServerCertificate=true;");
        //    con.Open();
        //    SqlCommand cmd = new SqlCommand("select VegaBrandName from VegaBrand",con);
        //    // Console.WriteLine(cmd);
        //    cmd.ExecuteNonQuery();
        //    result = cmd.ToString();
        //    con.Close();

        //    return result;
        //}

        //[HttpGet("SqlData")]
        //public ActionResult<List<string>> GetSqlData()
        //{
        //    List<string> brands = new List<string> ();

        //    using (SqlConnection con = new SqlConnection("Data Source=MSI;Initial Catalog=VegaVestaNew;Persist Security Info=True;User ID=sa;Password=goshan2034;TrustServerCertificate=true;"))
        //    {
        //        SqlCommand cmd = new SqlCommand("Select * from VegaBrand",con);
        //        con.Open();
        //        using (SqlDataReader read = cmd.ExecuteReader())
        //        {
        //            while (read.Read())
        //                brands.Add(read.GetString(1));
        //        }
        //    }

        //    return brands;
        //}

        [HttpGet("SqlData")]
        public ActionResult<List<string>> GetSqlData()
        {
            List<string> brands = new List<string>();
            SqlConnection con = new SqlConnection("Data Source=MSI;Initial Catalog=VegaVestaNew;Persist Security Info=True;User ID=sa;Password=goshan2034;TrustServerCertificate=true;");
            SqlCommand cmd = new SqlCommand("Select VegaBrandName from VegaBrand", con);
            con.Open();
            SqlDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {
                brands.Add(read.GetString(0));
            }
            con.Close();
            return brands;
            
        }
    }
}
