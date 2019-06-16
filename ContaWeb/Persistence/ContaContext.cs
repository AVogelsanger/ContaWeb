using ContaWeb.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ContaWeb.Persistence
{
    public class ContaContext : DbContext
    {

        public ContaContext() : base("ContaContext")
        {
                            
        }

        public DbSet<ContaCorrente> Contas { get; set; }
    }
}