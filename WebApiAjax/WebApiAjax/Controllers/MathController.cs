using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiAjax.Models;

namespace WebApiAjax.Controllers
{
    public class MathController : ApiController
    {
        // GET api/math/calculate
        [HttpGet]
        public CalcResult Calculate(int x, int y)
        {
            return new CalcResult()
            {
                Sum = x + y,
                Difference = x - y,
                Product = x * y,
                Quotient = x / y
            };
        }
    }
}
