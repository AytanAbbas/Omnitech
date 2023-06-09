﻿using Microsoft.AspNetCore.Mvc;
using Omnitech.Service;
using System.Threading.Tasks;
using System;
using DocumentFormat.OpenXml.Wordprocessing;
using Omnitech.Dtos;
using Omnitech.Models;
using System.Collections.Generic;
using System.Linq;
using DocumentFormat.OpenXml.Drawing.Charts;
using DocumentFormat.OpenXml.EMMA;
using OpenXmlPowerTools;

namespace Omnitech.Controllers
{
    public class ProblemicSalesLogsController : Controller
    {
        private readonly PrintService _printService;
        private readonly PrintTimerService _printTimerService;
        private readonly Tps575UrlService _tps575UrlService;

        public ProblemicSalesLogsController(PrintService printService, PrintTimerService printTimerService, Tps575UrlService tps575UrlService)
        {
            _printService = printService;
            _printTimerService = printTimerService;
            _tps575UrlService = tps575UrlService;
        }

        public async Task<IActionResult> Index()
        {

            List<SalesLogs> salesLogs = await _printService.GetProblemicSalesLogsAsync();
                return View(salesLogs);
        }


        public async Task<IActionResult> Print(int recno)
        {
            try
            {
                await _printService.PrintProblemicSalesLogsByRecnoAsync(recno);

                return Json(new { responseText = "SUCCESS", status = 200 });
            }

            catch (Exception exp)
            {
                ViewBag.Message = exp.Message;

                return Json(new { responseText = exp.Message, status = 500 });
            }
        }

    }
}
