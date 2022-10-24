using EPiServer.PlugIn;
using EPiServer.Scheduler;


namespace epi21_test.Business.ScheduledJobs
{
    [ScheduledPlugIn(
        DisplayName = "Ett testjobb",
        Description = "ett testjobb som inte går något",
        GUID = "67EDDAA7-376D-4DE0-A796-117B62C4E4F3"
        )]
    public class TestJob : ScheduledJobBase
    {
        private bool _stopSignaled;
        public TestJob()
        {
            IsStoppable = true;
        }
        public override void Stop()
        {
            _stopSignaled = true;
        }
        public override string Execute()
        {
            //todo anropa en metod som gör något
            if (_stopSignaled)
            {
                return "jobbet har stoppats";
            }
            return "jobbet har avslutas";
        }
    }
}