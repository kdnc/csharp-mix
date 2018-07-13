using System;
using System.Collections.Generic;
using System.Text;
using Kdnc.App.Application.Services.Model.Mappers;
using Kdnc.App.Domain.DataAccess;
using Kdnc.App.Domain.Models;

namespace Kdnc.App.Application.Services
{
    public class SamuraisApplicationService: ISamuraisApplicationService
    {
        private readonly ISamuraiRepository _samuraiRepository;

        public SamuraisApplicationService(ISamuraiRepository samuraiRepository)
        {
            this._samuraiRepository = samuraiRepository;
        }

        public Samurai CreateSamurai(SamuraiDto samuraiDto)
        {
            var samuraiMapper = new SamuraiMapper();
            var samurai = samuraiMapper.EntityFrom(samuraiDto);
            var result = this._samuraiRepository.CreateSamurai(samurai);
            return result;
        }
    }
}
