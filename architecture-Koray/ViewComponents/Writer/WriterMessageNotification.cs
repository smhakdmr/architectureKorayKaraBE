using Microsoft.AspNetCore.Mvc;

namespace architecture_Koray.ViewComponents.Writer
{
    public class WriterMessageNotification : ViewComponent
    {

        public IViewComponentResult Invoke()
        { 
            return View();
        }
    }

}
