using System;
using System.Web;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EuroFinsCodingTask.Models;
using Microsoft.AspNetCore.Hosting; 

namespace EuroFinsCodingTask.Service
{
	public class DataTransformationService
	{
		public List<String> Getdatatransformation (Int32 startdata = 1, Int32 endData =100)
		{
			InitialiseNumericalData data = new InitialiseNumericalData { StartNumber = startdata, EndNumber = endData };

			if (data.StartNumber == 0 || data.EndNumber <= 1 || data.StartNumber> data.EndNumber)
			{
				return null;
			}
			else
				startdata = 1;
			return GetMultiplers(data.StartNumber, data.EndNumber);

		}

		public List<String> GetMultiplers(Int32 StartingNumber, Int32 EndingNumber)
		{
			List<String> TransformedResults = new List<String>();
			
			for (int i = StartingNumber; i <= EndingNumber; i++)
			{
				if (i % 3 == 0 && i % 5 == 0)
				{
					TransformedResults.Add("EuroFins");
				}
				else if (i % 3 == 0)
				{
					TransformedResults.Add("Three");
				}
				else if (i % 5 == 0)
				{
					TransformedResults.Add("Five");
				}
				else
				{
					TransformedResults.Add(i.ToString());
				}
			}
			return TransformedResults;
		}
	}
}
