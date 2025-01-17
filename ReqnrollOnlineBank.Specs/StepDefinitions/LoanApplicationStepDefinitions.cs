namespace ReqnrollOnlineBank.Specs.StepDefinitions
{
    [Binding]
    [Scope(Tag = "loanapplication")]
    public class LoanApplicationStepDefinitions
    {
        [BeforeScenario(tags: "loanapplication")]
        public void InitializeParaBankApplication()
        {
        }

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

        [AfterScenario(tags: "loanapplication")]
        public void DoSomeNecessaryCleanup()
        {
        }
    }
}
