public static class LogAnalysis 
{
    // TODO: define the 'SubstringAfter()' extension method on the `string` type
    public static string SubstringAfter(this string str, string delimiter)
    {
        string[] del = str.Split(delimiter);

        if(del != null)
        {
            return del[1];
        }
        return "Not Found";
       
    }
    // TODO: define the 'SubstringBetween()' extension method on the `string` type
    public static string SubstringBetween(this string str, string FirstChar, string LastChar)
    {
        
        int l = str.IndexOf(FirstChar)+1;
        int r = str.IndexOf(LastChar);

        int rest = str.Substring(l, r-l).IndexOf(' ')+1;
        return str.Substring(l, r-l).Substring(rest);
   
       
    }
    // TODO: define the 'Message()' extension method on the `string` type
      public static string Message(this string str)
    {
        
        return str.SubstringAfter(": ");
       
    }
    // TODO: define the 'LogLevel()' extension method on the `string` type
     public static string LogLevel(this string str)
    {
        
        return str.SubstringBetween("[", "]");
       
    }
}