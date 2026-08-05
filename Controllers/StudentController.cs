using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentCRUDOpretions_API.Implementations;
using StudentCRUDOpretions_API.Interface;
using StudentCRUDOpretions_API.Models;

namespace StudentCRUDOpretions_API.Controllers
{
    //[Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {

        _360navigatorFrontRangeLiveV5TraineeContext db;
         IStudentInterface  studentService;
        public StudentController(_360navigatorFrontRangeLiveV5TraineeContext db, IStudentInterface studentService)
        {
            this.db = db;
            this.studentService= studentService;
        }

        [Route("api/getstudents")]
        [HttpGet]
        public List<TblstudentsDatum> GetStudents()
        {
            
            return studentService.GetStudents();
		}


        [Route("api/addstudents")]
        [HttpPost]
        public void Addstudents(TblstudentsDatum s)
        {
             studentService.AddStudent(s);
        }

        [Route("api/getstudentbyid/{id}")]
        [HttpGet]
        public TblstudentsDatum getstudentidwise(int id)
        {
            return studentService.GetStudentById(id);
        }
        [Route("api/updateStudent")]
        [HttpPut]
        public void UpdateStudent(TblstudentsDatum s)
        {
            studentService.UpdateStudent(s);
        }

        [Route("api/deletestudent/{id}")]
        [HttpDelete]
        public void deletestudent(int id)
        {
            studentService.DeleteStudent(id);
        }

	}
}
