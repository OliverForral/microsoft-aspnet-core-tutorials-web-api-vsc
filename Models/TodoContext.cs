using Microsoft.EntityFrameworkCore;

namespace microsoft_aspnet_core_tutorials_web_api_vsc.Models
{
    public class TodoContext : DbContext
    {
        public TodoContext(DbContextOptions<TodoContext> options)
            : base(options)
        {
        }

        public DbSet<TodoItem> TodoItems { get; set; }

    }
}