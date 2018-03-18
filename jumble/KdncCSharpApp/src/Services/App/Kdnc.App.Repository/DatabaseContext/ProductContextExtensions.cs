using System;
using System.Collections.Generic;
using Kdnc.App.Domain.Models;
using Kdnc.App.Repository.DatabaseContext;

namespace Kdnc.App.Repository.DatabaseContext
{
    public static class ProductContextExtensions
    {
        public static void EnsureSeedDataForContext(this ProductContext context)
        {
            // first, clear the database.  This ensures we can always start 
            // fresh with each demo.  Not advised for production environments, obviously :-)

            context.Authors.RemoveRange(context.Authors);
            context.SaveChanges();

            // init seed data
        }
    }
}
