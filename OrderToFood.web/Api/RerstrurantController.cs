using OrderFood.Data.Models;
using OrderFood.Data.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace OrderToFood.web.Api
{
    public class RerstrurantController : ApiController
    {
        private readonly IRestruant db;
        public RerstrurantController(IRestruant db1)
        {
            this.db = db1;
        }
        public IEnumerable<Restruant> Get()
        {
            var model = db.GetAll();
            return model;
           // return "Hello World";
        }
    }
}
