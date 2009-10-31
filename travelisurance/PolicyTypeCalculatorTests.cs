using System;
using NUnit.Framework;

namespace travelInsurance
{
    public class AnnualType : IPolicyType
    {

        public decimal GetPremiumModifier()
        {
            return 80.00m;
        }

    }
    [TestFixture]
    public class PolicyTypeCalculatorTests
    {
        [Test]
        public void GetPremiumModifier_SingleTrip_ReturnTwentyPounds()
        {
            IPolicyType singleTrip = new SingleType();
            decimal result = singleTrip.GetPremiumModifier();
            Assert.AreEqual(20.00m, result);
        }

        [Test]
        public void GetPremiumModifier_AnnualTrip_ReturnEightyPounds()
        {
            IPolicyType annualTrip = new AnnualType();
            decimal result = annualTrip.GetPremiumModifier();
            Assert.AreEqual(80.00m, result);
        }
    }
}