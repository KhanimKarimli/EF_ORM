// Student,Group,Teacher classlarin yaradin. Propertylerinizi isteylerinize uygun doldura bilersiniz.
// EFcore istifade ederek db ve tabelerinizi yaradib,her biri ucun CRUD emeliyyatlarin Console Appiniz ile yazin

using EF_ORM.DAL;
using EF_ORM.Migrations;
using EF_ORM.Models;

Teacher teacher = new Teacher();
Group group = new Group();
Student student = new Student();

teacher.Add(new Teacher()
{
	Name="Xanim",
	Surname="Kerimli",
	FatherName="Hezret"
}
);




group.Add(new Group()
{
	Name="Backend",
	TeacherId=1
});



student.Add(new Student()
{
	Name="Aytac",
	Surname="Eliyeva",
	FatherName="Aydin",
	GroupId=1,
});




