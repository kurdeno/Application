using System;
using Scheduler;
using Scheduler.BookTechnicalMeeting;

namespace Recruitment.HeadManagerDecisions.Acceptance
{
    public class InitialAcceptanceHandler : IInitialAcceptanceHandler
    {
        private readonly IInitialAceptanceRepository _repository;
        private readonly IBookTechnicalMeetingWithCandidateHandler _bookMeetingHandler;
        private readonly IEmailSender _emailSender;

        public InitialAcceptanceHandler(IInitialAceptanceRepository repository, 
            IBookTechnicalMeetingWithCandidateHandler bookMeetingHandler, 
            IEmailSender emailSender)
        {
            _repository = repository;
            _bookMeetingHandler = bookMeetingHandler;
            _emailSender = emailSender;
        }

        public void Handle(InitialAcceptance data)
        {
            // INFO: Create transaction over operation 1 and 2

            // Operation 1
            _repository.AcceptCandidateInitialy(data.CandidateId);

            // Operation 2
            _bookMeetingHandler.Handle(new BookTechnicalMeetingWithCandidate(){CandidateId = data.CandidateId});

            _emailSender.SendInvitationForMeeting();
        }
    }

    public class InitialAcceptance
    {
        public Guid CandidateId { get; set; }
    }
}
