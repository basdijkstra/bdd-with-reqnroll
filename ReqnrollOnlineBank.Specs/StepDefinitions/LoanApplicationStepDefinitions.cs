using System;
using Reqnroll;

namespace ReqnrollOnlineBank.Specs.StepDefinitions
{
    [Binding]
    public class LoanApplicationStepDefinitions
    {
        [Given("John is an active ParaBank customer")]
        public void GivenJohnIsAnActiveParaBankCustomer()
        {
        }

        [When("they apply for a {int} dollar loan")]
        public void WhenTheyApplyForADollarLoan(int p0)
        {
        }

        [Then(@"^the loan application is (approved|denied)$")]
        public void ThenTheLoanApplicationIsApproved(string expectedResult)
        {
        }

        [When("their monthly income is {int}")]
        public void WhenTheirMonthlyIncomeIs(int p0)
        {
        }
    }
}
