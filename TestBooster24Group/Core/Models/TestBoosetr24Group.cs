using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace TestBooster24GroupApp.Core.Models
{
    public enum TestStatus
    {
        NotKnown = 0,
        Positive = 1,
        Negative = 2 

    }
    public class TestBoosetr24Group
    {
        public int Id { get; set; }
        public string Token { get; set; }
        public string Name { get; set; }  
        public int GroupOwnerId { get; set; }
        public DateTime CreationDate { get; set; }       
        public string Address { get; set; }
        public byte CityId { get; set; }
        public IEnumerable<City> Cities { get; set; }
        public ICollection<Patient> Patients { get; set; }
        public int  TestStatus { get; set; }
        public int Doctor { get; set; }
        public TestBoosetr24Group()
        {
            Patients = new Collection<Patient>();
            
        }
    }
}