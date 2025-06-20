public class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public Address GetAddress()
    {
        return _address;
    }

    public string CustomerName()
    {
        return _name;
    }
    public bool LivesInUSA()
    {
        return _address.InUSA();
    }
}