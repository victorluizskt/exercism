using System;
static class QuestLogic
{
    public static bool CanFastAttack(bool knightIsAwake)
    {
        var attack = knightIsAwake ? false : true; 
        return attack;
    }
    public static bool CanSpy(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake)
    {
        if(knightIsAwake || archerIsAwake || prisonerIsAwake) {
            return true;
        }
    
        return false;
    }
    public static bool CanSignalPrisoner(bool archerIsAwake, bool prisonerIsAwake)
    {
        if(archerIsAwake && prisonerIsAwake)
        {
            return false;
        } else if(!archerIsAwake && prisonerIsAwake)
        {
            return true;
        }
    
        return false;
    }
    public static bool CanFreePrisoner(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake, bool petDogIsPresent)
    {
        if(petDogIsPresent && !archerIsAwake)
        {
            return true;
        } else if(!petDogIsPresent && prisonerIsAwake && !archerIsAwake && !knightIsAwake)
        {
            return true;
        }
        return false;
    }
}
