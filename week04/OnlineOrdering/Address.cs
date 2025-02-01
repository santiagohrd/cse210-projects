public class Address
{
    private string _streetAddress;
    private string _city;
    private string _stateProvince;
    private string _country;

    public Address(string streetName, string city, string state, string country)
    {
        _streetAddress = streetName;
        _city = city;
        _stateProvince = state;
        _country = country;
    }

    public string GetStreet()
    {
        return _streetAddress;
    }

    public string GetCity()
    {
        return _city;
    }

    public string GetState()
    {
        return _stateProvince;
    }

    public string GetCountry()
    {
        return _country;
    }

    public string CompleteAddress()
    {
        return $"{GetStreet()} \n {GetCity()}, {GetState()} \n {GetCountry()}";
    }
}