using PTApp.Server.Repositories.Interfaces;

namespace PTApp.Server.Models
{
    public class WorkoutExercise : IIdentifiable
    {
        public Guid Id { get; set; }
        public Guid WorkoutId { get; set; }
        public Guid ExerciseId { get; set; }
        public int Sets { get; set; }
        public int Reps { get; set; }
        public int DurationSeconds { get; set; }
        
        public Workout Workout { get; set; }
        public Exercise  Exercise { get; set; }
        
    }
}
