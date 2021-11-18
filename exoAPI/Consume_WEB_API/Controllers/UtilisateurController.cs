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
                    Id = Convert.ToInt32(sdr.GetValue(0)),
                    Civilitie = (char)sdr.GetValue(1),
                    Name = sdr.GetValue(2).ToString(),
                    Firstame = sdr.GetValue(3).ToString(),
                    SecuNb = sdr.GetValue(4).ToString(),
                    Adress = { Id = Convert.ToInt32(sdr.GetValue(5)), StreetNb = sdr.GetValue(6).ToString(), StreetName = sdr.GetValue(7).ToString(), CityName = sdr.GetValue(8).ToString(), CP = sdr.GetValue(9).ToString() }
                });
            }
            return Ok(user);
        }
    }
}
