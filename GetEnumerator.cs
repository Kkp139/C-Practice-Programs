class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Job { get; set; }
    public double Salary { get; set; }

}

class Orgainzation : IEnumerable  // PART OF SECOND SCENARIO 
{
    List<Employee> orgainzationList = new List<Employee>();
    public void Add(Employee employee)
    {
        orgainzationList.Add(employee);
    }

    public IEnumerator GetEnumerator()
    {
        throw new NotImplementedException();
    }
}
class TestEmployee
{
    static void Main()
    {
        // SECOND SCENARIO :-
        Orgainzation org = new Orgainzation();
        org.Add(new Employee { Id = 7, Name = "kamal", Job = "Manager", Salary = 45000 });
        org.Add(new Employee { Id = 4, Name = "Rohit", Job = "clerk", Salary = 25000 });

        foreach (Employee employee in org) // ERROR :-  we not have GetEnumerator
        {
            Console.WriteLine($"{employee.Id} {employee.Name} {employee.Job} {employee.Salary}");
        }

        // FIRST SCENARIO :-
        //List<Employee> employeeList = new List<Employee>();
        //employeeList.Add(new Employee { Id=7,Name = "kamal", Job = "Manager", Salary= 45000});
        //employeeList.Add(new Employee { Id = 4, Name = "Rohit", Job = "clerk", Salary = 25000 });
        //employeeList.Add(new Employee { Id = 8, Name = "Nirav", Job = "Sr. Manager", Salary = 75000 });
        //employeeList.Add(new Employee { Id = 1, Name = "Shyam", Job = "CEO", Salary = 145000 });

        //foreach(Employee employee in employeeList)
        //{
        //    Console.WriteLine($"{employee.Id} {employee.Name} {employee.Job} {employee.Salary}");
        //}

        //orgainzationList.Add(new Employee { Id = 7, Name = "kamal", Job = "Manager", Salary = 45000 });
        //orgainzationList.Add(new Employee { Id = 4, Name = "Rohit", Job = "clerk", Salary = 25000 });
        //orgainzationList.Add(new Employee { Id = 8, Name = "Nirav", Job = "Sr. Manager", Salary = 75000 });
        //orgainzationList.Add(new Employee { Id = 1, Name = "Shyam", Job = "CEO", Salary = 145000 });


    }
}