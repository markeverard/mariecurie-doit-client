namespace MarieCurie.DoIt.Domain
{
    public enum LocationType
    {
        //No location - null for working from home or no location
        //specific location - should be accompanied by an address
        SL,
        //regionsl location - should be accompanied by a location_id 
        RL,
    }
}