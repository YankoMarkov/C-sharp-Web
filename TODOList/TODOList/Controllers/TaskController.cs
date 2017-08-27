
using System.Web.Mvc;
using TODOList.Models;

namespace TODOList.Controllers
{
    public class TaskController : Controller
    {
        [HttpPost]
        public ActionResult Create(Task task)
        {
            if (task == null)
            {
                return RedirectToAction("Index", "Home");
            }
            using (var db = new TaskDbContext())
            {
                db.Task.Add(task);
                db.SaveChanges();
            }
            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index", "Home");
            }
            using (var db = new TaskDbContext())
            {
                var task = db.Task.Find(id);
                if (task == null)
                {
                    return RedirectToAction("Index", "Home");
                }
                db.Task.Remove(task);
                db.SaveChanges();
            }
            return RedirectToAction("Index", "Home");
        }
    }
}