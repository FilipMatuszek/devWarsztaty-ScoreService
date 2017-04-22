namespace devWarsztaty_ScoringService
{
    public class ApplicantResponse
        {
            public bool Eligible { get; }

            public ApplicantResponse(bool eligible)
            {
                Eligible = eligible;
            }
        }
}