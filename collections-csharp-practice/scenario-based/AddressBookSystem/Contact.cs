using System;

class Contact
{
    public string FirstName;
    public string LastName;
    public string Address;
    public string City;
    public string State;
    public string Zip;
    public string PhoneNumber;
    public string Email;

    public override bool Equals(object obj)
    {
        if (obj == null || !(obj is Contact))
            return false;

        Contact other = (Contact)obj;

        return FirstName.Equals(other.FirstName, StringComparison.OrdinalIgnoreCase)
            && LastName.Equals(other.LastName, StringComparison.OrdinalIgnoreCase);
    }

    public override string ToString()
    {
        return FirstName + " " + LastName +" | City: " + City +" | State: " + State +" | Phone: " + PhoneNumber;
    }
}
