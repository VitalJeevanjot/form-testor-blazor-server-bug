using Microsoft.EntityFrameworkCore;
using form_testor_blazor_server.Data.Models;

namespace form_testor_blazor_server.Data
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options) 
        {
        }

        public DbSet<UserProjectModel> UserProjects { get; set; }


    }
}
