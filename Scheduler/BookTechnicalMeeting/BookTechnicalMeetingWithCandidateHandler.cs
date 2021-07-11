
using System;

namespace Scheduler.BookTechnicalMeeting
{
    public class BookTechnicalMeetingWithCandidateHandler : IBookTechnicalMeetingWithCandidateHandler
    {
        private readonly IBookTechnicalMeetingWithCandidateRepository _repository;

        public BookTechnicalMeetingWithCandidateHandler(IBookTechnicalMeetingWithCandidateRepository repository, IEmailSender emailSender)
        {
            _repository = repository;
        }

        public void Handle(BookTechnicalMeetingWithCandidate data)
        {
            var verificatorsWithTerm = _repository.GetTwoAvailableTechnicalVerificators();

            // if need some logic... : for example there is a rule: 2 technical verificators are junior ones then cannot book such meeting, then...
            // create project Scheduler.Domain, create there buisness object modelling above rule, e.x. by class TechnicalVerificators and write such logic there
            // ... write unit tests for it
            // if logic failed throw domain excpetion 

            _repository.SaveMeeting(verificatorsWithTerm, data.CandidateId);
        }
    }


    public class BookTechnicalMeetingWithCandidate
    {
        public Guid CandidateId { get; set; }
    }
}
