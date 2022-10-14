using System;

namespace Covid
{
    
    
    public class Vaccination
    {
        private static int s_vaccinationID=1000;
        public string VaccinationID { get; set; }
        public string RegistrationNumber { get; set; }
        public string VaccineID { get; set; }
        public int DoseNumber { get; set; }
        public DateTime VaccineDate { get; set; }
        public Vaccination(string registrationNumber,string vaccineId,int doseNumber,DateTime vaccineDate)
        {
          s_vaccinationID++;
          VaccinationID="VID"+s_vaccinationID;
          RegistrationNumber=registrationNumber;
          VaccineID=vaccineId;
          DoseNumber=doseNumber;
          VaccineDate=vaccineDate;
        }
    }
}
