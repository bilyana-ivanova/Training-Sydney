using System;
using System.ComponentModel;
using System.Linq;
using System.Web.Mvc;
using Telerik.Sitefinity.Mvc;
using SitefinityWebApp.Mvc.Models;

namespace SitefinityWebApp.Mvc.Controllers
{
    [ControllerToolboxItem(Name = "Adder", Title = "Adder", SectionName = "MvcWidgets")]
    public class AdderController : Controller
    {
        private AdderModel model;
        [TypeConverter(typeof(ExpandableObjectConverter))]
        public AdderModel Model {
            get
            {
                if (this.model == null)
                    this.model = new AdderModel();
                return this.model;
            }
        }
        // GET: Adder
        public ActionResult Index()
        {
            this.Model.Sum = this.Model.A + this.Model.B;
            return View("Default", Model);
        }

        protected override void HandleUnknownAction(string actionName)
        {
            this.Index().ExecuteResult(this.ControllerContext);
        }
    }
}