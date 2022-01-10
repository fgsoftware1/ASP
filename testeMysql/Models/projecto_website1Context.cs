﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace testeMysql.Models
{
    public partial class projecto_website1Context : DbContext
    {
        public projecto_website1Context()
        {
        }

        public projecto_website1Context(DbContextOptions<projecto_website1Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Sumario> Sumarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseMySql("server=localhost;port=3306;user=root;database=projecto_website1", Microsoft.EntityFrameworkCore.ServerVersion.Parse("10.4.21-mariadb"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            modelBuilder.Entity<Sumario>(entity =>
            {
                entity.HasKey(e => e.IdSumario)
                    .HasName("PRIMARY");

                entity.ToTable("sumarios");

                entity.Property(e => e.IdSumario)
                    .HasColumnType("int(3)")
                    .HasColumnName("ID_Sumario");

                entity.Property(e => e.AlunosPresented)
                    .HasColumnType("int(2)")
                    .HasColumnName("Alunos_Presented");

                entity.Property(e => e.Disciplina)
                    .IsRequired()
                    .HasMaxLength(75);

                entity.Property(e => e.Sumario1)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasColumnName("Sumario");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}