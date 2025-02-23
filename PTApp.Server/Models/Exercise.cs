using PTApp.Server.Repositories.Interfaces;

namespace PTApp.Server.Models
{
    public class Exercise : IIdentifiable
    {
        public Guid Id { get; set; }
        public string ExerciseName { get; set; }
        public string Description { get; set; }
        public string MuscleGroup { get; set; }
        public string EquipmentNeeded { get; set; }
        public string VideoUrl { get; set; }

        public ICollection<WorkoutExercise> WorkoutExercises { get; set; }
    }   
}
