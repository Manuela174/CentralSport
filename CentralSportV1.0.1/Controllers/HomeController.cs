using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Net.Mail;
using CentralSportV1._0._1.Models;
using System.Text;

namespace CentralSportV1._0._1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ContactUS()
        {
            return View();
        }
        [HttpPost]
        public ActionResult ContactUS(CentralSportV1._0._1.Models.gmail model)
        {
            MailMessage mm = new MailMessage("centralsport.test@gmail.com", "centralsport.test@gmail.com");
            mm.Subject = model.Subject;
            mm.Body = model.Body;
            mm.IsBodyHtml = false;

            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;
            smtp.EnableSsl = true;

            NetworkCredential nc = new NetworkCredential("centralsport.test@gmail.com", "Test!2345");
            smtp.UseDefaultCredentials = true;
            smtp.Credentials = nc;
            smtp.Send(mm);
            ViewBag.Message = "Mail Has Been Sent!";

            return View();
        }




    }
}