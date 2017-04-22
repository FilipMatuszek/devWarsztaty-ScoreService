namespace devWarsztaty_ScoringService.Rules
{
    public class CountryRule : IRule
    {
        public bool Validate(ApplicantRequest applicantRequest)
        {
            return applicantRequest.Country.Contains("Poland");
        }
    }
}