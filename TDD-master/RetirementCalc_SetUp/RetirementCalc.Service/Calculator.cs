using System;

namespace RetirementCalc.Service
{
    public class Calculator
    {
       public int RetirementYears(Client client)
       {
            var years = client.targetRetirementAge - client.currentAge;
            if(client.currentAge < client.targetRetirementAge)
            {
                for(var i = 0; i < years; i ++)
                {
                    client.netWorth += client.yearlySavingContribution - client.yearlyExpenses;
                    client.currentAge++;
                }
            }

           else if(client.currentAge == client.targetRetirementAge)
            {
                var yearsAfter = 0;
                for(var i = 0; i < client.netWorth; i++)
                {
                    client.netWorth -= (client.desiredMonthlySpending * 12);
                    yearsAfter++;
                }
                return yearsAfter;
                
            }
           return Convert.ToInt32(client.netWorth);
       }
    }
}
