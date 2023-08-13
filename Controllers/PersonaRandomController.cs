using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RandomAPI.modelos;
using System.Data.SqlClient;

namespace RandomAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonaRandomController : ControllerBase
    {
        private readonly IConfiguration configuration;
        public string cadenaConexion { get; set; }


        //Constructor...
        public PersonaRandomController(IConfiguration configuration)
        {
            this.configuration = configuration;
            cadenaConexion = this.configuration.GetConnectionString("SQL_FillTheGap");
        }




        [HttpPost]
        [Route("AddPersonaRandom")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public ActionResult AddPersonaRandom()
        {

            PersonaRandom personaRandom = new PersonaRandom();

            try
            {
                int lineasAfectadas = 0;
                using (SqlConnection sqlConnection = new SqlConnection(cadenaConexion))
                {
                    for (int i = 0; i < 250; i++)
                    {
                        string consulta = string.Format("INSERT INTO PersonaRandom(Nombre, Apellido) VALUES ('{0}','{1}')", personaRandom.NombreHombreHRandom(), personaRandom.ApellidoRandom());
                        SqlCommand cmd = new SqlCommand(consulta, sqlConnection);
                        sqlConnection.Open();
                        lineasAfectadas = lineasAfectadas +  cmd.ExecuteNonQuery();
                        sqlConnection.Close();

                    }
                   
                    return Ok("Registros Creados : " + Convert.ToString(lineasAfectadas));

                }

            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }


        }
    }
}

