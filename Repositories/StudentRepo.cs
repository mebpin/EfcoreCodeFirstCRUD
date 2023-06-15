using EfcoreCodeFirstCRUD.Models;
namespace EfcoreCodeFirstCRUD.Repositories
{
    public class StudentRepo:IRepository<Student>
    {
        StudentDbContext _context;
        public StudentRepo(StudentDbContext context)
        {
            _context = context;
        }
        public void AddRecord(Student std)
        {
            _context.Students.Add(std);
            _context.SaveChanges();

        }
        public IEnumerable<Student> GetAllRecords()
        {
            IEnumerable<Student> studenList = _context.Students.ToList();
            return studenList;
        }
        public Student GetSingleRecord(int id)
        {
            Student std = _context.Students.Find(id);
            return std;
        }

        public Student UpdateRecord(Student std)
        {
            _context.Students.Update(std);
            _context.SaveChanges();
            return std;
        }
        public Student DeleteRecord(Student std)
        {
            _context.Students.Remove(std);
            _context.SaveChanges();
            return std;

        }
    }
}
