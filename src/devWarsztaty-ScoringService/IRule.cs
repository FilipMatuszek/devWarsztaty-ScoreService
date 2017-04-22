namespace devWarsztaty_ScoringService
{
    public interface IRule
    {
        bool Validate(ApplicantRequest applicantRequest);
    }
}