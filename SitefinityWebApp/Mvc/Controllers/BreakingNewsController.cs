using SitefinityWebApp.Mvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Telerik.Sitefinity.Mvc;

namespace SitefinityWebApp.Mvc.Controllers
{
    [ControllerToolboxItem(Name ="BreakingNews", Title ="Breaking News", SectionName ="CustomWidgets")]
    public class BreakingNewsController : Controller
    {
        public string BreakingNewsMessage { get; set; }
        public ActionResult Index() {
            var model = new BreakingNewsModel();
            model.Message = "Hello World";
            return View("Default", model);
        }
    }
}