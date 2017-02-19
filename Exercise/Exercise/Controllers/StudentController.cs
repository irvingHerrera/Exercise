using Exercise.Entities;
using Exercise.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Exercise.Models;
using System.Net;

namespace Exercise.Controllers
{
    public class StudentController : Controller
    {
        StudentB objStudent;

        public StudentController()
        {
            objStudent = new StudentB();
        }

        // GET: Student
        public ActionResult Index()
        {
            var lstStudent = objStudent.GetStudent();
            List<StudentView> lstView = new List<StudentView>();

            foreach (var item in lstStudent)
            {
                lstView.Add(
                        new StudentView
                        {
                            StudentId = item.StudentId,
                            FirstName = item.FirstName,
                            LastName = item.LastName,
                            EnrollmentDate = item.EnrollmentDate
                        }
                    );
            }

            return View(lstView);
        }

        // GET: Student/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var student = objStudent.GetDetails(id.Value);

            if (student == null)
            {
                return HttpNotFound();
            }

            var studentView = new StudentView
            {
                StudentId = student.StudentId,
                FirstName = student.FirstName,
                LastName = student.LastName,
                EnrollmentDate = student.EnrollmentDate
            };
            
            return View(studentView);
        }

        // GET: Student/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Student/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(StudentView studentView)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var student = new Student()
                    {
                        StudentId = studentView.StudentId,
                        FirstName = studentView.FirstName,
                        LastName = studentView.LastName,
                        EnrollmentDate = studentView.EnrollmentDate
                    };

                    if (objStudent.Create(student))
                    {
                        return RedirectToAction("Index");
                    }
                    else
                    {
                        ViewBag.Error = "Ocurrio un error al guardar el estudiante";
                        return View(studentView);
                    }
                }
                else
                {
                    return View(studentView);
                }

                
            }
            catch
            {
                return View();
            }
        }

        // GET: Student/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var student = objStudent.GetDetails(id.Value);

            if (student == null)
            {
                return HttpNotFound();
            }

            var studentView = new StudentView
            {
                StudentId = student.StudentId,
                FirstName = student.FirstName,
                LastName = student.LastName,
                EnrollmentDate = student.EnrollmentDate
            };

            return View(studentView);
        }

        // POST: Student/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, StudentView studentView)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var student = new Student
                    {
                        StudentId = studentView.StudentId,
                        FirstName = studentView.FirstName,
                        LastName = studentView.LastName,
                        EnrollmentDate = studentView.EnrollmentDate
                    };

                    if (objStudent.Edit(student))
                    {
                        return RedirectToAction("Index");
                    }
                    else
                    {
                        ViewBag.Error = "Ocurrio un error al guardar el estudiante";
                        return View(studentView);
                    }
                }
                else
                {
                    return View(studentView);
                }
            }
            catch
            {
                return View();
            }
        }

        // GET: Student/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var student = objStudent.GetDetails(id.Value);

            if (student == null)
            {
                return HttpNotFound();
            }

            var studentView = new StudentView
            {
                StudentId = student.StudentId,
                FirstName = student.FirstName,
                LastName = student.LastName,
                EnrollmentDate = student.EnrollmentDate
            };

            return View(studentView);
        }

        // POST: Student/Delete/5
        [HttpPost]
        public ActionResult Delete(int id)
        {
            try
            {
                objStudent.Delete(id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                objStudent.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
