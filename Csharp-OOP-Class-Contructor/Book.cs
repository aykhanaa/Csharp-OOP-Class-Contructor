namespace Csharp_OOP_Class_Contructor
{
    internal class Book
    {
        public string name;
        public string author;

       public Book()
        {

        } 

        public Book(string name)
        {
            Console.WriteLine("Xaker bey");
        }

        public Book(string name,string author)
        {
            this.name = name;
            this.author = author;
        }
   





    }
}
