using System;

namespace OnlineMedicalStore
{
    public class MedicineDetails
    {
        private static int s_medicineID=100;
        public string MedicineID { get; set; }
        public string MedicineName { get; set; }
        public int AvailableCount { get; set; }
        public int Price { get; set; }
        public DateTime DateOfExpiry { get; set; }
        public MedicineDetails(string medicineName,int count,int price,DateTime dateOfExpiry)
        {
            s_medicineID++;
            MedicineID="MD"+s_medicineID;
            MedicineName=medicineName;
            AvailableCount=count;
            Price=price;
            DateOfExpiry=dateOfExpiry;
        }
        public MedicineDetails(string data)
        {
            string[] values=data.Split(',');
            s_medicineID=int.Parse(values[0].Remove(0,2));
            MedicineID=values[0];
            MedicineName=values[1];
            AvailableCount=int.Parse(values[2]);
            Price=int.Parse(values[3]);
            DateOfExpiry=DateTime.ParseExact(values[4],"dd/MM/yyyy",null);
        }
    }
}
