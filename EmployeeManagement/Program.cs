namespace EmployeeManagement
{
    class Program
    {
        public static void Main(string[] args)
        {
            //UseCase1
            EmployeeSalary.EmployeeAttandance();
            Console.ReadKey();
            Console.WriteLine("-------------------------");
            //UseCase2
            EmployeeWage employeeWage = new EmployeeWage();
            employeeWage.FullTimeEmployeeWage();
            Console.WriteLine("-------------------------");
            //UseCase3
            AddPartTimeEmpWage addPartTimeEmpWage = new AddPartTimeEmpWage();
            addPartTimeEmpWage.PartTimeEmpWage();
            Console.WriteLine("-------------------------");
            //UseCase4
            CaseStatement caseStatement = new CaseStatement();
            caseStatement.Display();
            Console.WriteLine("-------------------------");
            //UseCase5
            EmpWagesPerMonth empWagesPerMonth = new EmpWagesPerMonth();
            empWagesPerMonth.Display();
            Console.WriteLine("-------------------------");
            //UseCase6
            MaxWorkingHours maxWorkingHours = new MaxWorkingHours();
            maxWorkingHours.Display();
           


        }
    }
}