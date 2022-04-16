using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CRUD_Mahasiswa_FIX.Models
{
    [Table("datamhs", Schema = "public")]
    public class Datamhs
    {
        [Key]
        public int mhs_id { get; set; }
        public string mhs_nama { get; set; }
        public string mhs_prodi { get; set; }
        public int mhs_nohp { get; set; }
    }
}