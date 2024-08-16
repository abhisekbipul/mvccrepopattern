using RepositoryPatternMvc.Models;

namespace RepositoryPatternMvc.Repo
{
    public interface EmpRepo
    {
        void NewEmp(Emp e);
        List<Emp> GetAllEmps();

    }
}
