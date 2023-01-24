using Microsoft.EntityFrameworkCore;

namespace PracticalTest.Models
{
    public class PracticalTextContext: DbContext
    {
        public PracticalTextContext(DbContextOptions<PracticalTextContext> options) :base(options) { }

        //DbSet<Employee> Employees
        //{
        //    get;
        //    set;
        //}

        //DbSet<Department> Departments
        //{
        //    get;
        //    set;
        //}

        DbSet<MathematicalOperations> MathematicalOperations
        {
            get;
            set;
        }       

    }
}
