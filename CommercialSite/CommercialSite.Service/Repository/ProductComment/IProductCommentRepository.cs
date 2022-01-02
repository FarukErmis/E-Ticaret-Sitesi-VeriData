using CommercialSite.Core.Repository;
using EF = CommercialSite.Model.Entities;

namespace CommercialSite.Service.Repository.ProductComment
{
    public interface IProductCommentRepository : IRepository<EF.ProductComment>
    {
    }
}
