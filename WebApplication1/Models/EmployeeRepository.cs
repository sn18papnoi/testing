using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class EmployeeRepository
    {
        DBDataContext db = new DBDataContext();
        public List<Employee> GetEmployee()
        {
            return db.Employees.ToList();
        }

        public List<Country> GetCountries()
        {
            return db.Countries.ToList();
        }

        public bool InserEmployee(Employee e)
        {
            bool isSuccess = false;
            try
            {
                db.Employees.InsertOnSubmit(e);
                db.SubmitChanges();
            }
            catch (Exception ex)
            {
                isSuccess = false;
            }
            return isSuccess;
        }
    }
}