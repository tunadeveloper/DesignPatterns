using DesignPattern.ChainOfResponsibility.DataAccessLayer;
using DesignPattern.ChainOfResponsibility.Models;

namespace DesignPattern.ChainOfResponsibility.ChainOfResponsbility
{
    public class AreaDirector : Employee
    {
        public override void ProcessRequest(CustomerProcessViewModel request)
        {
            Context context = new Context();
            if (request.Amount <= 400000) { 
            CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Amount = request.Amount.ToString();
                customerProcess.Name = request.Name;
                customerProcess.EmployeeName = "Bölge Müdürü - Faruk Bilge";
                customerProcess.Description = "Para çekme işlemi onaylandı!";
                context.CustomerProcesses.Add(customerProcess);
                context.SaveChanges();

            }else
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Amount = request.Amount.ToString();
                customerProcess.Name = request.Name;
                customerProcess.EmployeeName = "Bölge Müdürü - Faruk Bilge";
                customerProcess.Description = "Para çekme tutarı bölge müdürünün günlük ödeme limiti aşıyor, işlem onaylanmadı, müşterinin günlük çekebebileceği tutar 400.000₺!";
                context.CustomerProcesses.Add(customerProcess);
                context.SaveChanges();
            }
    }
    }
}
