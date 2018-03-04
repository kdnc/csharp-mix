using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Kdnc.App.API.Repositories;
using Kdnc.App.Domain.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Kdnc.App.API.Controllers
{
    [Authorize]
    public class ValueController : Controller
    {
        private readonly ValueRepo repo;

        public ValueController(ValueRepo repo)
        {
            this.repo = repo;
        }

        public IEnumerable<ValueModel> GetAll()
        {
            return repo.GetAll();
        }
    }
}
