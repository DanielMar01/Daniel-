using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebProductosCore.Models;

namespace WebProductosCore.Data
{
    public class WebProductosCoreContext : DbContext
    {
        public WebProductosCoreContext (DbContextOptions<WebProductosCoreContext> options)
            : base(options)
        {
        }

        public DbSet<WebProductosCore.Models.Producto> Producto { get; set; } = default!;
    }
}
