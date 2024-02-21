namespace Csharp_OOP_Class_Contructor
{
    class Student
    {
        public string name;
        public string surname;
        public int age;
        public string address;
        public string phone = "1234567996";

        public string GetFullName()
        {
            return name + " " + surname;
        }

        public string GetFullDatas()
        {
            string FullData = $"Name: {name},Surname: {surname}," +
                 $"Age: {age},Adress: {address},Phone: {phone}";

            return FullData;
        }








    }

}
