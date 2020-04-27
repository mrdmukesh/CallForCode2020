
using System;
using System.Collections.Generic;

namespace TestBooster24GroupApp.Core.Dto
{
    public class TestBoosetr24GroupDto
    {
        public int Id { get; set; }
        public string Token { get; set; }
        public string Name { get; set; }
        public int GroupOwnerId { get; set; }
        public DateTime CreationDate { get; set; }
        public string Address { get; set; }
        public byte CityId { get; set; }
        public CityDto Cities { get; set; }
        public ICollection<PatientDto> Patients { get; set; }
        public int TestStatus { get; set; }
        public int DoctorId { get; set; }
        public DoctorDto Doctor { get; set; }
    }
}