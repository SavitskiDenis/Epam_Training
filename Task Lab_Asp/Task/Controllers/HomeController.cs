using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Task.Context;
using Task.Models;

namespace Task.Controllers
{
    public class HomeController : Controller
    {
        UsersContext db = new UsersContext();
        
        public ActionResult Index(string sortType="",int page=1)
        {
            int pageSize = 20;
            var _myList = from item in db.Users select item;
            ViewBag.SortType = sortType;
            switch(sortType)
            { 
                case "Last Name": _myList = _myList.OrderBy(item => item.LastName);break;
                case "Age": _myList = _myList.OrderBy(item => item.Age);break;
                default: _myList = _myList.OrderBy(item => item.Name); break;
            }
            IEnumerable<User> UsersPerPages = _myList.Skip((page - 1) * pageSize).Take(pageSize);
            Pages pageInfo = new Pages { PageNumber = page, PageSize = pageSize, TotalItems = db.Users.Count() };
            IndexViewModel ivm = new IndexViewModel { PageInfo = pageInfo, Users = UsersPerPages };
            return View(ivm);
        }

        [HttpGet]
        public ActionResult Insert()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Insert([Bind(Include = "Name,E_mail,LastName,Password,Re_Password,Age,Phone,Address,MiddleName")]User model)
        {
            if (ModelState.IsValid)
            {
                db.Users.Add(model);
                db.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            
            return View(model);
        }

        [HttpGet]
        public ActionResult Edit(int userId)
        {
            User model = db.Users.Where(user => user.Id == userId).FirstOrDefault();
            EditUser _userUp = new EditUser() { Id = model.Id, Name=model.Name,Phone=model.Phone,Address=model.Address,Age=model.Age,MiddleName=model.MiddleName,LastName=model.LastName};
            return View(_userUp);
        }

        [HttpPost]
        public ActionResult Edit(EditUser _userUp)
        {
            if(ModelState.IsValid)
            {
                User model = db.Users.Where(user => user.Id == _userUp.Id).FirstOrDefault();
                model.Name = _userUp.Name;
                model.MiddleName = _userUp.MiddleName;
                model.LastName = _userUp.LastName;
                model.Age = _userUp.Age;
                model.Phone = _userUp.Phone;
                model.Address = _userUp.Address;
                db.Entry(model).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            return View(_userUp);
        }

        [HttpGet]
        public ActionResult Delete (int userId)
        {
            User person = db.Users.Where(user=> user.Id == userId ).FirstOrDefault();
            db.Users.Remove(person);
            db.SaveChanges();
            return RedirectToAction("Index","Home");
        }

    }
}