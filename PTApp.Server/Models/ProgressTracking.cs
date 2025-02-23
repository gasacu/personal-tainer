using PTApp.Server.Repositories.Interfaces;

namespace PTApp.Server.Models
{
    public class ProgressTracking : IIdentifiable
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public DateTime DateLogged { get; set; }
        public decimal WeightKg { get; set; }
        public decimal BodyFatPercentage { get; set; }
        public decimal MuscleMassKg { get; set; }
        public int CaloriesConsumed { get; set; }

        public User User { get; set; }
    }
}
