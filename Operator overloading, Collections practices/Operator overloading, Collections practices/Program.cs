


using Operator_overloading__Collections_practices.Models;
using System.Collections;
using System.Xml;


#region Operator overloading


//Employee employee1 = new Employee();

//employee1.Name = "Pervin";
//employee1.Age = 25;
//employee1.Id = 1;


//Employee employee2 = new Employee();

//employee2.Name = "Cavid";
//employee2.Age = 22;
//employee2.Id = 2;


//var result = employee1 > employee2;

//Console.WriteLine(result);

#endregion


//Hashtable datas= new Hashtable();

//datas.Add(1, "Cavid");

//datas.Add(2, "Pervin");

//datas.Add(3, "Mirze");

//foreach (DictionaryEntry item in datas)
//{
//	Console.WriteLine(item.Key + "-" + item.Value);
//	//if ((int)item.Key ==1)
//	//{
//	//	Console.WriteLine(item.Value);
//	//}
//}



//SortedList datas = new SortedList();

//datas.Add(1, "Cavid");

//datas.Add(6, "Pervin");

//datas.Add(3, "Mirze");

//foreach (DictionaryEntry item in datas)
//{
//	Console.WriteLine(item.Key + "-" + item.Value);
//}




//ArrayList datas = new ArrayList();

//datas.Add("Salam");

//datas.Add(1);

//datas.Add(true);

//foreach (var item in datas)
//{
//    Console.WriteLine(item);
//}



//List<int> datas = new List<int>();

//datas.Add(10);

//datas.Add(40);

//datas.Add(30);

//datas.Add(20);

//datas.Sort();

//datas.Reverse();

//Console.WriteLine(datas[0]);

//datas.RemoveAt(0);

//datas.Clear();

//datas.RemoveAll(m => m > 20);

//var res = datas.Contains(20);

//Console.WriteLine(res);

//foreach (var item in datas)
//{
//    Console.WriteLine(item);
//}




//List<string> names = new List<string>() { "Cavid","Cavid", "Mirze", "Aqshin", "Elcan" };

//foreach (var item in names)
//{
//	if (item == "Cavid")
//	{
//		Console.WriteLine(item);
//	}
//}



//for (int i = 0; i < names.Count; i++)
//{
//    Console.WriteLine(names[i]);
//}


//var result = names.Find(m => m == "Cavid");

//Console.WriteLine(result);


//var result = names.FindAll(m => m == "Cavid");

//foreach (var item in result)
//{
//    Console.WriteLine(item);
//}


//var result = names.FindAll(m => m == "Cavid").Count;

//Console.WriteLine(result);



//List<int> numbers = new List<int>() { 1, 2, 3, 4 };

//Console.WriteLine(numbers.FindAll(m => m % 2 == 0).Sum(m => m));




//List<Student> students = new();

//Student stu1 = new Student()
//{
//    Id=1,
//    FullName= "Roya Meherremova",
//    Age= 26,
//    Address="Sumqayit"
//};

//Student stu2 = new Student()
//{
//    Id = 2,
//    FullName = "Farid Abdullayev ",
//    Age = 17,
//    Address = "Nesimi"
//};
//Student stu3 = new Student()
//{
//    Id = 3,
//    FullName = "Shaiq Kazimov",
//    Age = 26,
//    Address = "Sedmoy"
//};

//Student stu4 = new Student()
//{
//    Id = 4,
//    FullName = "Elcan Qurbanov",
//    Age = 19,
//    Address = "New Balaxani"
//};

//Student stu5 = new Student()
//{
//    Id = 5,
//    FullName = "Konul Ibrahimova",
//    Age = 26,
//    Address = "Neftciler"
//};

//students.Add(stu1);
//students.Add(stu2);
//students.Add(stu3);
//students.Add(stu4);
//students.Add(stu5);

//foreach (var item in students)
//{
//    Console.WriteLine(item.FullName);
//}





