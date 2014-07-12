namespace DesignPatterns.BehavioralPatterns.Observer.SampleCode
{
    public class Time
    {
        public int Hour { get; set; }
        public int Minute { get; set; }
        public int Second { get; set; }

        public void Update(int hour, int minute, int second)
        {
            // validar ...
            Second += second;
            Minute += minute;
            Hour += hour;                        
        }
    }
}