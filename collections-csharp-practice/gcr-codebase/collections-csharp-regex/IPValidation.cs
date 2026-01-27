using System;
using System.Text.RegularExpressions;
class IPValidation
{
    static void Main()
    {
        string[] ips = {"192.168.1.1","255.255.255.255","256.100.50.25","192.168.1","01.10.10.10"};
        string pattern = @"^(25[0-5]|2[0-4]\d|1\d\d|[1-9]?\d)(\.(25[0-5]|2[0-4]\d|1\d\d|[1-9]?\d)){3}$";
        foreach (string ip in ips)
        {
            Console.WriteLine($"{ip} → {(Regex.IsMatch(ip, pattern) ? "Valid" : "Invalid")}");
        }
    }
}
