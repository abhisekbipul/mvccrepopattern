using RepositoryPatternMvc.Data;
using RepositoryPatternMvc.Models;

namespace RepositoryPatternMvc.Repo
{
    public class EmpService : EmpRepo
    {
        private readonly ApplicationDbContext db;
        public EmpService(ApplicationDbContext db) 
        {
            this.db = db;
        }

        public List<Emp> GetAllEmps()
        {
            var data=db.emps.ToList();
            return data;
        }

        public void NewEmp(Emp e)
        {
            db.emps.Add(e);
            db.SaveChanges();
        }
    }
}
