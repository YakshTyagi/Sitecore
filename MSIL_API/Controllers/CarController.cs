using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MSIL_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MSIL_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        // GET: api/<CarController>
        [HttpGet]
        public IEnumerable<Car> Get()
        {
            return new Car[] {
                new Car
                {
                    Id = Guid.NewGuid(),
                    Name = "Brezza",
                    Variants = new List<CarsVariant>
                    {
                        new CarsVariant
                        {
                            Id = Guid.NewGuid(),
                            Name = "ZDI",
                            Specs = new CarSpecs { Engine = "1560CC" }
                        },
                        new CarsVariant
                        {
                            Id = Guid.NewGuid(),
                            Name = "ZXI",
                            Specs = new CarSpecs { Engine = "1560CC" }
                        },
                         new CarsVariant
                        {
                            Id = Guid.NewGuid(),
                            Name = "ZXI+",
                            Specs = new CarSpecs { Engine = "1560CC" }
                        }
                    }
                },
                new Car
                {
                    Id = Guid.NewGuid(),
                    Name = "Creta",
                    Variants = new List<CarsVariant>
                    {
                        new CarsVariant
                        {
                            Id = Guid.NewGuid(),
                            Name = "SX",
                            Specs = new CarSpecs { Engine = "1600CC" }
                        },
                        new CarsVariant
                        {
                            Id = Guid.NewGuid(),
                            Name = "SX(O)",
                            Specs = new CarSpecs { Engine = "1600CC" }
                        },
                         new CarsVariant
                        {
                            Id = Guid.NewGuid(),
                            Name = "AT",
                            Specs = new CarSpecs { Engine = "1600CC" }
                        }
                    }
                },
                 new Car
                {
                    Id = Guid.NewGuid(),
                    Name = "Nexon",
                    Variants = new List<CarsVariant>
                    {
                        new CarsVariant
                        {
                            Id = Guid.NewGuid(),
                            Name = "XM",
                            Specs = new CarSpecs { Engine = "1800CC" }
                        },
                        new CarsVariant
                        {
                            Id = Guid.NewGuid(),
                            Name = "XMS",
                            Specs = new CarSpecs { Engine = "1800CC" }
                        },
                         new CarsVariant
                        {
                            Id = Guid.NewGuid(),
                            Name = "XZ",
                            Specs = new CarSpecs { Engine = "1800CC" }
                        }
                    }
                },
                  new Car
                {
                    Id = Guid.NewGuid(),
                    Name = "Slavia",
                    Variants = new List<CarsVariant>
                    {
                        new CarsVariant
                        {
                            Id = Guid.NewGuid(),
                            Name = "Active",
                            Specs = new CarSpecs { Engine = "2000CC" }
                        },
                        new CarsVariant
                        {
                            Id = Guid.NewGuid(),
                            Name = "Ambition",
                            Specs = new CarSpecs { Engine = "2000CC" }
                        },
                         new CarsVariant
                        {
                            Id = Guid.NewGuid(),
                            Name = "Style",
                            Specs = new CarSpecs { Engine = "2000CC" }
                        }
                    }
                }

            };
        }
    }

}