using MadLibs.Models;
using Microsoft.AspNetCore.Mvc;

namespace MadLibs.Controllers
{
  public class ClassNameController : Controller
  {
    [HttpGet("/route")]
    public ActionResult MethodName()
    {
      return View();
    }
  }
}