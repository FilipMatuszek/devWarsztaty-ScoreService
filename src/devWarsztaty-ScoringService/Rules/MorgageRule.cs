namespace devWarsztaty_ScoringService.Rules
{
    public class MorgageRule : IRule
    {
        public bool Validate(ApplicantRequest applicantRequest)
        {
            return !applicantRequest.Mortgage;
        }
    }
}