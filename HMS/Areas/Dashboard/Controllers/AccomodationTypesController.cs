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
        AccomodationType accomodationType = new AccomodationType();

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
        public ActionResult Action(int? Id)
        {
            AccomodationTypeActionViewModel objAccomodationTypeActionViewModel = new AccomodationTypeActionViewModel();

            if (Id.HasValue)  //we are tyring to edit
            {
                var data = objAccomodationTypesService.GeAccomodationTypeById(Id.Value);
                objAccomodationTypeActionViewModel.Id = data.Id;
                objAccomodationTypeActionViewModel.Name = data.Name;
                objAccomodationTypeActionViewModel.Description = data.Description;

            }

            return PartialView("_Action", objAccomodationTypeActionViewModel);
        }

        [HttpPost]
        public JsonResult Action(AccomodationTypeActionViewModel modal)
        {
            JsonResult Json = new JsonResult();
            var result = false;
            AccomodationTypesService objAccomodationTypesService = new AccomodationTypesService();

            if (modal.Id>0)  //we are tyring to edit
            {
                var data = objAccomodationTypesService.GeAccomodationTypeById(modal.Id);

            //    data.Id = modal.Id;

                data.Name = modal.Name;
                data.Description = modal.Description;

                result = objAccomodationTypesService.UpdateAccomodationType(data);

            }
            else
            {
                accomodationType.Name = modal.Name;
                accomodationType.Description = modal.Description;
                 result = objAccomodationTypesService.SaveAccomodationType(accomodationType);

            }
           

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

        [HttpGet]
        public ActionResult Delete(int? Id)
        {
            AccomodationTypeActionViewModel objAccomodationTypeActionViewModel = new AccomodationTypeActionViewModel();

            if (Id.HasValue)  //we are tyring to edit
            {
                var data = objAccomodationTypesService.GeAccomodationTypeById(Id.Value);
                objAccomodationTypeActionViewModel.Id = data.Id;

            }

            return PartialView("_Delete", objAccomodationTypeActionViewModel);
        }


        [HttpPost]
        public JsonResult Delete(AccomodationTypeActionViewModel modal)
        {
            JsonResult Json = new JsonResult();
            var result = false;
            AccomodationTypesService objAccomodationTypesService = new AccomodationTypesService();

            
                var data = objAccomodationTypesService.GeAccomodationTypeById(modal.Id);

                //    data.Id = modal.Id;

                result = objAccomodationTypesService.DeleteAccomodationType(data);

          

            if (result)
            {
                Json.Data = new { Success = true };
            }
            else
            {
                Json.Data = new { Success = false, Message = "Unable to Delete" };


            }

            return Json;
        }
    }
}