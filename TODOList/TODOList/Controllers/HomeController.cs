using System.Linq;
using System.Web.Mvc;
using TODOList.Models;

namespace TODOList.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            using (var db = new TaskDbContext())
            {
                var tasks = db.Task.ToList();
                return View(tasks);
            }
        }
    }
}