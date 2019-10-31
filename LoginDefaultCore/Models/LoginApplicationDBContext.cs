using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoginDefaultCore.Models
{
    public class LoginApplicationDBContext : IdentityDbContext
    {
        public LoginApplicationDBContext(DbContextOptions<LoginApplicationDBContext> _options):base(_options)
        {
        }

        public DbSet<SettingsDataModel> Settings { get; set; }
    }
}
