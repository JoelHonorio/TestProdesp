#region Usings

using Microsoft.AspNetCore.Mvc;

#endregion

namespace Prodesp.Controllers
{
    public class HomeController : BaseController
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