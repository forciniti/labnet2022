using Lab.EF.Entities;
using Lab.EF.Logic;
using Lab.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;
using System.Web.UI.WebControls;
using static System.Collections.Specialized.BitVector32;

namespace Lab.MVC.Controllers
{
    public class ShippersController : Controller
    {
        readonly ShippersLogic logic = new ShippersLogic();
        // GET: Shippers
        public ActionResult Index()
        {
            var shippers = logic.GetAll();

            var ship = shippers.Select(x => new ShippersView
            {
                id = x.ShipperID,
                companyName = x.CompanyName,
                phone = x.Phone
            }).ToList();

            return View(ship);
        }
        public ActionResult Insert(string companyName, string phone)

        {
            try
            {
                logic.Add(new Shippers
                {
                    CompanyName = companyName,
                    Phone = phone
                });
                return RedirectToAction("Index");
            }
            catch (Exception)
            {
                return RedirectToAction("Error", "Errors");
            }


        }
        public ActionResult Update(string id, string companyName, string phone)
        {
            try
            {
                int ID = int.Parse(id);
                logic.Update(new Shippers
                {
                    ShipperID = ID,
                    CompanyName = companyName,
                    Phone = phone
                });
                return RedirectToAction("Index");
            }
            catch (Exception)
            {

                return RedirectToAction("Error", "Errors");
            }
        }
        public ActionResult Delete(int id)
        {
            try
            {
                logic.Delete(id);
                return RedirectToAction("Index");
            }
            catch (Exception)
            {

                return RedirectToAction("Error", "Errors");
            }
        }
    }
}