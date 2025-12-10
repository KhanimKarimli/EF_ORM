// Student,Group,Teacher classlarin yaradin. Propertylerinizi isteylerinize uygun doldura bilersiniz.
// EFcore istifade ederek db ve tabelerinizi yaradib,her biri ucun CRUD emeliyyatlarin Console Appiniz ile yazin

using EF_ORM.DAL;
using EF_ORM.Migrations;
using EF_ORM.Models;

Teacher teacher = new Teacher();
Group group = new Group();
Student student = new Student();

//teacher.Add(new Teacher()
//{
//	Name="Xanim",
//	Surname="Kerimli",
//	FatherName="Hezret"
//}
//);


//group.Add(new Group()
//{
//	Name="Backend",
//	TeacherId=1
//});



//student.Add(new Student()
//{
//	Name="Aytac",
//	Surname="Eliyeva",
//	FatherName="Aydin",
//	GroupId=1,
//});

//teacher.Add(new Teacher()
//{
//	Name="Shehriyar",
//	Surname="Kerimli",
//	FatherName="Elshad"
//});

//group.Add(new Group()
//{
//	Name="Frontend",
//	TeacherId=2
//});

//student.Add(new Student()
//{
//	Name="Aydin",
//	Surname="Eliyev",
//	FatherName="Eli",
//	GroupId=2,
//});


//teacher.Add(new Teacher()
//{
//	Name="Emin",
//	Surname="Imanverdiyev",
//	FatherName="Aydin"
//});

//group.Add(new Group()
//{
//	Name="Fullstack",
//	TeacherId=3
//});

//group.Add(new Group()
//{
//	Name="Abituriyent",
//	TeacherId=2
//});


//student.Add(new Student()
//{
//	Name="Nermin",
//	Surname="Ceferli",
//	FatherName="Akif",
//	GroupId=3,
//});

//student.Add(new Student()
//{
//	Name="Samir",
//	Surname="Ceferli",
//	FatherName="Davud",
//	GroupId=3,
//});

//teacher.GetAll();

//student.GetAll();

//group.GetAll();


//teacher.Update(4);
//student.Update(4);
//group.Update(4);

//teacher.Delete(4);
group.Delete(5);
student.Delete(5);