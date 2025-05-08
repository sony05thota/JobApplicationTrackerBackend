using System.ComponentModel.DataAnnotations;
namespace JobApplicationTracker.Models
{
    public class JobApplication
    {
        public int JobId { get; set; }

        [Required]
        public string CompanyName { get; set; }

        [Required]
        public string Position { get; set; }

        [Required]
        public string Status { get; set; } = "Applied";

        public DateTime DateApplied { get; set; } = DateTime.Now;
    }
}
