using System.Collections.Generic;
using Kdnc.App.Domain.Models;

namespace Kdnc.App.API.Repositories
{
    public class ValueRepo
    {
        private readonly List<ValueModel> values = new List<ValueModel>();

        public ValueRepo()
        {
            values.Add(new ValueModel { Id = 1, Name = "Anders Heijlsberg" });
            values.Add(new ValueModel { Id = 2, Name = "Rob Eisenberg" });
            values.Add(new ValueModel { Id = 3, Name = "John Mashmellow" });
        }

        public IEnumerable<ValueModel> GetAll()
        {
            return values;
        }
    }
}