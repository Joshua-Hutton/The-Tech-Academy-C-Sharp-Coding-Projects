using FinalExercise.Models;
using FinalExercise.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FinalExercise.Controllers
{ 
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            return View();
        }

       public ActionResult Materials()
        {
            return View();
        }

        public ActionResult Products()
        {
            using (ApplicationDbContext db = new ApplicationDbContext())
            {
                int hack = db.hackySacks.Select(q => q.Quantity).Sum();
                var LgBag = db.diceBags.Where(s => s.Size.ToLower() == "lg").Select(q => q.Quantity).Sum();
                var SmBag = db.diceBags.Where(s => s.Size.ToLower() == "sm").Select(q => q.Quantity).Sum();
                var cosplay = db.tops.Where(t => t.Type.ToLower() == "cosplay").Select(q => q.Quantity).Sum();
                var heart = db.tops.Where(t => t.Type.ToLower() == "heart").Select(q => q.Quantity).Sum();
                var Diamond = db.tops.Where(t => t.Type.ToLower() == "double diamond").Select(q => q.Quantity).Sum();

                var dict = new Dictionary<string, int>();

                dict.Add("Hackysack", hack);
                dict.Add("Lg Dice Bag", LgBag);
                dict.Add("Sm Dice Bag", SmBag);
                dict.Add("Cosplay Top", cosplay);
                dict.Add("Heart Shaped Top", heart);
                dict.Add("Double Diamond Top", Diamond);

                var vm = new ViewModel();
                vm.Table = dict;

                return View(vm);
            }

                
        }


    }
}