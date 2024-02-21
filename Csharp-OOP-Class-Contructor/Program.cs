
//string name1 = "Emiraslan";
//string surname1 = "Miriyev";
//int age1 = 33;

//string name2 = "Sirac";
//string surname2 = "Memmedov";
//int age2 = 22;

//string name3 = "Elmir";
//string surname3 = "Qafarzade";
//int age3 = 21;

//Console.WriteLine($"{name2} {surname2} {age2}");


//var stu1 = new
//{
//    name = "Emiraslan",
//    surname = "Miriyev",
//    age = 33
//};


//var stu2 = new
//{
//    name = "Sirac",
//    surname = "Memmedov",
//    age = 22
//};


//Console.WriteLine(stu1);
//Console.WriteLine(stu1.name+" "+ stu1.surname+" "+stu1.age);


using Csharp_OOP_Class_Contructor;

Student stu1 = new Student();

stu1.name = "Ismayil";
stu1.surname = "Ceferli";
stu1.age = 24;
stu1.address = "Ehmedli";

Student stu2 = new Student();
stu2.name = "Test";
stu2.surname = "Testov";
stu2.age = 70;
stu2.address = "Xetai";
stu2.phone = "123456789";

//string fullName = stu2.name + " " + stu2.surname;
 
//Console.WriteLine(fullName);

Student stu3 = new Student()
{
    name = "Sirac",
    surname = "Memmedov",
    age = 22,
};

//Console.WriteLine(stu3.phone);

//Console.WriteLine(stu3.GetFullName());

//Console.WriteLine(stu2.GetFullName());

//var result = stu2.GetFullDatas();

//Console.WriteLine(result);


//Student[] students = { stu1, stu2, stu3 };

//void ShowAll(Student[] datas)
//{

//    foreach (var stu in students)
//    {
//        Console.WriteLine(stu.GetFullDatas());
//    }
//}
//ShowAll(students);

Student[] students = {stu1, stu2, stu3};

//Student GetByAge(Student[] datas ,int age)
//{
//    Student foundStudent = new();

//    foreach (var item in datas)
//    {
//        if(item.age == age)
//        {
//            foundStudent = item;
//            break;
//        }
//    }
//    return foundStudent;
//}


//int a = 5;

////Console.WriteLine(a == 5 ? a : "deyil");

//var result = a == 5 ? a.ToString() : "deyil";

//Console.WriteLine(5);

//Student GetByAge(Student[] datas, int age)
//{
//    return datas.FirstOrDefault(m => m.age == age);
//}
//var result = GetByAge(students, 24);
//if(result != null)
//{
//    Console.WriteLine(result.GetFullDatas());
//}
//else
//{
//    Console.WriteLine("Data notfound");
//}

Book book = new Book("Elmir");

Console.WriteLine(book.name);

//Console.WriteLine(book.name+ " "+book.author);