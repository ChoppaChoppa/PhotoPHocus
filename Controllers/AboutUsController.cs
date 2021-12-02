using Microsoft.AspNetCore.Mvc;
using PHotoFockus.Data.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PHotoFockus.Controllers
{
    public class AboutUsController : Controller
    {
        public AboutUsController()
        {

        }

        public ViewResult AboutUsPage()
        {
            return View();
        }
    }
}
