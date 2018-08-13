using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestFirstWebApp.Models;

namespace TestFirstWebApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();// return a view called : Index 
        }

        public ActionResult Mybootcamp()
        {
            return View();// will return a view called: Mybootcamp

        }

        public ActionResult JokeOfTheDay()
        {
            string[] Jokes = { "!false (It’s funny because it’s true.)" , "[“hip”,”hip”] (hip hip array!)", "//be nice to the CPU Thread_sleep(1); " };

            Random r = new Random();

            string Joke = Jokes[r.Next(Jokes.Length)];

            ViewBag.Joke = Joke; // save the Joke into the ViewBag

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            ViewBag.TodaysDate = DateTime.Now; 
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }


        public ActionResult SearchByName(string searchName)
        {
            // connect to a db and search for the name!
            string[] Names = { "James", "Paul", "Mary","Judy"};
            if (Names.Contains(searchName))
                ViewBag.Message = "Name Found!";
            else
                ViewBag.Message = "Not in the DB!";

            return View();

        }

        public ActionResult MyZodiac(DateTime searchZodiac)
        {
            ViewBag.Zodiac = GetHoroName(searchZodiac);
            return View();


        }

        private string GetHoroName(DateTime dt)
        {
            int month = dt.Month;
            int day = dt.Day;
            switch (month)
            {
                case 1:
                    if (day <= 19)
                        return "Capricorn";
                    else
                        return "Aquarius";

                case 2:
                    if (day <= 18)
                        return "Aquarius";
                    else
                        return "Pisces";
                case 3:
                    if (day <= 20)
                        return "Pisces";
                    else
                        return "Aries";
                case 4:
                    if (day <= 19)
                        return "Aries";
                    else
                        return "Taurus";
                case 5:
                    if (day <= 20)
                        return "Taurus";
                    else
                        return "Gemini";
                case 6:
                    if (day <= 20)
                        return "Gemini";
                    else
                        return "Cancer";
                case 7:
                    if (day <= 22)
                        return "Cancer";
                    else
                        return "Leo";
                case 8:
                    if (day <= 22)
                        return "Leo";
                    else
                        return "Virgo";
                case 9:
                    if (day <= 22)
                        return "Virgo";
                    else
                        return "Libra";
                case 10:
                    if (day <= 22)
                        return "Libra";
                    else
                        return "Scorpio";
                case 11:
                    if (day <= 21)
                        return "Scorpio";
                    else
                        return "Sagittarius";
                case 12:
                    if (day <= 21)
                        return "Sagittarius";
                    else
                        return "Capricorn";
            }
            return "";
        }

        public ActionResult AddNumbers()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Calculate(AddNumbersViewModel model)
        {
            
            return View(model);
        }
    }
}