using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UtilisateurController : ControllerBase
    {
        List<Utilisateur> utilisateurs = new List<Utilisateur>
            {
                new Utilisateur( 0 , 'H', "Anderson", "Paul" , "178116235501717", new Adress ("241", "Rue jules verne", "Lille", "59000" )),
                new Utilisateur( 1 , 'F', "Anderson", "Pamela" , "278116335501713", new Adress ("241", "Rue jules verne", "Lille", "59000" )),
                new Utilisateur( 2 , 'H', "Dupont", "Joey" , "168096335501705", new Adress ("87", "Rue de mons", "Tourcoing", "59200" )),
                new Utilisateur( 3 , 'H', "Bachir", "Richard" , "19805642501715", new Adress ("532", "Rue de gand", "Tourcoing", "59200" )),
            };

        // GET: api/values
        [HttpGet]
        public List<Utilisateur> Get()
        {
            return utilisateurs;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Utilisateur Get(int id)
        {
            Utilisateur utilisateur = utilisateurs.Find(f => f.Id == id);
            return utilisateur;
        }

        // POST api/values
        [HttpPost]
        public List<Utilisateur> Post([FromBody] Utilisateur utilisateur)
        {
            utilisateurs.Add(utilisateur);
            return utilisateurs;
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public List<Utilisateur> Put(int id, [FromBody] Utilisateur utilisateur)
        {
            Utilisateur UserToUpdate = utilisateurs.Find(f => f.Id == id);
            int index = utilisateurs.IndexOf(UserToUpdate);

            utilisateurs[index].Civilitie = utilisateur.Civilitie;
            utilisateurs[index].Name = utilisateur.Name;
            utilisateurs[index].Firstame = utilisateur.Firstame;
            utilisateurs[index].SecuNb = utilisateur.SecuNb;
            utilisateurs[index].Adress.StreetNb = utilisateur.Adress.StreetNb;
            utilisateurs[index].Adress.StreetName = utilisateur.Adress.StreetName;
            utilisateurs[index].Adress.CityName = utilisateur.Adress.CityName;
            utilisateurs[index].Adress.CP = utilisateur.Adress.CP;

            return utilisateurs; 
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public List<Utilisateur> Delete(int id)
        {
            Utilisateur utilisateur = utilisateurs.Find(f => f.Id == id);
            utilisateurs.Remove(utilisateur);
            return utilisateurs;
        }
    }
}
