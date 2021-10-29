using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AngelaStoreApp.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<AngelaStoreApp.Models.Contactanos> DataContactanos { get; set; }

        public DbSet<AngelaStoreApp.Models.Product> DataProduct {get; set;}

        public DbSet<AngelaStoreApp.Models.Proforma> DataProforma {get; set;}

        public DbSet<AngelaStoreApp.Models.Pago> DataPago {get; set;}

        public DbSet<AngelaStoreApp.Models.Pedido> DataPedido {get; set;}

        public DbSet<AngelaStoreApp.Models.DetallePedido> DataDetallePedido {get; set;}

    }
}
