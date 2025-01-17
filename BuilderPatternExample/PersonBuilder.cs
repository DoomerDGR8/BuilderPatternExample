﻿namespace BuilderPatternExample;

public class PersonBuilder : IBuilder<Person>
{
    private readonly Person _person;

    public PersonBuilder()
    {
        _person = new Person
        {
            Phones = new List<Phone>()
        };
    }

    public PersonBuilder SetName(string firstName, string lastName)
    {
        _person.FirstName = firstName;
        _person.LastName = lastName;

        return this;
    }

    public PersonBuilder SetBirthDate(DateTime birthDate)
    {
        _person.BirthDate = birthDate;
        _person.Age = DateTime.Now.Year - birthDate.Year;

        return this;
    }

    public PersonBuilder SetAddress(Address address)
    {
        _person.Address = address;
        return this;
    }

    public PersonBuilder AddHomePhone(string phoneNumber)
    {
        var phone = new PhoneBuilder()
            .SetPhoneNumber(phoneNumber)
            .SetPhoneType(PhoneType.Home)
            .Build();

        _person.Phones?.Add(phone);

        return this;
    }

    public PersonBuilder AddMobilePhone(string phoneNumber)
    {
        var phone = new PhoneBuilder()
             .SetPhoneNumber(phoneNumber)
             .SetPhoneType(PhoneType.Mobile)
             .Build();

        _person.Phones?.Add(phone);

        return this;
    }

    public Person Build()
    {
        return _person;
    }
}