using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Consume_WEB_API.Models;
using System.Net.Http;

namespace Consume_WEB_API.Controllers
{
    public class UtilisateurdisplayController : Controller
    {
        // GET: Utilisateurdisplay
        public ActionResult Index()
        {
            IEnumerable<Utilisateur> ec = null;
            HttpClient hc = new HttpClient();
            hc.BaseAddress = new Uri("http://https://localhost:44343/api/");

            var consumedata = hc.GetAsync("utilisateur");
            consumedata.Wait();

            var dataread = consumedata.Result;
            if (dataread.IsSuccessStatusCode)
            {
                var results = dataread.Content.ReadAsAsync<IList<Utilisateur>>();
                results.Wait();
                ec = results.Result;
            }

            return View(ec);
        }
    }
}