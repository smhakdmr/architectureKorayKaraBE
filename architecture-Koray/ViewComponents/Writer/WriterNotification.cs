using Microsoft.AspNetCore.Mvc;

namespace architecture_Koray.ViewComponents.Writer
{
    public class WriterNotification : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
