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
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
