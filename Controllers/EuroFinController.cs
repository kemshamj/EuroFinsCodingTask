using EuroFinsCodingTask.Models;
using EuroFinsCodingTask.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;

namespace EuroFinsCodingTask.Controllers
{

	public class EuroFinController : Controller
	{

		private readonly ILogger<EuroFinController> _logger;
		private DataTransformationService _transformationService;

		public EuroFinController(ILogger<EuroFinController> logger, DataTransformationService dataTransformation )
		{
			_logger = logger;
			_transformationService = dataTransformation;

		}


		[Route("/Digitalise")]
		public IActionResult Digitalise()
		{
			return View(_transformationService.Getdatatransformation());
		}

		[HttpPost]
		public List<String> GetMagicData(InitialiseNumericalData numericalData)
		{
			var magicNumbers = new DataTransformationService();
			return magicNumbers.Getdatatransformation();
			
		}



	}
}
