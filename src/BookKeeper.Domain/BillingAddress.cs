namespace BookKeeper.Domain;

public sealed class BillingAddress
{
    public Guid Id { get; private set; }
    
    public string StreetAddress { get; private set; } = string.Empty;

    public string Suburb { get; private set; } = string.Empty;
    
    public string State { get; private set; } = string.Empty;
    
    public int PostCode { get; private set; }

    public bool IsCurrent { get; private set; }

    public Guid CustomerId { get; private set; }

    public static BillingAddress Create(
        string streetAddress,
        string suburb,
        string state,
        int postCode,
        Guid customerId) => new()
        {
            Id = Guid.NewGuid(),
            StreetAddress = streetAddress,
            Suburb = suburb,
            State = state,
            PostCode = postCode,
            IsCurrent = true,
            CustomerId = customerId
        };

    public void SetIsCurrent()
    {
        IsCurrent = true;
    }
}
