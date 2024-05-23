using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Entities
{
    public class RepositoryContext : DbContext
    {
        protected readonly IConfiguration _configuration;

        public RepositoryContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public virtual DbSet<Weather> Weathers { get;set;}

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            //connect to sql server with connection string from app settings
            options.UseSqlite("Data Source=C:\\Users\\faeiz\\OneDrive\\Desktop\\databasesqlite\\qsolvedb.db");
        }
    }
}
