﻿namespace BookKeeper.Domain.Aggregates.CustomerAggregate;

public sealed class Customer
{
    public Guid Id { get; private set; }

    public string FirstName { get; private set; }

    public string LastName { get; private set; }

    public string Email { get; private set; }

    public static Customer Create(
        string firstName,
        string lastName,
        string email) => new()
        {
            Id = Guid.NewGuid(),
            FirstName = firstName,
            LastName = lastName,
            Email = email
        };
}
