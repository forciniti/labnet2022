﻿using Lab.EF.Entities;
using Lab.EF.Logic;
using Lab.WebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Mvc;
using HttpPutAttribute = System.Web.Http.HttpPutAttribute;

namespace Lab.WebApi.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class ShippersApiController : ApiController
    {
        // GET: api/ShippersApi
        readonly ShippersLogic logic = new ShippersLogic();
        public IHttpActionResult GetShippers()
        {

            try
            {
                var shippers = logic.GetAll();
                var shipp = shippers.Select(x => new ShippersModel
                {
                    id = x.ShipperID,
                    companyName = x.CompanyName,
                    phone = x.Phone

                }).ToList();

                return Ok(shipp);
            }
            catch (Exception ex)
            {
                return Content(HttpStatusCode.BadRequest, ex);
            }

        }

        //POST: api/ShippersApi

        public IHttpActionResult AddShipper([FromBody] ShippersModel shipperModel)
        {
            try
            {
                Shippers shipp = new Shippers()
                {
                    CompanyName = shipperModel.companyName,
                    Phone = shipperModel.phone
                };
                this.logic.Add(shipp);
                return Content(HttpStatusCode.Created, shipp);
            }
            catch (Exception ex)
            {
                return Content(HttpStatusCode.BadRequest, ex);
            }

        }
        //PUT: api/ShippersApi/{id}
        [HttpPut]
        public IHttpActionResult PUT([FromBody] ShippersModel shipperModel, int id)
        {
            try
            {
                int idExistent = logic.GetAll().Where(x => x.ShipperID == id).Count();
                Shippers shipp = new Shippers()
                {
                    ShipperID = id,
                    CompanyName = shipperModel.companyName,
                    Phone = shipperModel.phone
                };

                if (idExistent == 1)
                {
                    this.logic.Update(shipp);
                    return Content(HttpStatusCode.OK, shipp);
                }
                else
                {
                    return Content(HttpStatusCode.BadRequest, shipp);
                }
            }

            catch (Exception ex)
            {
                return Content(HttpStatusCode.BadRequest, ex);
            }

        }
        //DELETE: api/ShippersDelete/{id}
        public IHttpActionResult DeleteShipper(int id)
        {   
            try
            {
                    logic.Delete(id);

                    return Ok("id " + id + " DELETED");
                
            }
            catch (Exception ex)
            {
                return Content(HttpStatusCode.NotAcceptable, ex);
            }
        }

    }
}