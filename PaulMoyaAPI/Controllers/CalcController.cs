using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using PaulMoyaLIB;

namespace PaulMoyaAPI.Controllers
{
    /// <summary>
    /// Makes score calculations
    /// </summary>
    public class CalcController : ApiController
    {
        // GET: api/Calc
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "Calc1", "Calc2" };
        //}


        // GET: api/Calc/5
        //public string Get(int id)
        //{

        //}

        // POST: api/Calc
        /// <summary>
        /// Calculates the score
        /// </summary>
        /// <param name="calc"></param>
        /// <returns></returns>
        public IHttpActionResult Post([FromBody] CalcModel calc)
        {
            int result = PaulMoyaLIB.Calculator.Calculate(calc.str);
            calc.score = result;
            return Ok(calc.score);
        }
    

        // PUT: api/Calc/5
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        // DELETE: api/Calc/5
        //public void Delete(int id)
        //{
        //}
    }
}
