

namespace programacionObjecto
{
    public class Employee
    {
        private int _id;
        private string _name;
        private string _email;
        private string _job;
        private decimal _salary;

        public Employee(int id, string name, string email
            , string job, decimal salary)
        {
            _id = id;
            _name = name;
            _email = email;
            _job = job;
            _salary = salary;
        }


    }
}
