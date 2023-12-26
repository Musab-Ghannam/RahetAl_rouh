using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Entities;

public partial class Feedback
{
    [Key]
    public int FeedbackId { get; set; }
    public int? Rating { get; set; }
    public string? Comment { get; set; }
    public string? Title { get; set; }
    public int? Statefeedback { get; set; }
    public DateTime? Feedbacktime { get; set; }
    public virtual AspNetUser User { get; set; }

    [ForeignKey(nameof(User))]
    public Guid UserId { get; set; }
}