//Student stu2 = new Student()
//{
//    Id = 2,
//    FullName = "Farid Abdullayev ",
//    Age = 17,
//    Address = "Nesimi"
//};

//AddStudent(stu2);


//Console.WriteLine("Add full name");

//string fullname =Console.ReadLine();

//Console.WriteLine("Add address");

//string address=Console.ReadLine();

//Console.WriteLine("Add age");

//int age =Convert.ToInt32(Console.ReadLine());


//Student student = new Student()
//{
//    Id = 1,
//    FullName = fullname,
//    Address=address,
//    Age= age
//};

//AddStudent(student);

//static void AddStudent(Student student)
//{
//    List<Student> students = new();

//    students.Add(student);

//    foreach (var item in students)
//    {
//        Console.WriteLine(item.FullName + "-" + item.Address);
//    }
//}


//Console.WriteLine(GetStudentCount());
//static int GetStudentCount()
//{
//    var students= GetAllStudents();

//    return students.Count;
//}



//Console.WriteLine(GetSameNameCount());
//static int GetSameNameCount()
//{
//    string text = "Konul";

//    var result = GetAllStudents();

//    return result.FindAll(m => m.FullName.Contains(text)).Count;
//}

//static List<Student> GetAllStudents()
//{
//    List<Student> students = new();

//    Student stu1 = new Student()
//    {
//        Id = 1,
//        FullName = "Roya Meherremova",
//        Age = 26,
//        Address = "Sumqayit"
//    };

//    Student stu2 = new Student()
//    {
//        Id = 2,
//        FullName = "Farid Abdullayev",
//        Age = 17,
//        Address = "Nesimi"
//    };
//    Student stu3 = new Student()
//    {
//        Id = 3,
//        FullName = "Shaiq Kazimov",
//        Age = 26,
//        Address = "Sedmoy"
//    };

//    Student stu4 = new Student()
//    {
//        Id = 4,
//        FullName = "Elcan Qurbanov",
//        Age = 19,
//        Address = "New Balaxani"
//    };

//    Student stu5 = new Student()
//    {
//        Id = 5,
//        FullName = "Konul Ibrahimova",
//        Age = 26,
//        Address = "Neftciler"
//    };

//    Student stu6 = new Student()
//    {
//        Id = 6,
//        FullName = "Konul Eliyeva",
//        Age = 26,
//        Address = "Neftciler"
//    };

//    students.Add(stu1);
//    students.Add(stu2);
//    students.Add(stu3);
//    students.Add(stu4);
//    students.Add(stu5);
//    students.Add(stu6);

//    return students;
//}



//SortedList<int,string> datas= new SortedList<int,string>();

//datas.Add(2, "Cavid");

//datas.Add(1, "Pervin");


//foreach (KeyValuePair<int,string> item in datas)
//{
//    Console.WriteLine(item.Key + "-" + item.Value);
//}



//HashSet<int> datas= new HashSet<int>();

//datas.Add(1);
//datas.Add(2);
//datas.Add(1);

//foreach (var item in datas)
//{
//    Console.WriteLine(item);
//}


//Stack<string> stack = new Stack<string>();

//stack.Push("Salam");
//stack.Push("Sagol");
//stack.Push("XXX");


//foreach (var item in stack)
//{
//    Console.WriteLine(item);
//}




//Queue<string> queue= new Queue<string>();

//queue.Enqueue("Salam");
//queue.Enqueue("Sagol");
//queue.Enqueue("XXX");

//foreach (var item in queue)
//{
//    Console.WriteLine(item);
//}


Dictionary<string, string> datas= new Dictionary<string, string>();

datas.Add("Admin", "Mirze");

datas.Add("Member", "Hacker");

datas.Add("SuperAdmin", "Anar");

foreach (var item in datas)
{
	if (item.Key == "Admin")
	{
		Console.WriteLine(item);
	}
}
