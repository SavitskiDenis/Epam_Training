using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Task13.Models;

namespace Task13.Controllers
{
    public class VarsController : Controller
    {
        [HttpGet]
        public ActionResult ViewVar()
        {
            return View(InputVars(new Vars())); 
        }

        [HttpPost]
        public ActionResult ViewVar(Vars _myVars)
        {
            if (_myVars._rightResult == _myVars._userResult)
            {
                ViewBag.PreviousResult = "Правильный ответ";
            }
            else
            {
                ViewBag.PreviousResult = "Неверный ответ";
            }

            _myVars = InputVars(_myVars);

            return View(_myVars);
        }

        public Vars InputVars(Vars _myVars)
        {
            string[] _operators = new string []{ "*", "+", "-","/" };
            Random rnd = new Random();

            _myVars._firstNumber = rnd.Next(0,100);
            _myVars._secondNumber = rnd.Next(0, 100);
            _myVars._operator =  _operators[rnd.Next(0,4)];

            if(_myVars._operator == "*")
            {
                _myVars._rightResult = _myVars._firstNumber * _myVars._secondNumber;
            }
            else if(_myVars._operator == "+")
            {
                _myVars._rightResult = _myVars._firstNumber + _myVars._secondNumber;
            }
            else if (_myVars._operator == "-")
            {
                _myVars._rightResult = _myVars._firstNumber - _myVars._secondNumber;
            }
            else if(_myVars._operator == "/")
            {
                _myVars._rightResult = (double)_myVars._firstNumber / (double)_myVars._secondNumber;
            }

            return _myVars;
        }

        

	}
}