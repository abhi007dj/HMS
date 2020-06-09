using HMS.Areas.Dashboard.ViewModel;
using HMS.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HMS.Areas.Dashboard.Controllers
{
    public class AccomodationTypesController : Controller
    {

        AccomodationTypesService objAccomodationTypesService = new AccomodationTypesService();
        // GET: Dashboard/AccomodatioTypes
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult Listing()
        {
            AccomodationTypeViewModel objAccomodationTypeViewModel = new AccomodationTypeViewModel();
            objAccomodationTypeViewModel.AccomodationTypes = objAccomodationTypesService.GetAllAccomodationType();

            return PartialView("_Listing", objAccomodationTypeViewModel);
        }


        public ActionResult Action()
        {
            AccomodationTypeActionViewModel modal = new AccomodationTypeActionViewModel();
            return PartialView("_Action", modal);
        }
    }
}