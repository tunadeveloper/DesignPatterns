using DesignPattern.ChainOfResponsibility.DataAccessLayer;
using DesignPattern.ChainOfResponsibility.Models;

namespace DesignPattern.ChainOfResponsibility.ChainOfResponsbility
{
    public class Manager : Employee
    {
        public override void ProcessRequest(CustomerProcessViewModel request)
        {
           Context context = new Context();
            if(request.Amount <= 250000)
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Amount = request.Amount.ToString();
                customerProcess.Name = request.Name;
                customerProcess.EmployeeName = "Şube Müdürü - Elif Ayhan";
                customerProcess.Description = "Para çekme işlemi onaylandı!";

                context.CustomerProcesses.Add(customerProcess);
                context.SaveChanges();
            }else if(NextApprover != null)
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Amount = request.Amount.ToString();
                customerProcess.Name = request.Name;
                customerProcess.EmployeeName = "Şube Müdürü - Elif Ayhan";
                customerProcess.Description = "Para çekme tutarı şube müdürünün günlük ödeme limiti aşıyor, işlem bölge müdüre yönlendirildi!";

                context.CustomerProcesses.Add(customerProcess);
                context.SaveChanges();
            }
        }
    }
}
