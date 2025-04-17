using DesignPattern.BusinessLayer.Abstract;
using DesignPattern.DataAccessLayer.Abstract;
using DesignPattern.DataAccessLayer.UnitOfWork;
using DesignPattern.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.BusinessLayer.Concrete
{
    public class CustomerManager : ICustomerService
    {
        private readonly ICustomerDAL _customerDAL;
        private readonly IUnitOfWork _unitOfWork;

        public CustomerManager(ICustomerDAL customerDAL, IUnitOfWork unitOfWork)
        {
            _customerDAL = customerDAL;
            _unitOfWork = unitOfWork;
        }

        public void TDelete(Customer t)
        {
            _customerDAL.Delete(t);
            _unitOfWork.Save();
        }

        public Customer TGetByID(int id)
        {
           return _customerDAL.GetByID(id);
        }

        public List<Customer> TGetList()
        {
            return _customerDAL.GetList();
        }

        public void TInsert(Customer t)
        {
           _customerDAL.Insert(t);
            _unitOfWork.Save();
        }

        public void TMultiUpdate(List<Customer> t)
        {
            _customerDAL.MultiUpdate(t);
            _unitOfWork.Save();
        }

        public void TUpdate(Customer t)
        {
            _customerDAL.Update(t);
            _unitOfWork.Save();
        }
    }
}
