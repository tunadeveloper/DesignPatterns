using DesignPattern.ChainOfResponsibility.DataAccessLayer;
using DesignPattern.ChainOfResponsibility.Models;

namespace DesignPattern.ChainOfResponsibility.ChainOfResponsbility
{
    public class ManagerAssistant : Employee
    {
        public override void ProcessRequest(CustomerProcessViewModel request)
        {
            Context context = new Context();
            if(request.Amount <= 150000)
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Amount = request.Amount.ToString();
                customerProcess.Name = request.Name;
                customerProcess.EmployeeName = "Şube Müdür Yardımcısı - Ahmet Yılmaz";
                customerProcess.Description = "Para çekme işlemi onaylandı!";

                context.CustomerProcesses.Add(customerProcess);
                context.SaveChanges();
            }
            else if(NextApprover != null)
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Amount = request.Amount.ToString();
                customerProcess.Name = request.Name;
                customerProcess.EmployeeName = "Şube Müdür Yardımcısı - Ahmet Yılmaz";
                customerProcess.Description = "Para çekme tutarı şube müdür yardımcısının günlük ödeme limiti aşıyor, işlem şube müdürüne yönlendirildi!";
                context.CustomerProcesses.Add(customerProcess);
                context.SaveChanges();
            }
    }
}
}
