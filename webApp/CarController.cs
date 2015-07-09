﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace webApp
{
    public class Car
        {
            public int ID { get; set; }
            public string Make { get; set; }
            public string Model { get; set; }
        }
    
    public class CarController : ApiController
    {
        public IEnumerable<string> Get()
        {
            return "Ford";
        }
}
