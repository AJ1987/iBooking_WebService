using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace iBooking_WebService.Controllers
{
    /// <summary>
    ///  Controller for test
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        /// <summary>
        /// Get test
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public string Get()
        {
            return "AJ";
        }

        /// <summary>
        /// Post test
        /// </summary>
        [HttpPost]
        public void Post()
        { }

        /// <summary>
        ///  Put test
        /// </summary>
        [HttpPut]
        public void Put() { }

        /// <summary>
        ///  Delete test
        /// </summary>
        /// <returns></returns>
        [HttpDelete]
        public bool Del()
        {
            return true;
        }
    }
}
