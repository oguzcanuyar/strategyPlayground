namespace World
{
    public class Wood : IResource
    {
        private int _amount;

        public ResourceType resourceType => ResourceType.Wood;

        int IResource.Amount
        {
            get => _amount;
            set => _amount = value;
        }
    }
}