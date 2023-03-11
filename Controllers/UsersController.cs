using Microsoft.AspNetCore.Mvc;
using khadkaMVCApp.Models;

namespace khadkaMVCApp.Controllers
{
    public class UsersController : Controller
    {
        public IActionResult KVIEW()
        {
            UsersContext uc = new();
            return View(uc.KhadkaTables.ToList());
        }
    }
}
