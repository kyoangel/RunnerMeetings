namespace RunnerMeetings
{
    public class MeetingChecker
    {
        public int Distance
        {
            set;
            get;
        }

        public int Speed
        {
            set;
            get;
        }

        public bool IsMeet
        {
            set;
            get;
        }

        public bool Compare(MeetingChecker x)
        {
            if ((x.Distance == this.Distance) &&
                (x.Speed == this.Speed) &&
                (x.IsMeet == this.IsMeet))
                return true;
            else
                return false;
        }
    }
}