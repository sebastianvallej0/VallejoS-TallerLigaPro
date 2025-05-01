using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using VallejoS_TallerLigaPro.Models;

    public class DBSqlServer_VallejoS_TallerLigaPro : DbContext
    {
        public DBSqlServer_VallejoS_TallerLigaPro (DbContextOptions<DBSqlServer_VallejoS_TallerLigaPro> options)
            : base(options)
        {
        }

        public DbSet<VallejoS_TallerLigaPro.Models.Equipo> Equipo { get; set; } = default!;
    }
