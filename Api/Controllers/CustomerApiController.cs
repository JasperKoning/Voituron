﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Voituron_Framework;

namespace Api.Controllers
{
    //[Authorize]
    public class CustomerApiController : ApiController
    {
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public CustomerSnelStart Get(int id)
        {
            CustomerSnelStart obj = CustomerSnelStartConnector.Get(id);
            return obj;
        }

        // POST api/values
        public void Post([FromBody]CustomerSnelStart value)
        {
            var x = value;
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
            var i = id;
            var x = value;
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
            var x = id;
        }
    }
}
