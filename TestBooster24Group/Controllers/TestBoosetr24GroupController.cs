using System;
using System.Linq;
using System.Web.Mvc;
using TestBooster24GroupApp.Core;
using TestBooster24GroupApp.Core.Models;
using TestBooster24GroupApp.Core.ViewModel;

namespace TestBooster24GroupApp.Controllers
{
    [Authorize(Roles = RoleName.DoctorRoleName + "," + RoleName.AdministratorRoleName)]
    public class TestBoosetr24GroupController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public TestBoosetr24GroupController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public ActionResult Index()
        {
            var appointments = _unitOfWork.TestBoosetr24Groups.GetTestBoosetr24Groups();
            return View(appointments);
        }
   
        public ActionResult Details(int id)
        {
            var testgroup24 = _unitOfWork.TestBoosetr24Groups.GetTestBoosetr24Group(id);
            return View("_TestBooster24Group", testgroup24);
        }

        [Authorize]
        public ActionResult Create()
        {
            var viewModel = new TestBoosetr24GroupViewModel
            {
                Cities = _unitOfWork.Cities.GetCities(),
               

            };
            return View("Create", viewModel);
        }

        public ActionResult Create(int id)
        {
            var viewModel = new TestBoosetr24GroupViewModel
            {
                Cities = _unitOfWork.Cities.GetCities(),
                GroupOwnerId = id
                 
            };
            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(TestBoosetr24GroupViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                viewModel.Cities = _unitOfWork.Cities.GetCities();
                viewModel.Patients = _unitOfWork.TestBoosetr24Groups.GetTestBoosetr24GroupPatient(viewModel.Id).ToList();
                return View("TestBoosetr24GroupForm", viewModel);

            }

            var testgroup = new TestBoosetr24Group()
            {
                CreationDate = viewModel.CreationDate,
                Address = viewModel.Address ,
                CityId = viewModel.City,
                Cities = _unitOfWork.Cities.GetCities(),
                GroupOwnerId = viewModel.GroupOwnerId,
                Name = viewModel.Name,
                Id= viewModel.Id,
                TestStatus = viewModel.TestStatus,
                Patients = viewModel.Patients,
                Token = (2020 + _unitOfWork.TestBoosetr24Groups.GetTestBoosetr24Groups().Count()).ToString().PadLeft(7, '0')
               };           

            _unitOfWork.TestBoosetr24Groups.Add(testgroup);
            _unitOfWork.Complete();
            return View("Create", viewModel);
        }


      
        public ActionResult Edit(int id)
        {
            var testgroup = _unitOfWork.TestBoosetr24Groups.GetTestBoosetr24Group(id);
            var viewModel = new TestBoosetr24GroupViewModel()
            {
               
                Id = testgroup.Id,
                CreationDate = testgroup.CreationDate,            
                TestStatus = testgroup.TestStatus,
                Patients = testgroup.Patients,
                GroupOwnerId = testgroup.GroupOwnerId,
                 Address = testgroup.Address,
                 Cities = testgroup.Cities,
                 Name = testgroup.Name,
            };
            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(TestBoosetr24GroupViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                viewModel.Cities = _unitOfWork.Cities.GetCities();
                return View("TestBoosetr24GroupForm", viewModel);
            }

            var groupInDb = _unitOfWork.TestBoosetr24Groups.GetTestBoosetr24Group(viewModel.Id);
            groupInDb.Id = viewModel.Id;
            groupInDb.CreationDate = viewModel.CreationDate;
            groupInDb.TestStatus = viewModel.TestStatus;
            groupInDb.Patients = viewModel.Patients;
            groupInDb.GroupOwnerId = viewModel.GroupOwnerId;
            groupInDb.Address = viewModel.Address;
            groupInDb.CityId = viewModel.City;
            groupInDb.Name = viewModel.Name;
            groupInDb.Cities = _unitOfWork.Cities.GetCities();



            _unitOfWork.Complete();
            return RedirectToAction("Index", "TestBoosetr24Group");

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SendNotification(TestBoosetr24GroupViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                viewModel.Cities = _unitOfWork.Cities.GetCities();
                return View("TestBoosetr24GroupForm", viewModel);
            }

            var groupInDb = _unitOfWork.TestBoosetr24Groups.GetTestBoosetr24Group(viewModel.Id);
            groupInDb.Id = viewModel.Id;
            groupInDb.CreationDate = viewModel.CreationDate;
            groupInDb.TestStatus = viewModel.TestStatus;
            groupInDb.Patients = viewModel.Patients;
            groupInDb.GroupOwnerId = viewModel.GroupOwnerId;
            groupInDb.Address = viewModel.Address;
            groupInDb.CityId = viewModel.City;
            groupInDb.Name = viewModel.Name;
            groupInDb.Cities = _unitOfWork.Cities.GetCities();



            _unitOfWork.Complete();
            return RedirectToAction("Index", "TestBoosetr24Group");

        }


     
        public ActionResult SendNotification(int id)
        {
            var testgroup24 = _unitOfWork.TestBoosetr24Groups.GetTestBoosetr24Group(id);
            return View("Notification", testgroup24);
          
            
        }


        public ActionResult DoctorsList()
        {
            var doctors = _unitOfWork.Doctors.GetAvailableDoctors();
            if (HttpContext.Request.IsAjaxRequest())
                return Json(new SelectList(doctors.ToArray(), "Id", "Name"), JsonRequestBehavior.AllowGet);
            return RedirectToAction("Create");
        }

      

    }
}