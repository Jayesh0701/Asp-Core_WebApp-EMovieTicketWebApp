using ETicketWebApp.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ETicketWebApp.Controllers
{
  public class ActorsController : Controller
  {
    private readonly AppDbContext _appDbContext;
    public ActorsController(AppDbContext appDbContext)
    {
      _appDbContext = appDbContext;
    }
  
    public IActionResult Index()
    {
      var data =_appDbContext.Actors.ToList();
      return View(data);
    }
  }
}
