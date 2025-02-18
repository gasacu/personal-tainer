using Microsoft.EntityFrameworkCore;
using PTApp.Server.Models;

namespace PTApp.Server.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        { }

        public DbSet<Exercise> Exercises { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<ProgressTracking> ProgressTrackings { get; set; }
        public DbSet<Subscription> Subscriptions { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Workout> Workouts { get; set; }
        public DbSet<WorkoutExercise> WorkoutExercises { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasMany(u => u.Workouts)
                .WithOne(w => w.User)
                .HasForeignKey(w => w.UserId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_Workouts_Users");

            modelBuilder.Entity<User>()
                .HasMany(u => u.ProgressTrackings)
                .WithOne(p => p.User)
                .HasForeignKey(p => p.UserId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_ProgressTracking_Users");

            modelBuilder.Entity<WorkoutExercise>()
                .HasKey(we => new { we.WorkoutId, we.ExerciseId });

            modelBuilder.Entity<WorkoutExercise>()
                .HasOne(we => we.Workout)
                .WithMany(w => w.WorkoutExercises)
                .HasForeignKey(we => we.WorkoutId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_WorkoutExercises_Workouts");

            modelBuilder.Entity<WorkoutExercise>()
               .HasOne(we => we.Exercise)
               .WithMany(e => e.WorkoutExercises)
               .HasForeignKey(we => we.ExerciseId)
               .OnDelete(DeleteBehavior.Cascade)
               .HasConstraintName("FK_WorkoutExercises_Exercises");

            modelBuilder.Entity<User>()
                .HasMany(u => u.Subscriptions)
                .WithOne(s => s.User)
                .HasForeignKey(s => s.UserId)
                .OnDelete(DeleteBehavior.Restrict) // Prevent deletion of a user if they have active subscriptions
                .HasConstraintName("FK_Subscriptions_Users");

            modelBuilder.Entity<User>()
                .HasMany(u => u.Payments)
                .WithOne(p => p.User)
                .HasForeignKey(p => p.UserId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_Payments_Users");

            base.OnModelCreating(modelBuilder);
        }

    }
}
