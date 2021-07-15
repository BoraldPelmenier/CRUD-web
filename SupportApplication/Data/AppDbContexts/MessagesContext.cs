using Microsoft.EntityFrameworkCore;
using SupportApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SupportApplication.Data.AppDbContexts
{
    public class MessagesContext : DbContext
    {
        public MessagesContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Messages> Messages { get; set; }
    }
}
