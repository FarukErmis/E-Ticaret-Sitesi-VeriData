using CommercialSite.Core.Repository;
using EF = CommercialSite.Model.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommercialSite.Service.Repository.Category
{
    public interface ICategoryRepository : IRepository<EF.Category>
    {
    }
}
