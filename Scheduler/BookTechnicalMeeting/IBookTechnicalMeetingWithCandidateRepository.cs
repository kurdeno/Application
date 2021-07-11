using System;

namespace Scheduler.BookTechnicalMeeting
{
    public interface IBookTechnicalMeetingWithCandidateRepository
    {
        (DateTime term, Guid verificator1, Guid verificator2) GetTwoAvailableTechnicalVerificators();
        void SaveMeeting((DateTime term, Guid verificator1, Guid verificator2) verificatorsWithTerm, Guid dataCandidateId);
    }
}