using EmployeeWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeeWeb.db
{
    public class StudentDBWeb:DbContext
    {
        public StudentDBWeb(DbContextOptions<StudentDBWeb> options) : base(options)
        {
        }
        public DbSet<Student> Student { get; set; }
    
}

}
