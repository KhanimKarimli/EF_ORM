using EF_ORM.DAL;
using System;
using System.Collections.Generic;
using System.Text;

namespace EF_ORM.Models
{
	public class Teacher
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Surname { get; set; }
		public string FatherName { get; set; }


		public void GetAll()
		{
			using (AppDataContext context = new AppDataContext())
			{
				var teachers = context.Teachers.ToList();
				foreach (var teacher in teachers)
				{
					Console.WriteLine($"{teacher.Id}-{teacher.Name} {teacher.FatherName} {teacher.Surname}");
				}
			}
		}

		public void Add(Teacher teacher)
		{
			using (AppDataContext context = new AppDataContext())
			{
				context.Teachers.Add(teacher);
				context.SaveChanges();
			}
			Console.WriteLine("added");
		}


		public void Delete(int id)
		{
			using (AppDataContext context = new AppDataContext())
			{
				var teachers = context.Teachers.ToList();
				var teacher=teachers.FirstOrDefault(t => t.Id == id);

				context.Teachers.Remove(teacher);
				context.SaveChanges();
			}
		}

		public void Update(int id)
		{
			using (AppDataContext context = new AppDataContext())
			{
				var teachers = context.Teachers.ToList();
				var teacher = teachers.FirstOrDefault(t => t.Id == id);
	
				if (teacher != null)
				{
					Console.WriteLine("Yeni qrup adi daxil edin");
					string newname = Console.ReadLine();
					teacher.Name=newname;
					context.SaveChanges();
				}
				else
					Console.WriteLine("Tapilmadi");
			}
		}
	}
}
