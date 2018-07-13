using System.Collections.Generic;

namespace Kdnc.App.Domain.Models
{
    public class SamuraiDto
    {
        public SamuraiDto()
        {
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Quote> Quotes { get; set; }
        public SecretIdentity SecretIdentity { get; set; }
    }
}
