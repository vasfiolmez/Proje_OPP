using Microsoft.AspNetCore.Mvc;
using Proje_OPP.Entity;
using Proje_OPP.ProjectContext;
using System.Linq;

namespace Proje_OPP.Controllers
{
    public class CustomerController : Controller
    {
        Context context = new Context();
        public IActionResult Index()
        {
            var values = context.Customers.ToList();

            return View(values);
        }

        [HttpGet]
        public IActionResult AddCustomer()
        {

            return View();
        }

        [HttpPost]
        public IActionResult AddCustomer(Customer p)
        {
            context.Add(p);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult DeleteCustomer(int id) 
        {
         var value=context.Customers.Where(x=>x.Id==id).FirstOrDefault();
            context.Remove(value);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateCustomer(int id) 
        {
            var value = context.Customers.Where(x => x.Id == id).FirstOrDefault();
            return View(value);
        }
        [HttpPost]
        public IActionResult UpdateCustomer(Customer p) 
        {
            var value=context.Customers.Where(x=>x.Id==p.Id).FirstOrDefault();
            value.Name = p.Name;
            value.City = p.City;
            context.SaveChanges();
        return RedirectToAction("Index");
        }
    }
}
