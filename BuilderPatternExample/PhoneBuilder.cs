namespace BuilderPatternExample;

public class PhoneBuilder : IBuilder<Phone>
{
    private readonly Phone _phone;

    public PhoneBuilder()
    {
        _phone = new Phone();
    }

    public PhoneBuilder SetPhoneType(PhoneType phoneType)
    {
        _phone.PhoneType = phoneType;

        return this;
    }

    public PhoneBuilder SetPhoneNumber(string phoneNumber)
    {
        _phone.PhoneNumber = phoneNumber;

        return this;
    }

    public Phone Build()
    {
        return _phone;
    }

}