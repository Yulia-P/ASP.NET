using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Lab04.Models;

namespace Lab04.Data
{
    public class DBContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx

        public DBContext() : base("name=DBContext")
        {
        }

        public DbSet<Lab04.Models.PhoneNote> PhoneNotes { get; set; }

        //internal object Entry(PhoneNote phoneNote)
        //{
        //    throw new NotImplementedException();
        //}
    }
}