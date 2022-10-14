using System;

namespace Covid
{
    public enum VaccineName{Default,Covidshield,Covaccine}
    public class Vacine
    {
        private static int s_vaccineID=100;
        public string VaccineID{get;set;}
        public VaccineName VaccineName { get; set; }
        public int NumberOfDoses { get; set; }
        public Vacine(VaccineName vaccineName,int count)
        {
            VaccineName=vaccineName;
            NumberOfDoses=count;
        }
    }
}
