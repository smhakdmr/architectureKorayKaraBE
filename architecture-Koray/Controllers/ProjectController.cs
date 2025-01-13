using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace architecture_Koray.Controllers
{
    public class ProjectController : Controller
    {
        ProjectManager pm = new ProjectManager(new EfProjectRepository());
        public IActionResult Index()
        {
            //var values = pm.GetProjectWithImages();
            return View();
        }

        public IActionResult GetById(int id)
        {
            ViewBag.i = id;
            var values = pm.GetById(id);
            return View(values);
        }
    }
}
