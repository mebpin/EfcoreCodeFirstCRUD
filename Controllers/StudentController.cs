using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using EfcoreCodeFirstCRUD.Models;
using EfcoreCodeFirstCRUD.Repositories;

namespace EfcoreCodeFirstCRUD.Controllers
{
    public class StudentController : Controller
    {

        IRepository<Student> _repo = null;
        public StudentController(IRepository<Student> repo)
        {
            _repo = repo;
        }

        // GET: StudentController
        public ActionResult Index()
        {
            IEnumerable<Student> studentList = _repo.GetAllRecords();
            return View(studentList);
        }

        // GET: StudentController/Details/5
        public ActionResult Details(int id)
        {
            Student std = _repo.GetSingleRecord(id);
            return View(std);
        }

        // GET: StudentController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: StudentController/Create
        [HttpPost]
        
        public ActionResult Create(Student s)
        {
            _repo.AddRecord(s);
            TempData["success_on_create"] = $"A record with id {s.Id} is Added Successfully!";
            return RedirectToAction("Index");
        }

        // GET: StudentController/Edit/5
        [HttpGet]
        public ActionResult Edit(int id)
        {
            Student std = _repo.GetSingleRecord(id);
            return View(std);
        }

        // POST: StudentController/Edit/5
        [HttpPost]
  
        public ActionResult Edit(Student s)
        {
            _repo.UpdateRecord(s);
            TempData["success_on_edit"] = $"Record with Id {s.Id} is updated Successfully!";
            return RedirectToAction("Index");
        }

        // GET: StudentController/Delete/5
        public ActionResult Delete(int id)
        {
            Student std = _repo.GetSingleRecord(id);
            return View(std);
        }

        // POST: StudentController/Delete/5
        [HttpPost]
        
        public ActionResult Delete(Student s)
        {
            _repo.DeleteRecord(s);
            TempData["success_on_delete"] = $"Record with Id {s.Id} is deleted Successfully!";
            return RedirectToAction("Index");
        }
    }
}
