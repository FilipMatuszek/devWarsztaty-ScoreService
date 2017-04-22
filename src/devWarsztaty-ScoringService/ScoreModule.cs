using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace devWarsztaty_ScoringService
{
    public class ScoreModule
    {
        private readonly IScoreService scoreService;

        public ScoreModule(IScoreService scoreService)
        {
            this.scoreService = scoreService;
        }
        public Task CheckEligblity(HttpContext httpContext)
        {
            var request = DeserializeAsync<ApplicantRequest>(httpContext);
            var result = scoreService.CheckRules(request);
            var objectResponse = new ApplicantResponse(result);
            var jsonResponse = JsonConvert.SerializeObject(objectResponse);            
            httpContext.Response.Headers.Add("Content-Type", "application/json");
            return httpContext.Response.WriteAsync(jsonResponse);
        }        

        public T DeserializeAsync<T>(HttpContext context) where T : class
        {
            if (context.Request.Body.CanRead)
            {
                using (var sr = new StreamReader(context.Request.Body))
                using (var jr = new JsonTextReader(sr))
                {
                    return new JsonSerializer().Deserialize<T>(jr);
                }
            }
            else
            {
                return null;
            }
        }
    }
}