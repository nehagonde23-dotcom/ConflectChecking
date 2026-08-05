using StudentCRUDOpretions_API.Interface;
using StudentCRUDOpretions_API.Models;

namespace StudentCRUDOpretions_API.Implementations
{
    public class StudentService : IStudentInterface
    {
        _360navigatorFrontRangeLiveV5TraineeContext db;
        public StudentService(_360navigatorFrontRangeLiveV5TraineeContext db)
        {
            this.db = db;
        }

        public void AddStudent(TblstudentsDatum s)
        {
           db.TblstudentsData.Add(s);
            db.SaveChanges();

        }

        public void DeleteStudent(int id)
        {
            var student=db.TblstudentsData.Find(id);
            db.TblstudentsData.Remove(student);
            db.SaveChanges();
        }

        public TblstudentsDatum GetStudentById(int id)
        {
		
			return db.TblstudentsData.Find(id);
		}
        

        public List<TblstudentsDatum> GetStudents()
        {
          return db.TblstudentsData.ToList();
        }

        public void UpdateStudent(TblstudentsDatum s)
        {

            db.TblstudentsData.Update(s);
			db.SaveChanges();
		}
	}
    }

