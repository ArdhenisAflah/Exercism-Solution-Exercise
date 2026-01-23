static class QuestLogic
{
    
    public static bool CanFastAttack(bool knightIsAwake)
    {
        if(!knightIsAwake) return true;
        return false;
    }

    public static bool CanSpy(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake)
    {
       if(knightIsAwake || archerIsAwake || prisonerIsAwake) return true;
        else return false;
    }

    public static bool CanSignalPrisoner(bool archerIsAwake, bool prisonerIsAwake)
    {
       return !archerIsAwake && prisonerIsAwake; 
    }

    public static bool CanFreePrisoner(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake, bool petDogIsPresent)
    {
      return (petDogIsPresent && !archerIsAwake) || (!petDogIsPresent && prisonerIsAwake && (!knightIsAwake && !archerIsAwake));
    
    }
}
