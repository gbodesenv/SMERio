using Microsoft.AspNetCore.Mvc;

namespace Rj.SME.Sismonrio.WebCore.Controllers
{
    public class PartialController : Controller
    {
        public IActionResult AboutComponent() => PartialView();

        public IActionResult AppComponent() => PartialView();

        public IActionResult ContactComponent() => PartialView();

        public IActionResult IndexComponent() => PartialView();
    }
}