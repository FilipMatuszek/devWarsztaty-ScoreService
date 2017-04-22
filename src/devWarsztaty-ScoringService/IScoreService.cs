namespace devWarsztaty_ScoringService
{
    public interface IScoreService
    {
        bool CheckRules(ApplicantRequest applicantRequest);
    }
}