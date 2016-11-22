using System;
using System.ComponentModel;
using System.Linq;
using System.Web.Mvc;
using Telerik.Sitefinity.Mvc;
using SitefinityWebApp.Mvc.Models;

namespace SitefinityWebApp.Mvc.Controllers
{
    [ControllerToolboxItem(Name = "Webinar", Title = "Webinar", SectionName = "MvcWidgets")]
    public class WebinarController : Controller
    {
        private WebinarModel model;
        [TypeConverter(typeof(ExpandableObjectConverter))]
        public WebinarModel Model
        {
            get
            {
                if (this.model == null)
                    this.model = new WebinarModel();
                return this.model;
            }
        }

        /// <summary>
        /// This is the default Action.
        /// </summary>
        public ActionResult Index()
        {
            return View("Default", Model);
        }
    }
}