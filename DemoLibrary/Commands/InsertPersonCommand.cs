using DemoLibrary.Model;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary.Commands
{
	public record InsertPersonCommand(string FirstName, string Lastname):IRequest<PersonModel>;
	
}
