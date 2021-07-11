namespace Scheduler.BookTechnicalMeeting
{
    public interface IBookTechnicalMeetingWithCandidateHandler
    {
        void Handle(BookTechnicalMeetingWithCandidate data);
    }
}