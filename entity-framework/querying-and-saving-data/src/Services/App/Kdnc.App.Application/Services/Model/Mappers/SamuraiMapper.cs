using Kdnc.App.Application.Models.Mappers;
using Kdnc.App.Domain.Models;

namespace Kdnc.App.Application.Services.Model.Mappers
{
    public class SamuraiMapper : IModelMapper<SamuraiDto, Samurai>
    {
        public SamuraiDto DtoFrom(Samurai domainEntity)
        {
            throw new System.NotImplementedException();
        }

        public Samurai EntityFrom(SamuraiDto samruaDto)
        {
            return new Samurai()
            {
                Id = samruaDto.Id,
                Name = samruaDto.Name,
            };
        }
    }
}