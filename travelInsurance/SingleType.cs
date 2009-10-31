using System;

namespace travelInsurance
{
    public class SingleType : IPolicyType
    {
        private decimal basePremium = 20.00m;
        public decimal GetPremiumModifier()
        {
            return basePremium;
        }
    }
}
