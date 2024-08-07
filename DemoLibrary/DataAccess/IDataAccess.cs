﻿using DemoLibrary.Model;

namespace DemoLibrary.DataAccess
{
	public interface IDataAccess
	{
		List<PersonModel> GetPeople();
		PersonModel InsertPerson(string firstName, string lastName);
	}
}