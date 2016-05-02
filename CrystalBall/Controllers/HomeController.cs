using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CrystalBall.Models;

namespace CrystalBall.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public JsonResult ShakeBall()
        {
            //create an object of type CrystalBall  
            CrystalBalls ball = new CrystalBalls();
            string reply = ball.getResponse();
            return Json(reply, JsonRequestBehavior.AllowGet);
            //call then return to view
        }
    }
}