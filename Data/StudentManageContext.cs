using Microsoft.EntityFrameworkCore;
using StudentManage.Models;

namespace StudentManage.Data
{
    public class StudentManageContext : DbContext
    {
        public DbSet<StudentManage.Models.Student> Students { get; set; }

        public StudentManageContext(DbContextOptions<StudentManageContext> options) : base(options)
        {

        }
    }
}