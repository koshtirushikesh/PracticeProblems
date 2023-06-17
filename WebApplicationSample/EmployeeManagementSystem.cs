namespace WebApplicationSample
{
    internal class EmployeeManagementSystem
    {
        List<Employee> employeList = new List<Employee>();

        public void AddEmp(Employee employee)
        {
            if (employeList.Any(x => x.EmpId == employee.EmpId))
                Console.WriteLine("Employee allready present in list");
            else
                employeList.Add(employee);
        }

        public void RemoveEmp(Employee employee)
        {
            if (employeList.Remove(employee))
                Console.WriteLine("The employee is removed from the list");
            else
                Console.WriteLine("the error occour while removing the employee");
        }

        public void UpdateEmp(Employee employee)
        {
            if (employeList.Any(x => x.EmpId == employee.EmpId))
            {
                foreach (var emp in employeList)
                {
                    if (emp.EmpId == employee.EmpId)
                    {
                        emp.EmpName = employee.EmpName;
                        emp.Age = employee.Age;
                        emp.Salary = employee.Salary;

                        Console.WriteLine("The emp updated successfully");
                    }
                }
            }
            else
            {
                Console.WriteLine("Employee not found for update");
            }
        }
    }

    internal class Employee
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public int Age { get; set; }
        public int Salary { get; set; }
    }
}
