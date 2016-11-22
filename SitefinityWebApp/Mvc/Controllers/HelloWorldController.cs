using System;
using System.ComponentModel;
using System.Linq;
using System.Web.Mvc;
using Telerik.Sitefinity.Mvc;
using SitefinityWebApp.Mvc.Models;
using Telerik.Sitefinity.Modules.News;
using Telerik.Sitefinity.Services;
using Telerik.Sitefinity.Data;
using Telerik.Sitefinity.News.Model;
using Telerik.Sitefinity.Frontend.Mvc.Infrastructure.Controllers;
using System.Collections.Generic;

namespace SitefinityWebApp.Mvc.Controllers
{
    [ControllerToolboxItem(Name = "HelloWorld", Title = "HelloWorld", SectionName = "CustomWidgets")]
    public class HelloWorldController : Controller
    {
        /// <summary>
        /// Gets or sets the message.
        /// </summary>
        [Category("String Properties")]
        public string Message { get; set; }

        /// <summary>
        /// This is the default Action.
        /// </summary>
        public ActionResult Index()
        {
            var model = new HelloWorldModel();
            model.Message = NewsManager.GetManager().GetNewsItems().FirstOrDefault().Title.ToString();

            if (SystemManager.CurrentHttpContext != null)
            {
                var result = new List<CacheDependencyKey>(1);
                result.Add(new CacheDependencyKey { Key = "6ed9ee45-1fb5-61e1-a9ee-ff0000d7bc5f", Type = typeof(NewsItem) });
                this.AddCacheDependencies(result);
            }
            return View("Default", model);
        }

        public ActionResult RandomNumber()
        {
            Random random = new Random();
            int randomNumber = random.Next();

            HelloWorldModel model = new HelloWorldModel();
            model.RandomNumber = randomNumber;

            return View("RandomNumber", model);
        }
    }
}