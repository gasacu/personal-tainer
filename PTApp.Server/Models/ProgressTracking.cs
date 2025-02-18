namespace PTApp.Server.Models
{
    public class ProgressTracking
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public DateTime DateLogged { get; set; }
        public decimal WeightKg { get; set; }
        public decimal BodyFatPercentage { get; set; }
        public decimal MuscleMassKg { get; set; }
        public int CaloriesConsumed { get; set; }

        public User User { get; set; }
    }
}
