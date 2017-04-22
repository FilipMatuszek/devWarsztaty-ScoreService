using System;
using devWarsztaty_ScoringService.Rules;
using Xunit;

namespace devWarsztaty_ScoringService.Tests
{
    public class RulesTests
    {
        [Fact]
        public void GivenValidateWhenCountryIsPolandThenReturnTrue()
        {
            var countryRule = new CountryRule();
            var applicantRequest = new ApplicantRequest
            {
                Country = "Poland"
            };
            var result = countryRule.Validate(applicantRequest);

            Assert.True(result);
        }

        [Fact]
        public void GivenValidateWhenCountryIsNotPolandThenReturnFalse()
        {
            var countryRule = new CountryRule();
            var applicantRequest = new ApplicantRequest
            {
                Country = "USA"
            };
            var result = countryRule.Validate(applicantRequest);

            Assert.False(result);
        }

        [Fact]
        public void GivenValidateWhenIncomeIsGreaterEqual20000ThenReturnTrue()
        {
            var incomeRule = new IncomeRule();
            var applicantRequest = new ApplicantRequest
            {
                Income = 40000
            };
            var result = incomeRule.Validate(applicantRequest);

            Assert.True(result);
        }

        [Fact]
        public void GivenValidateWhenIncomeIsLessThan20000ThenReturnFalse()
        {
            var incomeRule = new IncomeRule();
            var applicantRequest = new ApplicantRequest
            {
                Income = 5000
            };
            var result = incomeRule.Validate(applicantRequest);

            Assert.False(result);
        }

        [Fact]
        public void GivenValidateWhenMortgageOwnedThenReturnFalse()
        {
            var morgageRule = new MorgageRule();
            var applicantRequest = new ApplicantRequest
            {
                Mortgage = true
            };
            var result = morgageRule.Validate(applicantRequest);

            Assert.False(result);
        }

        [Fact]
        public void GivenValidateWhenMortgageIsNotOwnedThenReturnTrue()
        {
            var morgageRule = new MorgageRule();
            var applicantRequest = new ApplicantRequest
            {
                Mortgage = false
            };
            var result = morgageRule.Validate(applicantRequest);

            Assert.True(result);
        }
    }
}
