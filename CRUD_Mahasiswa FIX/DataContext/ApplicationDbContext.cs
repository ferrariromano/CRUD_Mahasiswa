using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using CRUD_Mahasiswa_FIX.Models;

namespace CRUD_Mahasiswa_FIX.DataContext
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext():base(nameOrConnectionString:"koneksiku")
        {

        }
        public virtual DbSet<Datamhs> datamhsObj { get; set; }

    }

}