using System;

namespace Recruitment.HeadManagerDecisions.Acceptance
{
    public interface IInitialAceptanceRepository
    {
        void AcceptCandidateInitialy(Guid candidateId);
    }
}