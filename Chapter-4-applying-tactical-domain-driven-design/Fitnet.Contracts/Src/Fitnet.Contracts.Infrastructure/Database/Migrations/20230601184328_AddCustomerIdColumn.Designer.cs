﻿// <auto-generated />
using System;
using EvolutionaryArchitecture.Fitnet.Contracts.Infrastructure.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace EvolutionaryArchitecture.Fitnet.Contracts.Data.Database.Migrations;

[DbContext(typeof(ContractsPersistence))]
[Migration("20230601184328_Add_Customer_Id_column")]
partial class AddCustomerIdColumn
{
    /// <inheritdoc />
    protected override void BuildTargetModel(ModelBuilder modelBuilder)
    {
#pragma warning disable 612, 618
        modelBuilder
            .HasDefaultSchema("Contracts")
            .HasAnnotation("ProductVersion", "7.0.0")
            .HasAnnotation("Relational:MaxIdentifierLength", 63);

        NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

        modelBuilder.Entity("EvolutionaryArchitecture.Fitnet.Contracts.Core.Contract", b =>
        {
            b.Property<Guid>("Id")
                .ValueGeneratedOnAdd()
                .HasColumnType("uuid");

            b.Property<Guid>("CustomerId")
                .HasColumnType("uuid");

            b.Property<DateTimeOffset>("PreparedAt")
                .HasColumnType("timestamp with time zone");

            b.Property<DateTimeOffset?>("SignedAt")
                .HasColumnType("timestamp with time zone");

            b.HasKey("Id");

            b.ToTable("Contracts", "Contracts");
        });
#pragma warning restore 612, 618
    }
}
