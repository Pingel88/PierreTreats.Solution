using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using PierreTreats.Models;

namespace PierreTreats.Controllers
{
  public class HomeController : Controller
  {
    private readonly PierreTreatsContext _db;

    public HomeController(PierreTreatsContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Treat> model = _db.Treats.ToList();
      return View(model);
    }
  }
}