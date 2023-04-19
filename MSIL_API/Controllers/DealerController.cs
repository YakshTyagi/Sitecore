using Microsoft.AspNetCore.Mvc;
using MSIL_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MSIL_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DealerController : ControllerBase
    {
        // GET: api/<DealerController>
        [HttpGet]
        public IEnumerable<Dealers> Get()
        {
            return new Dealers[] {

                new Dealers { Contacts= "+91-9996642825466", Id = Guid.NewGuid(), Name="abc", Address="Ghaziabad" },
                new Dealers { Contacts= "+91-9996642825465", Id = Guid.NewGuid(), Name="mon", Address="Noida" },
                new Dealers { Contacts= "+91-9996642825436", Id = Guid.NewGuid(), Name="xyz", Address="Greatere Noida" }
            };
        }


    }
}
