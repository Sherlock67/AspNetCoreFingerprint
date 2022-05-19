using Microsoft.AspNetCore.Mvc;

namespace FingerPrint_WEB.Controllers
{
    public class FingerPrintCaptureController : Controller
    {
        public IActionResult AddFingerPrint()
        {
            return View();
        }
    }
}
