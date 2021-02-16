using System.Reflection;

using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using ModelFun.Models;
namespace ModelFun.Models
{
    public class ModelFun: Controller
    {
          [HttpGet("")]
        public IActionResult Index()
        {
            Models.Content content = new Models.Content("Lorem ipsum dolor sit amet, nec stet rebum offendit ne, ius te nullam postulant. Mel meliore deserunt ne, mei id nullam impetus, porro iracundia temporibus pro in. Sed an eruditi recusabo euripidis, ad nusquam percipitur eam.");
            return View("index", content);
        }
        [HttpGet("numbers")]
        public IActionResult Numberpage()
        {
            int [] arr = {1,2,50,90,30,22,77,1,3,45};
            Models.Number numsarr = new Models.Number(arr);
            return View("numbers", numsarr);

        }
        [HttpGet("user")]
        public IActionResult SingleUserpage()
        {
            string su = "Joseph";
            Models.User singleuser = new Models.User(su);
            return View("user",singleuser);
        }

        [HttpGet("users")]
        public IActionResult Userpage()
        {
            string[] arr = { "joe","jojo","joey","Joseph","jose"};
            Models.User usersarr = new Models.User(arr);
            return View("users", usersarr);

        }
    }


}