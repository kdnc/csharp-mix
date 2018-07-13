using System;
using System.Collections.Generic;
using System.Text;
using Kdnc.App.Domain.Models;

namespace Kdnc.App.Domain.DataAccess
{
    public interface ISamuraiRepository
    {
        Samurai CreateSamurai(Samurai samurai);
    }
}
