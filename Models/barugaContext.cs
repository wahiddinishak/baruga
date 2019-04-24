using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace barugaWeb.Models
{
    public partial class barugaContext : DbContext
    {
        public barugaContext() { }

        public barugaContext(DbContextOptions<barugaContext> options) : base(options)
        {

        }
        
        //data_master
        public virtual DbSet<msTopicsHeader> msTopicsHeaders { get; set; }
        public virtual DbSet<msTopicsDetail> msTopicsDetails { get; set; }        
        public virtual DbSet<msUsersPelapor> msUsersPelapors { get; set; }
        public virtual DbSet<msOPDProv> msOPDProvs { get; set; }
        public virtual DbSet<msKabKot> msKabKots { get; set; }
        public virtual DbSet<msKec> msKecs { get; set; }
        public virtual DbSet<msOPDKabKot> msOPDKabKots { get; set; }    

        //data_transact
        public virtual DbSet<trComplaintLv1> trComplaintLv1s { get; set; }
        public virtual DbSet<trComplaintLv2> trComplaintLv2s { get; set; }
        public virtual DbSet<trComplaintLv3> trComplaintLv3s { get; set; }
        public virtual DbSet<trComplaintPicture> trComplaintPictures { get; set; }
        public virtual DbSet<trLilke> trLilkes { get; set; }
        public virtual DbSet<trComplaintResponse> trComplaintResponses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySQL(Startup.ConnentionString);
            }
        }
    }
}
