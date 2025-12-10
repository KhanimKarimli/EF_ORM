using EF_ORM.DAL;
using System;
using System.Collections.Generic;
using System.Text;

namespace EF_ORM.Models
{
    public class Group
    {
		public int Id { get; set; }
		public string Name { get; set; }
		public int TeacherId { get; set; }

		public void GetAll()
		{
			using (AppDataContext context = new AppDataContext())
			{
				var groups = context.Groups.ToList();
				foreach (var group in groups)
				{
					Console.WriteLine($"{group.Id}-{group.Name} - teacher: {group.TeacherId}");
				}
			}
		}

		public void Add(Group group)
		{
			using (AppDataContext context = new AppDataContext())
			{
				context.Groups.Add(group);
				context.SaveChanges();
			}
			Console.WriteLine("added");
		}



		public void Delete(int id)
		{
			using (AppDataContext context = new AppDataContext())
			{
				var groups = context.Groups.ToList();
				var group = groups.FirstOrDefault(t => t.Id == id);

				context.Groups.Remove(group);
				context.SaveChanges();
			}
		}
	}
}
