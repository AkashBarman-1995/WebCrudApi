using EcommRestfulApiProject.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommRestfulApiProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CatagoryController : ControllerBase
    {
        public static List<Catagory> listofCatagories = new List<Catagory>()
        {
            new Catagory {Id=1,Title="I=phone",DisplayOrder=1},
            new Catagory{Id=2,Title="Samsung",DisplayOrder=2},
            new Catagory {Id=3,Title="OnePlus",DisplayOrder=3},
            new Catagory {Id=4,Title="Xiaomi",DisplayOrder=4},
            new Catagory {Id=5,Title="Nokia",DisplayOrder=5}
        };

        [HttpGet]
        public IEnumerable<Catagory>Get()
        {
            return listofCatagories;
        }

        [HttpPost]
        public void Post([FromBody] Catagory catagory)
        {
            listofCatagories.Add(catagory);
        }


        [HttpPut("{Id}")]
        public void Put(int Id,[FromBody]Catagory catagory)
        {
            listofCatagories[Id] = catagory;
        }

        [HttpDelete("{Id}")]

        public void Delete(int Id)
        {
            listofCatagories.RemoveAt(Id);
        }
    }
}
