
namespace Session_3_ADV_C__Demo.Dictionary
{
    internal class Employee
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public decimal Salary { get; set; }

        public Employee(int id, string? name, decimal salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }

        //public override string ToString()
        //{
        //    return $"Id : {Id} , Name : {Name} , Salary : {Salary}";
        //}

        ////or 

        //// law betet3aml ma3 faunction me4 bet3ml 8er return we el body beta3ha hwa satr wa7d 2st5dm el fat arraow[=>]

        public override string ToString() => $"Id : {Id} , Name : {Name} , Salary : {Salary}";

        public override bool Equals(object? obj)
        {
            return obj is Employee employee &&
                   Id == employee.Id &&
                   Name == employee.Name &&
                   Salary == employee.Salary;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Name, Salary);
        }
    }
}
