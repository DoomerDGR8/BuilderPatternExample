using System.Text.Json;
using BuilderPatternExample;

var person = new PersonBuilder()
    .SetName("Hassan", "Gulzar")
    .SetBirthDate(new DateTime(1983, 3, 8))
    .SetAddress(new AddressBuilder()
        .SetLine("Apartment 2114, Zakhir Tower 1")
        .SetCity("Sharjah")
        .SetProvince("Sharjah")
        .SetPostCode("61105")
        .Build())
    .AddHomePhone("+971 6 543 1234")
    .AddMobilePhone("+971 50 123 4567")
    .Build();

Console.WriteLine(JsonSerializer.Serialize(person));

Console.ReadLine();