using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace architectureKorayApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectController : ControllerBase
    {
        ProjectManager projectManager = new ProjectManager(new EfProjectRepository());

        [HttpPost("AddProject")]
        public IActionResult Add(Project project)
        {
            project.CreatedDateTime = DateTime.Now;
            project.IsDeleted = false;
            projectManager.TAdd(project);

            return Ok(project);
        }

        [HttpGet]
        public IActionResult Get(int id)
        {
            var values = projectManager.GetProjectWithImages(id);
            return Ok(values);
        }
    }
}
