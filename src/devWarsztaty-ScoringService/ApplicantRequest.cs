namespace devWarsztaty_ScoringService
{
    public class ApplicantRequest
    {
        public string Name { get; set; }

        public string LastName { get; set; }

        public string Country { get; set; }

        public double Income { get; set; }

        public bool Mortgage { get; set; }
    }
}