using System;
using System.Collections.Generic;
using System.Text;

namespace CompositePattern
{
    public class Employee
    {
        public string name { get; set; }
        public string dept { get; set; }
        public int salary { get; set; }
        public List<Employee> subordinates { get; set; }

        public Employee(string n, string d, int s)
        {
            name = n;
            dept = d;
            salary = s;
            subordinates = new List<Employee>();
        }

        public void add(Employee e)
        {
            subordinates.Add(e);
        }

        public void remove(Employee e)
        {
            subordinates.Remove(e);
        }

        public List<Employee> getSubordinates()
        {
            return subordinates;
        }

        public override string ToString()
        {
            return $"Employee :[ Name : {name} , dept : {dept}, salary : {salary}  ]";
        }
    }
}
