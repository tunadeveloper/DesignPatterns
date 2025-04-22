using RepositoryDesignPattern.BusinessLayer.Abstract;
using RepositoryDesignPattern.DataAccessLayer.Abstract;
using RepositoryDesignPattern.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryDesignPattern.BusinessLayer.Concrete
{
    public class ProductManager : IProductService
    {
        private readonly IProductDAL _productDAL;

        public ProductManager(IProductDAL productDAL)
        {
            _productDAL = productDAL;
        }

        public void TDelete(Product entity)
        {
            _productDAL.Delete(entity);
        }

        public Product TGetById(int id)
        {
          return _productDAL.GetById(id);
        }

        public List<Product> TGetList()
        {
          return _productDAL.GetList();
        }

        public void TInsert(Product entity)
        {
            _productDAL.Insert(entity);
        }

        public List<Product> TProductListWithCategory()
        {
            return _productDAL.ProductListWithCategory();
        }

        public void TUpdate(Product entity)
        {
         _productDAL.Update(entity);
        }
    }
}
