namespace World
{
    public class Stone : IResource
    {
        private int _amount;
        public ResourceType resourceType { get; }

        int IResource.Amount
        {
            get => _amount;
            set => _amount = value;
        }
    }
}