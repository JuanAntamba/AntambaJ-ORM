using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AntambaJ_ORM.Models;

    public class SQLServerContext : DbContext
    {
        public SQLServerContext (DbContextOptions<SQLServerContext> options)
            : base(options)
        {
        }

        public DbSet<AntambaJ_ORM.Models.Facultad> Facultad { get; set; } = default!;

public DbSet<AntambaJ_ORM.Models.Carrera> Carrera { get; set; } = default!;

public DbSet<AntambaJ_ORM.Models.Estudiante> Estudiante { get; set; } = default!;
    }
