static class LogLine
{
    public static string Message(string logLine)
    {
       char[] charsToTrim = { '*', ' ', '\t', '\r', '\n'};
        int b = logLine.IndexOf("]")+2;
        return logLine.Remove(0,b).Trim(charsToTrim);
    }

    public static string LogLevel(string logLine)
    {
        char[] charsToTrim = { '*', ' ', '\t', '\r', '\n'};
          
        int a = logLine.IndexOf("[")+1;
        int b = logLine.IndexOf("]");
        return logLine.Substring(a,b-a).ToLower();
    }

    public static string Reformat(string logLine)
    {
       
        int a = logLine.IndexOf('[')+1;
        int b = logLine.IndexOf(']');
        char[] charsToTrim = { '*', ' ', '\t', '\r', '\n'};
        int c = logLine.IndexOf("]")+2;
        string msg = logLine.Remove(0,c).Trim(charsToTrim);
        string final = $"{msg} ({logLine.Substring(a, b-a).ToLower()})";
        return final;
    }
}
