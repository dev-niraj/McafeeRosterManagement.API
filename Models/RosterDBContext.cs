using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace McafeeRosterManagement.API.Models
{
    public partial class RosterDBContext : DbContext
    {
        public RosterDBContext()
        {
        }

        public RosterDBContext(DbContextOptions<RosterDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Aschedule> Aschedule { get; set; }
        public virtual DbSet<Businessunit> Businessunit { get; set; }
        public virtual DbSet<CHoliday> CHoliday { get; set; }
        public virtual DbSet<Oncall> Oncall { get; set; }
        public virtual DbSet<Outofoffice> Outofoffice { get; set; }
        public virtual DbSet<Schedule> Schedule { get; set; }
        public virtual DbSet<Shift> Shift { get; set; }
        public virtual DbSet<Swap> Swap { get; set; }
        public virtual DbSet<Team> Team { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<UsersHistory> UsersHistory { get; set; }
        public virtual DbSet<WeekOff> WeekOff { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity<Aschedule>(entity =>
            {
                entity.HasKey(e => e.SlNo)
                    .HasName("aschedule_pkey");

                entity.ToTable("aschedule");

                entity.Property(e => e.SlNo).HasColumnName("sl_no");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasMaxLength(50);

                entity.Property(e => e.ModifiedAt).HasColumnName("modified_at");

                entity.Property(e => e.ModifiedBy)
                    .HasColumnName("modified_by")
                    .HasMaxLength(50);

                entity.Property(e => e.SId)
                    .HasColumnName("s_id")
                    .HasMaxLength(5);

                entity.Property(e => e.ShId).HasColumnName("sh_id");

                entity.Property(e => e.WoId).HasColumnName("wo_id");

                entity.Property(e => e.Wwid).HasColumnName("wwid");

                entity.HasOne(d => d.S)
                    .WithMany(p => p.Aschedule)
                    .HasForeignKey(d => d.SId)
                    .HasConstraintName("aschedule_s_id_fkey");

                entity.HasOne(d => d.Sh)
                    .WithMany(p => p.Aschedule)
                    .HasForeignKey(d => d.ShId)
                    .HasConstraintName("aschedule_sh_id_fkey");

                entity.HasOne(d => d.Wo)
                    .WithMany(p => p.Aschedule)
                    .HasForeignKey(d => d.WoId)
                    .HasConstraintName("aschedule_wo_id_fkey");

                entity.HasOne(d => d.Ww)
                    .WithMany(p => p.Aschedule)
                    .HasForeignKey(d => d.Wwid)
                    .HasConstraintName("aschedule_wwid_fkey");
            });

            modelBuilder.Entity<Businessunit>(entity =>
            {
                entity.HasKey(e => e.BuId)
                    .HasName("businessunit_pkey");

                entity.ToTable("businessunit");

                entity.Property(e => e.BuId)
                    .HasColumnName("bu_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.BuDescription).HasColumnName("bu_description");

                entity.Property(e => e.BuName)
                    .HasColumnName("bu_name")
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasMaxLength(50);

                entity.Property(e => e.ModifiedAt).HasColumnName("modified_at");

                entity.Property(e => e.ModifiedBy)
                    .HasColumnName("modified_by")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<CHoliday>(entity =>
            {
                entity.HasKey(e => e.HId)
                    .HasName("c_holiday_pkey");

                entity.ToTable("c_holiday");

                entity.Property(e => e.HId).HasColumnName("h_id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasMaxLength(50);

                entity.Property(e => e.HDate)
                    .HasColumnName("h_date")
                    .HasColumnType("date");

                entity.Property(e => e.HName)
                    .HasColumnName("h_name")
                    .HasMaxLength(50);

                entity.Property(e => e.ModifiedAt).HasColumnName("modified_at");

                entity.Property(e => e.ModifiedBy)
                    .HasColumnName("modified_by")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Oncall>(entity =>
            {
                entity.HasKey(e => e.SlNo)
                    .HasName("oncall_pkey");

                entity.ToTable("oncall");

                entity.Property(e => e.SlNo).HasColumnName("sl_no");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasMaxLength(50);

                entity.Property(e => e.ModifiedAt).HasColumnName("modified_at");

                entity.Property(e => e.ModifiedBy)
                    .HasColumnName("modified_by")
                    .HasMaxLength(50);

                entity.Property(e => e.OnDate)
                    .HasColumnName("on_date")
                    .HasColumnType("date");

                entity.Property(e => e.TId).HasColumnName("t_id");

                entity.Property(e => e.Wwid).HasColumnName("wwid");

                entity.HasOne(d => d.T)
                    .WithMany(p => p.Oncall)
                    .HasForeignKey(d => d.TId)
                    .HasConstraintName("oncall_t_id_fkey");

                entity.HasOne(d => d.Ww)
                    .WithMany(p => p.Oncall)
                    .HasForeignKey(d => d.Wwid)
                    .HasConstraintName("oncall_wwid_fkey");
            });

            modelBuilder.Entity<Outofoffice>(entity =>
            {
                entity.HasKey(e => e.SlNo)
                    .HasName("outofoffice_pkey");

                entity.ToTable("outofoffice");

                entity.Property(e => e.SlNo).HasColumnName("sl_no");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasMaxLength(50);

                entity.Property(e => e.ModifiedAt).HasColumnName("modified_at");

                entity.Property(e => e.ModifiedBy)
                    .HasColumnName("modified_by")
                    .HasMaxLength(50);

                entity.Property(e => e.Odate)
                    .HasColumnName("odate")
                    .HasColumnType("date");

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasMaxLength(200);

                entity.Property(e => e.Wwid).HasColumnName("wwid");

                entity.HasOne(d => d.Ww)
                    .WithMany(p => p.Outofoffice)
                    .HasForeignKey(d => d.Wwid)
                    .HasConstraintName("outofoffice_wwid_fkey");
            });

            modelBuilder.Entity<Schedule>(entity =>
            {
                entity.HasKey(e => e.ShId)
                    .HasName("schedule_pkey");

                entity.ToTable("schedule");

                entity.Property(e => e.ShId).HasColumnName("sh_id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasMaxLength(50);

                entity.Property(e => e.EndDate)
                    .HasColumnName("end_date")
                    .HasColumnType("date");

                entity.Property(e => e.ModifiedAt).HasColumnName("modified_at");

                entity.Property(e => e.ModifiedBy)
                    .HasColumnName("modified_by")
                    .HasMaxLength(50);

                entity.Property(e => e.SchType)
                    .HasColumnName("sch_type")
                    .HasMaxLength(20);

                entity.Property(e => e.StartDate)
                    .HasColumnName("start_date")
                    .HasColumnType("date");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasMaxLength(10);

                entity.Property(e => e.TId).HasColumnName("t_id");

                entity.HasOne(d => d.T)
                    .WithMany(p => p.Schedule)
                    .HasForeignKey(d => d.TId)
                    .HasConstraintName("schedule_t_id_fkey");
            });

            modelBuilder.Entity<Shift>(entity =>
            {
                entity.HasKey(e => e.SId)
                    .HasName("shift_pkey");

                entity.ToTable("shift");

                entity.Property(e => e.SId)
                    .HasColumnName("s_id")
                    .HasMaxLength(5)
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasMaxLength(50);

                entity.Property(e => e.EndTime)
                    .HasColumnName("end_time")
                    .HasColumnType("time without time zone");

                entity.Property(e => e.ModifiedAt).HasColumnName("modified_at");

                entity.Property(e => e.ModifiedBy)
                    .HasColumnName("modified_by")
                    .HasMaxLength(50);

                entity.Property(e => e.StartTime)
                    .HasColumnName("start_time")
                    .HasColumnType("time without time zone");
            });

            modelBuilder.Entity<Swap>(entity =>
            {
                entity.HasKey(e => e.SlNo)
                    .HasName("swap_pkey");

                entity.ToTable("swap");

                entity.Property(e => e.SlNo).HasColumnName("sl_no");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasMaxLength(50)
                    .HasDefaultValueSql("'Pending'::character varying");

                entity.Property(e => e.FromDate)
                    .HasColumnName("from_date")
                    .HasColumnType("date");

                entity.Property(e => e.FromWwid).HasColumnName("from_wwid");

                entity.Property(e => e.ModifiedAt).HasColumnName("modified_at");

                entity.Property(e => e.ModifiedBy)
                    .HasColumnName("modified_by")
                    .HasMaxLength(50);

                entity.Property(e => e.Reason).HasColumnName("reason");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasMaxLength(15);

                entity.Property(e => e.TId).HasColumnName("t_id");

                entity.Property(e => e.ToDate)
                    .HasColumnName("to_date")
                    .HasColumnType("date");

                entity.Property(e => e.ToWwid).HasColumnName("to_wwid");

                entity.HasOne(d => d.FromWw)
                    .WithMany(p => p.SwapFromWw)
                    .HasForeignKey(d => d.FromWwid)
                    .HasConstraintName("swap_from_wwid_fkey");

                entity.HasOne(d => d.T)
                    .WithMany(p => p.Swap)
                    .HasForeignKey(d => d.TId)
                    .HasConstraintName("swap_t_id_fkey");

                entity.HasOne(d => d.ToWw)
                    .WithMany(p => p.SwapToWw)
                    .HasForeignKey(d => d.ToWwid)
                    .HasConstraintName("swap_to_wwid_fkey");
            });

            modelBuilder.Entity<Team>(entity =>
            {
                entity.HasKey(e => e.TId)
                    .HasName("team_pkey");

                entity.ToTable("team");

                entity.Property(e => e.TId)
                    .HasColumnName("t_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.BuId).HasColumnName("bu_id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasMaxLength(50);

                entity.Property(e => e.MgrId).HasColumnName("mgr_id");

                entity.Property(e => e.ModifiedAt).HasColumnName("modified_at");

                entity.Property(e => e.ModifiedBy)
                    .HasColumnName("modified_by")
                    .HasMaxLength(50);

                entity.Property(e => e.TName)
                    .HasColumnName("t_name")
                    .HasMaxLength(150);

                entity.HasOne(d => d.Bu)
                    .WithMany(p => p.Team)
                    .HasForeignKey(d => d.BuId)
                    .HasConstraintName("team_bu_id_fkey");
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.HasKey(e => e.Wwid)
                    .HasName("users_pkey");

                entity.ToTable("users");

                entity.HasIndex(e => e.Email)
                    .HasName("users_email_key")
                    .IsUnique();

                entity.Property(e => e.Wwid)
                    .HasColumnName("wwid")
                    .ValueGeneratedNever();

                entity.Property(e => e.BuId).HasColumnName("bu_id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasMaxLength(50);

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(255);

                entity.Property(e => e.ModifiedAt).HasColumnName("modified_at");

                entity.Property(e => e.ModifiedBy)
                    .HasColumnName("modified_by")
                    .HasMaxLength(50);

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(255);

                entity.Property(e => e.Passwordhash).HasColumnName("passwordhash");

                entity.Property(e => e.Passwordsalt).HasColumnName("passwordsalt");

                entity.Property(e => e.PhoneNo).HasColumnName("phone_no");

                entity.Property(e => e.Role)
                    .HasColumnName("role")
                    .HasMaxLength(100);

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasMaxLength(15);

                entity.Property(e => e.TId).HasColumnName("t_id");

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasMaxLength(100);

                entity.HasOne(d => d.Bu)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.BuId)
                    .HasConstraintName("users_bu_id_fkey");

                entity.HasOne(d => d.T)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.TId)
                    .HasConstraintName("users_t_id_fkey");
            });

            modelBuilder.Entity<UsersHistory>(entity =>
            {
                entity.HasKey(e => e.SlNo)
                    .HasName("users_history_pkey");

                entity.ToTable("users_history");

                entity.Property(e => e.SlNo).HasColumnName("sl_no");

                entity.Property(e => e.BuId).HasColumnName("bu_id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasMaxLength(50);

                entity.Property(e => e.ModifiedAt).HasColumnName("modified_at");

                entity.Property(e => e.ModifiedBy)
                    .HasColumnName("modified_by")
                    .HasMaxLength(50);

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(255);

                entity.Property(e => e.Role)
                    .HasColumnName("role")
                    .HasMaxLength(100);

                entity.Property(e => e.TId).HasColumnName("t_id");

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasMaxLength(100);

                entity.Property(e => e.Wwid).HasColumnName("wwid");

                entity.HasOne(d => d.Ww)
                    .WithMany(p => p.UsersHistory)
                    .HasForeignKey(d => d.Wwid)
                    .HasConstraintName("users_history_wwid_fkey");
            });

            modelBuilder.Entity<WeekOff>(entity =>
            {
                entity.HasKey(e => e.WoId)
                    .HasName("week_off_pkey");

                entity.ToTable("week_off");

                entity.Property(e => e.WoId).HasColumnName("wo_id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasMaxLength(50);

                entity.Property(e => e.ModifiedAt).HasColumnName("modified_at");

                entity.Property(e => e.ModifiedBy)
                    .HasColumnName("modified_by")
                    .HasMaxLength(50);

                entity.Property(e => e.Wo1).HasColumnName("wo_1");

                entity.Property(e => e.Wo2).HasColumnName("wo_2");

                entity.Property(e => e.WorkDays)
                    .HasColumnName("work_days")
                    .HasMaxLength(50);
            });
        }
    }
}
