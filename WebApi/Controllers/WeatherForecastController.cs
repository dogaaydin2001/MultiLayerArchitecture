using DataAccess.Concrete.EntityFramework.Context;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Data.SqlClient;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        SqlConnection con = new SqlConnection("Server=DOGAA-NB\\MSSQLSRV;Database=DemoDb;Integrated Security=True");
        SimpleContextDb context = new SimpleContextDb();
        
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            //have user and make a user list
            SqlDataAdapter adp = new SqlDataAdapter("Select * From Users", con);
            DataTable da = new DataTable();
            da.Clear();
            adp.Fill(da);

            // dont have user and add user
            SqlCommand kmt = new SqlCommand("insert into Users(Name, ImageUrl, Password) Values(Name, ImageUrl, Password)", con);
            con.Open();
            kmt.ExecuteNonQuery();
            con.Close();

            context.Users.ToList();


            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}