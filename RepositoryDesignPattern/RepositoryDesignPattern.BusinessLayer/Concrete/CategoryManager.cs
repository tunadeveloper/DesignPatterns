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
    public class CategoryManager : ICategoryService
    {
        private readonly ICategoryDAL _categoryDAL;

        public CategoryManager(ICategoryDAL categoryDAL)
        {
            _categoryDAL = categoryDAL;
        }

        public void TDelete(Category entity)
        {
           _categoryDAL.Delete(entity);
        }

        public Category TGetById(int id)
        {
           return _categoryDAL.GetById(id);
        }

        public List<Category> TGetList()
        {
            return _categoryDAL.GetList();
        }

        public void TInsert(Category entity)
        {
            _categoryDAL.Insert(entity);
        }

        public void TUpdate(Category entity)
        {
          _categoryDAL.Update(entity);
        }
    }
}
