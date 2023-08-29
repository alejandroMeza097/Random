using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
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
                    for (int i = 0; i < 125; i++)
                    {
                        string consulta = string.Format("INSERT INTO PersonaRandom(Nombre, Apellido) VALUES ('{0}','{1}')", personaRandom.NombreHombreHRandom(), personaRandom.ApellidoRandom());
                        SqlCommand cmd = new SqlCommand(consulta, sqlConnection);
                        sqlConnection.Open();
                        lineasAfectadas = lineasAfectadas +  cmd.ExecuteNonQuery();
                        sqlConnection.Close();

                    }

                    for (int i = 0; i < 125; i++)
                    {
                        string consulta = string.Format("INSERT INTO PersonaRandom(Nombre, Apellido) VALUES ('{0}','{1}')", personaRandom.NombreMujerRandom(), personaRandom.ApellidoRandom());
                        SqlCommand cmd = new SqlCommand(consulta, sqlConnection);
                        sqlConnection.Open();
                        lineasAfectadas = lineasAfectadas + cmd.ExecuteNonQuery();
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


        //End point HttpGet con api...
        [HttpPost]
        [Route("AddUniversity")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult <List<escuela>>> PostUniversityAsync(string pais)
        {
            try
            {
                if (pais == null || pais == "")
                {
                    return BadRequest("Pais no valido");
                }

                HttpClient client = new HttpClient();
                HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, $"http://universities.hipolabs.com/search?country={pais}");
                var response = await client.SendAsync(request);
                response.EnsureSuccessStatusCode();

                string data = await response.Content.ReadAsStringAsync();
                List<escuela> listaEscuelas = new List<escuela>();
                listaEscuelas = JsonConvert.DeserializeObject<List<escuela>>(data);

                using (SqlConnection sqlConnection = new SqlConnection(cadenaConexion) )
                {
                    int lineasAfectadas = 0;
                    foreach (var esc in listaEscuelas)
                    {
                        string consulta = string.Format($"INSERT INTO UniversidadesApi(Pais, Codigo, Nombre) VALUES ('{esc.country}','{esc.alpha_two_code}','{esc.name}')");
                        SqlCommand cmd = new SqlCommand(consulta, sqlConnection);
                        sqlConnection.Open();
                        lineasAfectadas = lineasAfectadas + cmd.ExecuteNonQuery();
                        sqlConnection.Close();

                    }

                }
                
                return Ok(listaEscuelas);


            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            
            

        }
    }
}

