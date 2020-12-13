using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace FarmPros.Controllers
{
    [Authorize]
    public class BaseController : Controller
    {
        protected string UserEmail
        {
            get { return User.FindFirstValue(ClaimTypes.Email);  }
        }
    }
}
