using System;
using Microsoft.AspNetCore.Mvc;
using Recruitment.HeadManagerDecisions.Acceptance;


namespace WebApi.Controllers
{
    // INFO: Use Domain Language in code
    // TODO: Cross cuttings: Authentication + Authorization, Logging, Exception Handling
    // TODO: Add Swagger as WebApi Client
    [ApiController]
    [Route("[controller]")]
    public class HeadManagerDecisionsController : ControllerBase
    {
        private readonly IInitialAcceptanceHandler _intInitialAcceptance;

        public HeadManagerDecisionsController(IInitialAcceptanceHandler intInitialAcceptance)
        {
            _intInitialAcceptance = intInitialAcceptance;
        }

        [HttpPost]
        public IActionResult AcceptCandidateInitially(Guid candidateId)
        {
            // INFO: Currently command is sent synchronously, in future send message asynchronously
            _intInitialAcceptance.Handle(new InitialAcceptance() {CandidateId = candidateId});
            
            return Ok();
        }
    }
}
