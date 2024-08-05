using DemoLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary.DataAccess
{
	public class DemoDataAccess : IDataAccess
	{
		private List<PersonModel> people = new List<PersonModel>();
		public DemoDataAccess()
		{
			people.Add(new PersonModel { Id = 1, FirstName = "Taiwo", LastName = "Sadiq" });
			people.Add(new PersonModel { Id = 2, FirstName = "Tim", LastName = "Corey" });
		}

		public List<PersonModel> GetPeople()
		{
			return people;
		}

		public PersonModel InsertPerson(string firstName, string lastName)
		{
			PersonModel p = new PersonModel { FirstName = firstName, LastName = lastName };
			p.Id = people.Max(x => x.Id) + 1;
			people.Add(p);
			return p;
		}
	}
}
