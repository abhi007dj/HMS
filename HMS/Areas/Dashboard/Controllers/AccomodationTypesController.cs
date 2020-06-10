using HMS.Areas.Dashboard.ViewModel;
using HMS.Entities;
using HMS.Services;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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

        [HttpGet]
        public ActionResult Action()
        {
            AccomodationTypeActionViewModel modal = new AccomodationTypeActionViewModel();
            return PartialView("_Action", modal);
        }

        [HttpPost]
        public JsonResult Action(AccomodationTypeActionViewModel modal)
        {
            JsonResult Json = new JsonResult();

            AccomodationTypesService objAccomodationTypesService = new AccomodationTypesService();

            AccomodationType objAccomodationType = new AccomodationType();
            objAccomodationType.Name = modal.Name;
            objAccomodationType.Description = modal.Description;


            var result = objAccomodationTypesService.SaveAccomodationType(objAccomodationType);

            if (result)
            {
                Json.Data = new { Success = true };
            }
            else
            {
                Json.Data = new { Success = false,Message ="Unable to save" };


            }

            return Json;
        }
    }
}