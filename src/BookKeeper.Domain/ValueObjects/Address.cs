namespace BookKeeper.Domain.ValueObjects;
#pragma warning disable S125 // Sections of code should not be commented out

//public sealed class Address : ValueObject
//{
//    public NonEmptyString Street { get; private set; }

//    public NonEmptyString City { get; private set; }

//    public NonEmptyString State { get; private set; }

//    public NonEmptyString Country { get; private set; }

//    public NonEmptyString PostCode { get; private set; }

//    public Address() { }

//    public Address(
//        NonEmptyString street, 
//        NonEmptyString city, 
//        NonEmptyString state, 
//        NonEmptyString country, 
//        NonEmptyString postCode)
//    {
//        Street = street;
//        City = city;
//        State = state;
//        Country = country;
//        PostCode = postCode;
//    }

//    protected override IEnumerable<object> GetEqualityComponents()
//    {
//        yield return Street;
//        yield return City; 
//        yield return State;
//        yield return Country; 
//        yield return PostCode;
//    }
//}

public record struct Address(
#pragma warning restore S125 // Sections of code should not be commented out
    string Line1, 
    string? Line2, 
    string City, 
    string Country, 
    string PostCode);

public record struct PhoneNumber(int CountryCode, long Number);

public record struct Contact
{
    public required Address Address { get; init; }
    public required PhoneNumber HomePhone { get; init; }
    public required PhoneNumber WorkPhone { get; init; }
    public required PhoneNumber MobilePhone { get; init; }
}
