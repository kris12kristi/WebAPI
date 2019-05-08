using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
  [Route("api/[controller]")]
  public class HomeController : Controller
  {

    // GET api/values
    [HttpGet]
    public string Get()
    {
      return DateTime.Now.ToString();
    }



  }
}
