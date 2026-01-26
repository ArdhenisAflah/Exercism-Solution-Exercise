public static class PhoneNumber
{
    public static (bool IsNewYork, bool IsFake, string LocalNumber) Analyze(string phoneNumber)
    {
        bool IsNewYork = false;
        bool IsFake = false;
        string LocalNumber;
        //split
        string[] phoneInfo = phoneNumber.Split('-');

        if(phoneInfo[0] == "212") IsNewYork = true;
      

         if(phoneInfo[1] == "555") IsFake = true;

        LocalNumber = phoneInfo[2];
    

        return (IsNewYork, IsFake, LocalNumber);
    }

    public static bool IsFake((bool IsNewYork, bool IsFake, string LocalNumber) phoneNumberInfo) => phoneNumberInfo.IsFake;
 
}
