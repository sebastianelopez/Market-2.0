using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace TrabajoPractico4
{
    class MyContext : DbContext
    {
        public DbSet<User> users { get; set; }

        public DbSet<Cart> carts { get; set; }
        public DbSet<Product> Products { get; set; }

        public DbSet<Category> Categories { get; set; }        

        public DbSet<Purchase> Purchases { get; set; }
        public MyContext() { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(Properties.Resources.ConnectionString);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //table names
            modelBuilder.Entity<User>()
                .ToTable("Users")
                .HasKey(u => u.userId);


            modelBuilder.Entity<Product>(prod =>
            {
                prod.ToTable("Products");
            });

            modelBuilder.Entity<Category>(cat =>
            {
                cat.ToTable("Categories");
            });


            modelBuilder.Entity<Purchase>(compra =>
            {
                compra.ToTable("Purchases");
                compra.HasKey(c => c.id);
            });

            modelBuilder.Entity<Cart>(cart =>
            {
                cart.ToTable("Carro");
                cart.HasKey(c => c.id);
                cart.HasOne(c => c.usuario).WithOne(u => u.cart).HasForeignKey<Cart>(c => c.usuarioId);
            });

            //data properties
            modelBuilder.Entity<User>(
                usr =>
                {   
                    usr.Property(u => u.dni).HasColumnType("int");
                    usr.Property(u => u.dni).IsRequired(true);
                    usr.Property(u => u.name).HasColumnType("varchar(50)");
                    usr.Property(u => u.lastName).HasColumnType("varchar(50)");
                    usr.Property(u => u.email).HasColumnType("varchar(50)");
                    usr.Property(u => u.CUITCUIL).HasColumnType("int");
                    usr.Property(u => u.password).HasColumnType("varchar(50)");
                    usr.Property(u => u.userType).HasColumnType("varchar(50)");                    
                });
            

            modelBuilder.Entity<Product>(
                prod =>
                {
                    prod.Property(p => p.id).IsRequired(true);
                    prod.Property(p => p.id).HasColumnType("int");
                    prod.Property(p => p.name).IsRequired(true);
                    prod.Property(p => p.name).HasColumnType("varchar(50)");
                    prod.Property(p => p.price).IsRequired(true);
                    prod.Property(p => p.price).HasColumnType("float");
                    prod.Property(p => p.ammount).IsRequired(true);
                    prod.Property(p => p.ammount).HasColumnType("int");
                    prod.Property(p => p.description).IsRequired(true);
                    prod.Property(p => p.description).HasColumnType("varchar(250)");
                    prod.Property(p => p.category.id).IsRequired(true);
                    prod.Property(p => p.category.id).HasColumnType("int");
                });

            modelBuilder.Entity<Category>(
                cat =>
                {
                    cat.Property(c => c.id).IsRequired(true);
                    cat.Property(c => c.id).HasColumnType("int");
                    cat.Property(c => c.name).IsRequired(true);
                    cat.Property(c => c.name).HasColumnType("varchar(50)");                    
                });

            modelBuilder.Entity<Purchase>(
                prch =>
                {
                    prch.Property(p => p.id).IsRequired(true);
                    prch.Property(p => p.id).HasColumnType("int");
                    prch.Property(p => p.buyer.userId).IsRequired(true);
                    prch.Property(p => p.buyer.userId).HasColumnType("int");
                    prch.Property(p => p.products).IsRequired(true);
                    prch.Property(p => p.products).HasColumnType("int"); // aca no se que ponerle
                    prch.Property(p => p.total).IsRequired(true);
                    prch.Property(p => p.total).HasColumnType("float");
                });

            //DEFINICIÓN DE LA RELACIÓN MANY TO MANY Compra <-> Producto
            modelBuilder.Entity<Purchase>()
                .HasMany(P => P.products)
                .WithMany(P => P.Compras)
                .UsingEntity<PurchaseProducts>(
                    pp => pp.HasOne(cc => cc.producto).WithMany(p => p.Rel_Carro_Compras).HasForeignKey(pp => pp.productoId),
                    pp => pp.HasOne(cc => cc.compra).WithMany(c => c.Rel_Carro_Compras).HasForeignKey(pp => pp.compraId),
                    pp => pp.HasKey(k => new { k.compraId, k.productoId })
            );
                        



            //Ignoro, no agrego UsuarioManager a la base de datos
            modelBuilder.Ignore<Market>();
        }
    }
}
