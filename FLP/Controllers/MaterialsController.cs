using System;
using System.Globalization;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using FLP.Models;
using System.Net.Mail;

namespace FLP.Controllers
{
    public class MaterialsController : Controller
    {

        public ActionResult WiFiMaterial()
        {
            return View();
        }
        public ActionResult Uslugi()
        {
            return View();
        }
        public ActionResult Qestions()
        {
            return View();
        }
        public ActionResult NetworksMaterial()
        {
            return View();
        }
        public ActionResult BildingMaterial()
        {
            return View();
        }
        public ActionResult SignalMaterial()
        {
            return View();
        }

        [HttpGet]
        public ActionResult AjaxSendMessage(string phone, string mail, string text, int type)
        {
            var body = "";
            var subject = "";
            var mail1 = "lipinskiy.development@gmail.com";
            var mail2 = "d.leshikevich@gmail.com";
            if (type == 1)
            {
                body = "Вопрос с сайта:  " + text + " , номер телефона - " + phone + " , email - " + mail;
                subject = "Вопрос на сайте";
                SendMessage("Спасибо за обращение на наш сайт, мы свяжемся с вами в ближайшее время ", mail, "Спасибо за обращение ");
            }
            if (type == 2)
            {
                body = "Необходимо Набрать номер телефона:  " + phone + " с email - " + mail;
                subject = "Перезвонить на сайт";
            }
            SendMessage(body, mail1, subject);
            SendMessage(body, mail2, subject);
            return Json("OK", JsonRequestBehavior.AllowGet);
        }
        
        public void SendMessage(string body, string mail, string subject)
        {
            SmtpClient client = new SmtpClient();
            client.Port = 587;
            client.Host = "smtp.gmail.com";
            client.EnableSsl = true;
            client.Timeout = 10000;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.UseDefaultCredentials = false;
            client.Credentials = new System.Net.NetworkCredential("lipinskiy.development@gmail.com", "Ramzes12345");

            MailMessage mm = new MailMessage("lipinskiy.development@gmail.com", mail, subject, body);
            mm.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;

            try
            {
                client.Send(mm);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception caught in CreateTestMessage2(): {0}",
                            ex.ToString());
            }
        }
    }
}