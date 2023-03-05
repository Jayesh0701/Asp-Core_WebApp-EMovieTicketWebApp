using ETicketWebApp.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ETicketWebApp.Controllers
{
  public class MoviesController : Controller
  {
    private readonly AppDbContext _appDbContext;
    public MoviesController(AppDbContext appDbContext)
    {
      _appDbContext = appDbContext;
    }

    public async Task<IActionResult> Index()
    {
      var allMovies = await _appDbContext.Movies.Include(n=>n.Cinema).ToListAsync();
      return View(allMovies);
    }
  }
}
