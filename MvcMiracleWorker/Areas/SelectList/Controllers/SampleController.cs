using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcMiracleWorker.Areas.SelectList.Models;

namespace MvcMiracleWorker.Areas.SelectList.Controllers {

    public class SampleController : Controller {

        private readonly ProductCategoryRepo productCategoryRepo = new ProductCategoryRepo();

        public ActionResult Index() {

            registerProductCategorySelectListViewBag();
            return View();
        }

        private void registerProductCategorySelectListViewBag() {

            ViewBag.ProductCategorySelectList = 
                productCategoryRepo.GetAll().Select(
                    c => new SelectListItem { 
                        Text = c.CategoryName,
                        Value = c.CategoryId.ToString()
                    }
                );
        }
    }
}