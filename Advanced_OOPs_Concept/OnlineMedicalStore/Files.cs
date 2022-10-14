using System;
using System.IO;
namespace OnlineMedicalStore
{
    public static class Files
    {
        public static void CreateFiles()
        {
            if(!Directory.Exists("MedicalShop"))
            {
                Directory.CreateDirectory("MedicalShop");
                System.Console.WriteLine("Folder created");
            }
            if(!File.Exists("MedicalShop/UserDetails.csv"))
            {
                File.Create("MedicalShop/UserDetails.csv");
                System.Console.WriteLine("File Created");
            }
            if(!File.Exists("MedicalShop/MedicineDetails.csv"))
            {
                File.Create("MedicalShop/MedicineDetails.csv");
                System.Console.WriteLine("File Created");
            }
            if(!File.Exists("MedicalShop/OrderDetails.csv"))
            {
                File.Create("MedicalShop/OrderDetails.csv");
                System.Console.WriteLine("File Created");
            }
        }
        public static void ReadFiles()
        {
            string[] users=File.ReadAllLines("MedicalShop/UserDetails.csv");
            foreach(string data in users)
            {
                UserDetails user =new UserDetails(data);
                Operations.userList.AddElement(user);
            }
            string[] medicines=File.ReadAllLines("MedicalShop/MedicineDetails.csv");
            foreach(string data1 in medicines)
            {
                MedicineDetails medicine=new MedicineDetails(data1);
                Operations.medicineList.AddElement(medicine);
            }
            string[] orders=File.ReadAllLines("MedicalShop/OrderDetails.csv");
            foreach(string data2 in orders)
            {
                OrderDetails order=new OrderDetails(data2);
                Operations.orderList.AddElement(order);
            }
        }
        public static void WriteFiles()
        {
            string[] userDetails=new string[Operations.userList.Count];
            for(int i=0;i<Operations.userList.Count;i++)
            {
                userDetails[i]=Operations.userList[i].UserID+","+Operations.userList[i].UserName+","+Operations.userList[i].Age+","+Operations.userList[i].City+","+Operations.userList[i].PhoneNumber+","+Operations.userList[i].Balance;
            }
            File.WriteAllLines("MedicalShop/UserDetails.csv",userDetails);

            string[] medicineDetails=new string[Operations.medicineList.Count];
            for(int i=0;i<Operations.medicineList.Count;i++)
            {
              medicineDetails[i]=Operations.medicineList[i].MedicineID+","+Operations.medicineList[i].MedicineName+","+Operations.medicineList[i].AvailableCount+","+Operations.medicineList[i].Price+","+Operations.medicineList[i].DateOfExpiry.ToShortDateString();
            }
            File.WriteAllLines("MedicalShop/MedicineDetails.csv",medicineDetails);

            string[] orderDetails=new string[Operations.orderList.Count];
            for(int i=0;i<Operations.orderList.Count;i++)
            {
                orderDetails[i]=Operations.orderList[i].OrderID+","+Operations.orderList[i].UserID+","+Operations.orderList[i].MedicineID+","+Operations.orderList[i].MedicineCount+","+Operations.orderList[i].TotalPrice+","+Operations.orderList[i].OrderDate.ToShortDateString()+","+Operations.orderList[i].OrderStatus;
            }
            File.WriteAllLines("MedicalShop/OrderDetails.csv",orderDetails);
        }
    }
}
