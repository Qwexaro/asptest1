using System.ComponentModel;

namespace asptest1.Models;

public class Employee
{
    public int Id { get; set; }
    
    [DisplayName("First Name")]
    public string FirstName { get; set; } = string.Empty;
    
    [DisplayName("Last Name")]
    public string LastName { get; set; } = string.Empty;
    
    [DisplayName("Position")]
    public string Position { get; set; } =  string.Empty;
    
    [DisplayName("Date Of Birthday")]
    public DateTime DateOfBirthday { get; set; }
    
    [DisplayName("Country")]
    public string Country { get; set; } = string.Empty;
    
    [DisplayName("Email")]
    public string Email { get; set; } = string.Empty;
    
    [DisplayName("Phone")]
    public string Phone { get; set; } = string.Empty;
    
    [DisplayName("Address")]
    public string Address { get; set; } = string.Empty;
    
    [DisplayName("City")]
    public string City { get; set; } = string.Empty;
    
    [DisplayName("Zip Code")]
    public string ZipCode { get; set; } = string.Empty;
    
    [DisplayName("Postal Code")]
    public string PostalCode { get; set; } = string.Empty;

    [DisplayName("Created By")]
    public string CreatedById { get; set; } = string.Empty;
    
    [DisplayName("Created At")]
    public DateTime CreatedAt { get; set; } =  DateTime.UtcNow;
}