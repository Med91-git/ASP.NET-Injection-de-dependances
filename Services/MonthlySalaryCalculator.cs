namespace ASP.Net_Injection_de_dépendances.Services
{
    public class MonthlySalaryCalculator : ISalaryCalculator
    {
        public Double CalculateSalary(Double yearlyAmount)
        {
            return yearlyAmount / 12; 
        }

    }
}
