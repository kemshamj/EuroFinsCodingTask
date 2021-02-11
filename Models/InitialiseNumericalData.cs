using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EuroFinsCodingTask.Models
{
	public class InitialiseNumericalData
	{
		[Display(Name="Starting Number")]
		public int StartNumber { get; set; }

		[Display(Name = "Ending Number")]
		public int EndNumber { get; set; }
	}
}
