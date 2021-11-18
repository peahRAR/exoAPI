using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Consume_WEB_API.Models;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Consume_WEB_API.Controllers
{
    public class UtilisateurController : ApiController
    {
    public IHttpActionResult getUtilisateur()
        {
            List<Utilisateur> user = new List<Utilisateur>();
            string mainconn = ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(mainconn);
            string sqlquery = "SELECT * FROM [dbo].[Utilisateurs] INNER JOIN [dbo].[Adress] ON [dbo].[Utilisateurs].Id_Adress = [dbo].[Adress].Id ";
            sqlconn.Open();
            SqlCommand sqlcomm = new SqlCommand(sqlquery, sqlconn);
            SqlDataReader sdr = sqlcomm.ExecuteReader();
            while (sdr.Read())
            {
                user.Add(new Utilisateur()
                {
                    Id = sdr.GetInt32(0),
                    Civilitie = sdr.GetString(1),
                    Name = sdr.GetString(2),
                    Firstame = sdr.GetString(3),
                    SecuNb = sdr.GetString(4),
                    // Adress
                    Adress = new Adress {
                        StreetNb = sdr.GetString(7),
                        StreetName = sdr.GetString(8),
                        CityName = sdr.GetString(9),
                        CP = sdr.GetString(10)
                    }
                    
                });
            }
            return Ok(user);
        }
    }
}
