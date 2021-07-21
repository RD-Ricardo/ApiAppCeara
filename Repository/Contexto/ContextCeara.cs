using Domain;
using Domain.Mapping;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace Repository.Contexto
{
    public class ContextCeara : DbContext
    {
        public ContextCeara(DbContextOptions<ContextCeara> options): base (options)
        {
            
        }
        public DbSet<GuardaSol> GuardaSols {get; set;}
        public DbSet<Categoria> Categorias { get; set;}
        public DbSet<Produto> Produtos { get; set;}
        public DbSet<Pedido> Pedidos {get; set;}
        public DbSet<Usuario> Usuarios {get; set;}
        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
               
               modelBuilder.Entity<Categoria>(entity =>
               {
                   entity.HasKey(e => e.Id);
                   entity.HasIndex(e => e.Id );   
                   entity.Property(e => e.Nome).HasColumnType("varchar(50)").IsRequired();   
               }
               );

               modelBuilder.Entity<GuardaSol>(entity => 
               {
                   entity.HasKey(i => i.Id);
                   entity.Property(n => n.Numero).IsRequired();
                   entity.Property(c => c.Cor).HasColumnType("varchar(50)");
                   entity.Property(d => d.Descricao).HasColumnType("varchar(100)");
                   entity.Property(v => v.Valor).HasColumnType("decimal(6,2)");  
               });

               modelBuilder.Entity<Pedido>(entity => 
               {
                   entity.HasKey(i => i.Id);
                   entity.Property(d => d.Hora).HasColumnType("datetime");
                   entity.Property(q => q.Quantidade).HasColumnType("int(3)");
                   entity.Property(q => q.Observacao).HasColumnType("varchar(100)");
                   entity.HasMany(c => c.Produtos);
                

               });

                modelBuilder.Entity<Usuario>(entity => 
               {
                   entity.HasKey(i => i.Id);
                   entity.Property(n => n.Nome).HasColumnType("varchar(50)");
                   entity.Property(s => s.Senha).HasColumnType("varchar(50)");
                   entity.Property(r => r.Role).HasColumnType("varchar(20)");
                
               });

                modelBuilder.Entity<Produto>(entity => 
               {
                   entity.HasKey(i => i.Id);
                   entity.Property(n => n.Nome).HasColumnType("varchar(50)");
                   entity.Property(p => p.Preco).HasColumnType("decimal(6,2)");
                   entity.Property(d => d.Descricao).HasColumnType("varchar(100)");
                   entity.HasMany(c => c.Pedidos);
               });
        
               

        }
    }
    
  
}