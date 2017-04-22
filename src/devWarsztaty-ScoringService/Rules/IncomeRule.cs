namespace devWarsztaty_ScoringService.Rules
{
    public class IncomeRule : IRule
    {
        public bool Validate(ApplicantRequest applicantRequest)
        {
            return applicantRequest.Income >= 20000;
        }
    }
}