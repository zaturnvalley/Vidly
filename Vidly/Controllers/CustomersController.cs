using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
	public class CustomersController
	{
		public ViewResult Index()
		{
			var customers = GetCustomers();

			return View(customers);
		}

		private ViewResult View(IEnumerable<Customer> customers)
		{
			throw new NotImplementedException();
		}

		public ActionResult Details(int id)
		{
			var customer = GetCustomers().SingleOrDefault(c => c.Id == id);

			if (customer == null)
				return HttpNotFound();
			return View(customer);
		}

		private ActionResult HttpNotFound()
		{
			throw new NotImplementedException();
		}

		private ActionResult View(Customer customer)
		{
			throw new NotImplementedException();
		}

		private IEnumerable<Customer>GetCustomers()
		{
			return new List<Customer>
			{
				new Customer { Id = 1, Name = "Billy Jean"},
				new Customer { Id = 2, Name = "Dirty Diana"}
			};
		}
	}
}