using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Kdnc.App.Domain.DataAccess;
using Kdnc.App.Domain.Models;
using Kdnc.App.Repository.DatabaseContext;
using Microsoft.EntityFrameworkCore;

namespace Kdnc.App.Repository.Repositories
{
    public class SamuraiRepository: ISamuraiRepository
    {
        private readonly SamuraiContext _samuraiContext;

        public SamuraiRepository(SamuraiContext samuraiContext)
        {
            _samuraiContext = samuraiContext;
        }

        public Samurai CreateSamurai(Samurai samurai)
        {
            _samuraiContext.Add(samurai);
            _samuraiContext.SaveChanges();
            return samurai;
        }

        public Samurai EditSamurai(Samurai samurai)
        {
            _samuraiContext.Update(samurai);
            _samuraiContext.SaveChanges();
            return samurai;
        }

        public void DeleteSamurai(int id)
        {
            var samurai = _samuraiContext.Samurais.SingleOrDefault(m => m.Id == id);
            _samuraiContext.Samurais.Remove(samurai);
            _samuraiContext.SaveChanges();
        }

        public IEnumerable<Samurai> GetSamurais()
        {
            return _samuraiContext.Samurais.ToList();
        }

        public Samurai GetSamuraiDetails(int id)
        {
            var samurai = _samuraiContext.Samurais
                .Include(s => s.SecretIdentity)
                .Include(s => s.Quotes)
                .SingleOrDefault(m => m.Id == id);
            return samurai;
        }
    }
}
