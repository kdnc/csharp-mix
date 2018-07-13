namespace Kdnc.App.Domain.Models
{
    public class QuoteDto
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public SamuraiDto Samurai { get; set; }
        public int SamuraiId { get; set; }
    }
}
