using DataStructLib;
using System;
using System.Collections.Generic;

namespace DataStructLibs
{
    public class Event
    {
        public Guid Id              { get; set; }
        public DateTime EventDate   { get; set; } 
        public string Location      { get; set; }
        public string Venue         { get; set; }
        public float Cover          { get; set; }
        public List<Talent> Talent  { get; set; }
    }
    
    public struct Address
    {
        public Guid Id                  { get; set; }
        public string Address1          { get; set; }
        public string Address2          { get; set; }
        public string City              { get; set; }
        public US_State State           { get; set; }
        public List<string> PhoneNumber { get; set; }

    }

    public enum PhoneType
    {
        Main,
        Cell,
        Other
    }
    public struct PhoneNumber
    {
        public string Number { get; set; }
        public PhoneType Type { get; set; }

    }
    public class Venue
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Address VenueAddress         { get; set; }
        public List<PhoneNumber>  Phone     { get; set; }
        public List<Person> ContactPersons { get; set; }
    }

    public class Talent
    {
        public Guid Id { get; set; }
        public string Name { get; set; }    
        public Person Contact{ get; set; }
        public Address VenueAddress { get; set; }
        
    }

    //public enum ContactType { Primary, Secondary}
    //public enum Role { Manager, BarTender, BandLeader, Doorman, Unknown}
    public class Person
    {
        public enum ContactType { Primary, Secondary }
        public enum Role { Manager, BarTender, BandLeader, Doorman, Unknown }
        public ContactType Type { get; set; }
        public Role ContactRole { get; set; }
        public List<PhoneNumber> Phone { get; set; }
    }
}
