using ProjetoDDD.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace ProjetoDDD.Infra.Data.EntityConfig {
    class ProdutoConfiguration : EntityTypeConfiguration<Produto> {
        public ProdutoConfiguration ( ) {
            HasKey(p => p.ProdutoId);

            Property(p => p.Nome)
                .IsRequired()
                .HasMaxLength(250);

            Property(p => p.Valor)
                .IsRequired();
            //Relacionamento com o banco(produto -> cliente)
            HasRequired(p => p.Cliente)
                .WithMany() // 1 cliente pode ter vários produtos
                .HasForeignKey(p => p.ClienteId);

            
        }
    }
}
