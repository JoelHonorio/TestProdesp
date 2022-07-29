#region Using

using Microsoft.AspNetCore.Mvc;

#endregion

namespace Prodesp.Controllers
{
    public class HomeController : Controller
    {
        #region Injeção de dependências

        public HomeController()
        {

        }

        #endregion

        public IActionResult Index()
        {
            return View();
        }
    }
}