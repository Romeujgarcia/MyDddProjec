

using MyDddProject.Domain.Entities;

namespace MyDddProject.Domain.Repositories
{
    public interface IProductRepository
    {
        Product GetById(int id);
        void Add(Product product);
    }
}