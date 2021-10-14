using FirmDb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FirmDb
{
    class FirmBusiness
    {
        private FirmContext firmContext;
        public List<Employee> GetAll()
        {
            using (firmContext = new FirmContext())
            {
                return firmContext.Employees.ToList();
            }
        }

        public Employee Get(int id)
        {
            using (firmContext = new FirmContext())
            {
                return firmContext.Employees.Find(id);
            }
        }
        public void Add(Employee employee)
        {
            using (firmContext = new FirmContext())
            {
                firmContext.Employees.Add(employee);
                firmContext.SaveChanges();
            }
        }
        public void Update(Employee employee)
        {
            using (firmContext = new FirmContext())
            {
                var item = firmContext.Employees.Find(employee.Id);
                if (item != null)
                {
                    firmContext.Entry(item).CurrentValues.SetValues(employee);
                    firmContext.SaveChanges();
                }
            }
        }
        public void Delete(int id)
        {
            using (firmContext = new FirmContext())
            {
                var employee = firmContext.Employees.Find(id);
                if (employee != null)
                {
                    firmContext.Employees.Remove(employee);
                    firmContext.SaveChanges();
                }
            }
        }
    }
}
