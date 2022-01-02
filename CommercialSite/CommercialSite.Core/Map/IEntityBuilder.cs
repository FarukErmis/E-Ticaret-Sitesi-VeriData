using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommercialSite.Core.Map
{
    public interface IEntityBuilder
    {
        void Build(ModelBuilder builder);
    }
}
