// <auto-generated />
using System;
using Elsa.Persistence.EntityFrameworkCore.DbContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Oracle.EntityFrameworkCore.Metadata;

namespace Elsa.Persistence.EntityFrameworkCore.Migrations.Oracle
{
    [DbContext(typeof(OracleContext))]
    partial class OracleContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("Elsa.Persistence.EntityFrameworkCore.Entities.ActivityDefinitionEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)")
                        .UseIdentityColumn()
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("ActivityId")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("Description")
                        .HasColumnType("NCLOB");

                    b.Property<string>("DisplayName")
                        .HasColumnType("NCLOB");

                    b.Property<int>("Left")
                        .HasColumnType("NUMBER(10)");

                    b.Property<string>("Name")
                        .HasColumnType("NCLOB");

                    b.Property<string>("State")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<int>("Top")
                        .HasColumnType("NUMBER(10)");

                    b.Property<string>("Type")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<int?>("WorkflowDefinitionVersionId")
                        .HasColumnType("NUMBER(10)");

                    b.HasKey("Id");

                    b.HasIndex("WorkflowDefinitionVersionId");

                    b.ToTable("ActivityDefinitions");
                });

            modelBuilder.Entity("Elsa.Persistence.EntityFrameworkCore.Entities.ActivityInstanceEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)")
                        .UseIdentityColumn()
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("ActivityId")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("Output")
                        .HasColumnType("NCLOB");

                    b.Property<string>("State")
                        .HasColumnType("NCLOB");

                    b.Property<string>("Type")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<int?>("WorkflowInstanceId")
                        .HasColumnType("NUMBER(10)");

                    b.HasKey("Id");

                    b.HasIndex("WorkflowInstanceId");

                    b.ToTable("ActivityInstances");
                });

            modelBuilder.Entity("Elsa.Persistence.EntityFrameworkCore.Entities.BlockingActivityEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)")
                        .UseIdentityColumn();

                    b.Property<string>("ActivityId")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("ActivityType")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<int?>("WorkflowInstanceId")
                        .HasColumnType("NUMBER(10)");

                    b.HasKey("Id");

                    b.HasIndex("WorkflowInstanceId");

                    b.ToTable("BlockingActivities");
                });

            modelBuilder.Entity("Elsa.Persistence.EntityFrameworkCore.Entities.ConnectionDefinitionEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)")
                        .UseIdentityColumn();

                    b.Property<string>("DestinationActivityId")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("Outcome")
                        .HasColumnType("NCLOB");

                    b.Property<string>("SourceActivityId")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<int?>("WorkflowDefinitionVersionId")
                        .HasColumnType("NUMBER(10)");

                    b.HasKey("Id");

                    b.HasIndex("WorkflowDefinitionVersionId");

                    b.ToTable("ConnectionDefinitions");
                });

            modelBuilder.Entity("Elsa.Persistence.EntityFrameworkCore.Entities.WorkflowDefinitionVersionEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)")
                        .UseIdentityColumn()
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("DefinitionId")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("Description")
                        .HasColumnType("NCLOB");

                    b.Property<bool>("IsDisabled")
                        .HasColumnType("NUMBER(1)");

                    b.Property<bool>("IsLatest")
                        .HasColumnType("NUMBER(1)");

                    b.Property<bool>("IsPublished")
                        .HasColumnType("NUMBER(1)");

                    b.Property<bool>("IsSingleton")
                        .HasColumnType("NUMBER(1)");

                    b.Property<string>("Name")
                        .HasColumnType("NCLOB");

                    b.Property<string>("Variables")
                        .HasColumnType("NCLOB");

                    b.Property<int>("Version")
                        .HasColumnType("NUMBER(10)");

                    b.Property<string>("VersionId")
                        .HasColumnType("NCLOB");

                    b.HasKey("Id");

                    b.ToTable("WorkflowDefinitionVersions");
                });

            modelBuilder.Entity("Elsa.Persistence.EntityFrameworkCore.Entities.WorkflowInstanceEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)")
                        .UseIdentityColumn()
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime?>("AbortedAt")
                        .HasColumnType("TIMESTAMP(7)");

                    b.Property<string>("CorrelationId")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TIMESTAMP(7)");

                    b.Property<string>("DefinitionId")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("ExecutionLog")
                        .HasColumnType("NCLOB");

                    b.Property<string>("Fault")
                        .HasColumnType("NCLOB");

                    b.Property<DateTime?>("FaultedAt")
                        .HasColumnType("TIMESTAMP(7)");

                    b.Property<DateTime?>("FinishedAt")
                        .HasColumnType("TIMESTAMP(7)");

                    b.Property<string>("Input")
                        .HasColumnType("NCLOB");

                    b.Property<string>("InstanceId")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("Scope")
                        .HasColumnType("NCLOB");

                    b.Property<DateTime?>("StartedAt")
                        .HasColumnType("TIMESTAMP(7)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<int>("Version")
                        .HasColumnType("NUMBER(10)");

                    b.HasKey("Id");

                    b.ToTable("WorkflowInstances");
                });

            modelBuilder.Entity("Elsa.Persistence.EntityFrameworkCore.Entities.ActivityDefinitionEntity", b =>
                {
                    b.HasOne("Elsa.Persistence.EntityFrameworkCore.Entities.WorkflowDefinitionVersionEntity", "WorkflowDefinitionVersion")
                        .WithMany("Activities")
                        .HasForeignKey("WorkflowDefinitionVersionId");

                    b.Navigation("WorkflowDefinitionVersion");
                });

            modelBuilder.Entity("Elsa.Persistence.EntityFrameworkCore.Entities.ActivityInstanceEntity", b =>
                {
                    b.HasOne("Elsa.Persistence.EntityFrameworkCore.Entities.WorkflowInstanceEntity", "WorkflowInstance")
                        .WithMany("Activities")
                        .HasForeignKey("WorkflowInstanceId");

                    b.Navigation("WorkflowInstance");
                });

            modelBuilder.Entity("Elsa.Persistence.EntityFrameworkCore.Entities.BlockingActivityEntity", b =>
                {
                    b.HasOne("Elsa.Persistence.EntityFrameworkCore.Entities.WorkflowInstanceEntity", "WorkflowInstance")
                        .WithMany("BlockingActivities")
                        .HasForeignKey("WorkflowInstanceId");

                    b.Navigation("WorkflowInstance");
                });

            modelBuilder.Entity("Elsa.Persistence.EntityFrameworkCore.Entities.ConnectionDefinitionEntity", b =>
                {
                    b.HasOne("Elsa.Persistence.EntityFrameworkCore.Entities.WorkflowDefinitionVersionEntity", "WorkflowDefinitionVersion")
                        .WithMany("Connections")
                        .HasForeignKey("WorkflowDefinitionVersionId");

                    b.Navigation("WorkflowDefinitionVersion");
                });

            modelBuilder.Entity("Elsa.Persistence.EntityFrameworkCore.Entities.WorkflowDefinitionVersionEntity", b =>
                {
                    b.Navigation("Activities");

                    b.Navigation("Connections");
                });

            modelBuilder.Entity("Elsa.Persistence.EntityFrameworkCore.Entities.WorkflowInstanceEntity", b =>
                {
                    b.Navigation("Activities");

                    b.Navigation("BlockingActivities");
                });
#pragma warning restore 612, 618
        }
    }
}
