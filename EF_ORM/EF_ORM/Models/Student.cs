using EF_ORM.DAL;
using System;
using System.Collections.Generic;
using System.Text;

namespace EF_ORM.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
		public string FatherName { get; set; }
        public int GroupId { get; set; }

		public void GetAll()
		{
			using (AppDataContext context = new AppDataContext())
			{
				var students = context.Students.ToList();
				foreach (var student in students)
				{
					Console.WriteLine($"{student.Id}-{student.Name} {student.FatherName} {student.Surname}- group: {student.GroupId}");
				}
			}
		}

		public void Delete(int id)
		{
			using (AppDataContext context = new AppDataContext())
			{
				var students = context.Students.ToList();
				var student = students.FirstOrDefault(t => t.Id == id);

				context.Students.Remove(student);
				context.SaveChanges();
			}
		}

		public void Add(Student student)
		{
			using (AppDataContext context = new AppDataContext())
			{
				context.Students.Add(student);
				context.SaveChanges();
			}
			Console.WriteLine("added");
		}

		public void Update(int id)
		{
			using (AppDataContext context = new AppDataContext())
			{
				var students = context.Students.ToList();
				var student = students.FirstOrDefault(t => t.Id == id);

				if (student != null)
				{
					Console.WriteLine("Yeni qrup adi daxil edin");
					string newname = Console.ReadLine();
					student.Name=newname;
					context.SaveChanges();
				}
				else
					Console.WriteLine("Tapilmadi");
			}
		}
	}
}
