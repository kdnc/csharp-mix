using System;
using System.Collections.Generic;
using System.Text;
using Kdnc.App.Domain.Models;

namespace Kdnc.App.Application.Services
{
    public interface ISamuraisApplicationService
    {
        Samurai CreateSamurai(SamuraiDto samuraiDto);
    }
}
