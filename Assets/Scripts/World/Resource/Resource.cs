namespace World
{
    public interface IResource
    {
        public ResourceType resourceType { get; }
        protected int Amount { get; set; }
        
        public int GetAmount()
        {
            return Amount;
        }

        public void AddAmount(int amount)
        {
            Amount += amount;
            ResourceManager.OnResourceAmountUpdate(resourceType);
        }
    }
    
    public enum ResourceType
    {
        Wood,
        Stone
    }
}