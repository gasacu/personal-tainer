using PTApp.Server.Repositories.Interfaces;

namespace PTApp.Server.Models
{
    public class User : IIdentifiable
    {
        public Guid Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public DateOnly DateOfBirth { get; set; }
        public string Gender { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public ICollection<Workout> Workouts { get; set; }
        public ICollection<ProgressTracking> ProgressTrackings { get; set; }

    }
}
