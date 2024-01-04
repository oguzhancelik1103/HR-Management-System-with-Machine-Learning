using BusinessLayer.Concrete;
using BusinessLayer.Concrete.People;
using BusinessLayer.Concrete.System;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using DataAccessLayer.Models;
using EntityLayer.Models;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CILOGLU_COBAN.Controllers
{
    public class PersonController : Controller
    {
        Context _context;

        EFPersonDal efd;
        EFPersonCardDal efc;
        EFPersonTypeDal eft;
        EFSysUserDal esu;
        EFSysCompanyDal esc;
        EFSysPositionDal epd;
        EFPersonModelDal emd;

        PersonManager mg;
        PersonTypeManager pt;
        PersonCardManager pc;
        SysUserManager su;
        SysCompanyManager sc;
        SysPositionManager pm;
        PersonModelManager mm;

        public PersonController(Context context)
        {
            _context = context;

            efd = new EFPersonDal(context);
            efc = new EFPersonCardDal(context);
            eft = new EFPersonTypeDal(context);
            esu = new EFSysUserDal(context);
            esc = new EFSysCompanyDal(context);
            epd = new EFSysPositionDal(context);
            
            emd = new EFPersonModelDal(context);
            mm = new PersonModelManager(efd, efc, esu);//, emd);

            mg = new PersonManager(efd);
            pc = new PersonCardManager(efc);
            pt = new PersonTypeManager(eft);
            su = new SysUserManager(esu);
            sc = new SysCompanyManager(esc);
            pm = new SysPositionManager(epd);
        }

        public IActionResult Index()
        {
            var personValues = mg.GetList();
            return View(personValues);
        }

        [HttpGet]
        public IActionResult AddPerson()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddPerson(PersonModel model)
        {
            PersonValidator validationRules = new PersonValidator();
            ValidationResult validationResult = validationRules.Validate(model);
            if (validationResult.IsValid)
            {
                mg.AddPerson(model.Person);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in validationResult.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }

        public IActionResult DeletePerson(int id)
        {
            var personValue = mg.GetByID(id);
            mg.DeletePerson(personValue);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult DetailPerson(int id)
        {
            var personValue = mg.GetByID(id);
            return View(personValue);
        }

        [HttpGet]
        public IActionResult UpdatePerson(int id)
        {
            PersonModel model = new PersonModel();

            model.Person = mg.GetByID(id);
            model.SysUser = su.GetByID(id);
            model.PersonCard = pc.GetByID(id);

            List<SelectListItem> personTypes = (from x in pt.GetList()
                                                select new SelectListItem
                                                {
                                                    Text = x.Title,
                                                    Value = x.Id.ToString()
                                                }).ToList();
            ViewBag.pvt = personTypes;

            List<SelectListItem> sysCompanies = (from x in sc.GetList()
                                                select new SelectListItem
                                                {
                                                    Text = x.Title,
                                                    Value = x.Id.ToString()
                                                }).ToList();
            ViewBag.pvc = sysCompanies;

            List<SelectListItem> sysPositions = (from x in pm.GetList()
                                                 select new SelectListItem
                                                 {
                                                     Text = x.Title,
                                                     Value = x.Id.ToString()
                                                 }).ToList();
            ViewBag.pvp = sysPositions;

            return View(model);
        }

        [HttpPost]
        public IActionResult UpdatePerson(PersonModel model)
        {
            PersonValidator pv = new PersonValidator();
            ValidationResult results = pv.Validate(model);
            if (results.IsValid)
            {
                mm.UpdateModel(model);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }
    }
}