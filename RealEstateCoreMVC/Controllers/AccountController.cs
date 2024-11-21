using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using RealEstateCoreMVC.Models;
using RealEstateCoreMVC.Utilities;

namespace RealEstateCoreMVC.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
        public IActionResult Register()
        {
            List<SelectListItem> questionSet1 = new List<SelectListItem>();
            questionSet1.Add(new SelectListItem
            {
                Text = "What is your mother's maiden name?"
            });
            questionSet1.Add(new SelectListItem
            {
                Text = "What is the name of your first pet?"
            });
            questionSet1.Add(new SelectListItem
            {
                Text = "What was the name of the street you grew up on?"
            });

            List<SelectListItem> questionSet2 = new List<SelectListItem>();
            questionSet2.Add(new SelectListItem
            {
                Text = "What is your favorite color?"
            });
            questionSet2.Add(new SelectListItem
            {
                Text = "What was the name of your elementary school?"
            });
            questionSet2.Add(new SelectListItem
            {
                Text = "What is your father's middle name?"
            });

            List<SelectListItem> questionSet3 = new List<SelectListItem>();
            questionSet3.Add(new SelectListItem
            {
                Text = "In what city were you born?"
            });
            questionSet3.Add(new SelectListItem
            {
                Text = "What is the name of your childhood bestfriend?"
            });
            questionSet3.Add(new SelectListItem
            {
                Text = "What was your first car?"
            });

            ViewData["QuestionSet1"] = new SelectList(questionSet1);
            ViewData["QuestionSet2"] = new SelectList(questionSet2);
            ViewData["QuestionSet3"] = new SelectList(questionSet3);

            return View();
        }
        public IActionResult AccountRecovery()
        {
            return View();
        }
        public IActionResult TryLogin()
        {
            string username = Request.Form["txtUsername"].ToString();
            string password = Request.Form["txtPassword"].ToString();

            AccountDB accountDB = new AccountDB();

            if (accountDB.LoginAccount(username, password))
            {
                return RedirectToAction("HomePage", "Home");
            }
            else
            {
                ViewData["Message"] = "Account Not Found";
            }

            return View("Login");
        }
        public IActionResult AddAccount()
        {
            return View("Register");
        }
        
    }
}
