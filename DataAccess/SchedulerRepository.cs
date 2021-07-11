using System;
using Scheduler.BookTechnicalMeeting;

namespace DataAcceess
{
    public class SchedulerRepository : IBookTechnicalMeetingWithCandidateRepository //INFO implement others application logic interfaces there
    {
        public (DateTime term, Guid verificator1, Guid verificator2) GetTwoAvailableTechnicalVerificators()
        {
            throw new NotImplementedException();
        }

        public void SaveMeeting((DateTime term, Guid verificator1, Guid verificator2) verificatorsWithTerm, Guid dataCandidateId)
        {
            throw new NotImplementedException();
        }
    }
}