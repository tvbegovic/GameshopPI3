
using GameshopWeb.Db;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;
using Dapper;

namespace GameshopWeb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GameController : ControllerBase
    {
        private readonly IConfiguration configuration;

        public GameController(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        [HttpGet("genres")]
        public List<Genre> GetGenres()
        {
            using (var conn = new SqlConnection(configuration.GetConnectionString("connString")))
            {
                return conn.Query<Genre>("SELECT * FROM Genre").ToList();
            }
        }
    }
}
