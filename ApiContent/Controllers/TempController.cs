﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ApiContent.Models;
namespace ApiContent.Controllers
{
    public class TempController : ApiController
    {
        // GET api/<controller>
        public List<test> getuser()
        {
            bhavanimotorsdbEntities db = new bhavanimotorsdbEntities();
            var data = db.tests.ToList();
            //return new string[] { "value1", "value2" };
            return data;
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}