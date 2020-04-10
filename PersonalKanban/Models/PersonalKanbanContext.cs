using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalKanban.Models
{
    public class PersonalKanbanContext : DbContext
    {
        public PersonalKanbanContext(DbContextOptions<PersonalKanbanContext> options)
            : base(options)
        {
        }

        public DbSet<Task> Tasks { get; set; }
    }
}
