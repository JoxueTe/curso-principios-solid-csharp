namespace OpenClose
{
    public class EmployeePartTime : IEmployee
    {
        public string Fullname { get; set; }
        public int HoursWorked { get; set; }

        public EmployeePartTime(string fullname, int hoursWorked)
        {
            Fullname = fullname;
            HoursWorked = hoursWorked;
        }

        public decimal CalculateSalaryMonthly()
        {
            decimal hourValue = 20000M;
            decimal salary = hourValue * HoursWorked;
            return salary;
        }
    }
}