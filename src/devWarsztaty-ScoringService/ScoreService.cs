using System.Collections.Generic;
using System.Linq;
using devWarsztaty_ScoringService.Rules;

namespace devWarsztaty_ScoringService
{
    public class ScoreService : IScoreService
    {
        private readonly IList<IRule> rules;

        public ScoreService()
        {
            rules = new List<IRule>();
            rules.Add(new CountryRule());
            rules.Add(new IncomeRule());
            rules.Add(new MorgageRule());
        }

        public bool CheckRules(ApplicantRequest applicantRequest)
        {
            return rules.All(x => x.Validate(applicantRequest));
        }
    }
}