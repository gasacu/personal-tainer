﻿using PTApp.Server.Repositories.Interfaces;

namespace PTApp.Server.Models
{
    public class Workout : IIdentifiable
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public string WorkoutName { get; set; }
        public string WorkoutType { get; set; }
        public int DurationMinutes { get; set; }
        public string DifficultyLevel { get; set; }
        public int CaloriesBurned { get; set; }
        public DateTime CreatedAt { get; set; }

        public User User { get; set; }
        public ICollection<WorkoutExercise> WorkoutExercises { get; set; }
    }
}
