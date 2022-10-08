namespace BuilderPatternExample;

public class AddressBuilder : IBuilder<Address>
{
    private readonly Address _address;

    public AddressBuilder()
    {
        _address = new Address();
    }

    public AddressBuilder SetLine(string line)
    {
        _address.Line = line;

        return this;
    }

    public AddressBuilder SetCity(string city)
    {
        _address.City = city;

        return this;
    }

    public AddressBuilder SetProvince(string province)
    {
        _address.Province = province;

        return this;
    }

    public AddressBuilder SetPostCode(string postCode)
    {
        _address.PostCode = postCode;

        return this;
    }

    public Address Build()
    {
        return _address;
    }

}