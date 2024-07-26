public class Time1
{
    private int hour;
    private int minute;
    private int second;

    // set a new time value using universal time; throw an
    // exception if the hour, minute or second is invalid
    public void SetTime(int h, int m, int s)
    {
        if ((h >= 0 && h < 24) && (m >= 0 && m < 60) && (s >= 0 && s < 60))
        {
            hour = h;
            minute = m;
            second = s;
        } // end if
        else
            throw new ArgumentOutOfRangeException();
    } // end method

    // convert to string in universal-time format (HH:MM:SS)
    public string ToUniversalString()
    {
        return string.Format($"{hour:D2}:{minute:D2}:{second:D2}");
    } // end method

    // convert to string in standard-time format (H:MM:SS AM or PM)
    public override string ToString()
    {
        return string.Format("{0}:{1:D2}:{2:D2} {3}", (( hour == 0 || hour == 12 ) ? 12 : hour % 12), minute, second, (hour < 12 ? "AM" : "PM"));
    } // end method
} // end class