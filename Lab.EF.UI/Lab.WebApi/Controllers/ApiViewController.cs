using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Lab.WebApi.Controllers
{
    public class ApiViewController : Controller
    {
        // GET: ApiView
        public ActionResult Index()
        {
            var url = $"https://v2.jokeapi.dev/joke/Programming?format=txt&type=single";
            var request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            request.ContentType = "application/json";
            request.Accept = "application/json";
            try
            {
                using (WebResponse response = request.GetResponse())
                {
                    using (Stream strReader = response.GetResponseStream())
                    {
                        using (StreamReader objReader = new StreamReader(strReader))
                        {
                            string responseJoke = objReader.ReadToEnd();
                            ViewBag.Jokes = responseJoke;
                        }
                    }
                }
            }
            catch (WebException )
            {
                return RedirectToAction("Index");
            }
            return View();
        }
        public ActionResult ToIndex()
        {
            return RedirectToAction("Index", "ApiView");
        }
    }
}