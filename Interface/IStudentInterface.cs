using StudentCRUDOpretions_API.Models;

namespace StudentCRUDOpretions_API.Interface
{
    public interface IStudentInterface
    {
        void AddStudent( TblstudentsDatum s);
        public List<TblstudentsDatum> GetStudents();
        TblstudentsDatum GetStudentById(int id);
        void UpdateStudent(TblstudentsDatum s);
        void DeleteStudent(int id);
    }
}
