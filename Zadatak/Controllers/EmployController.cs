using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using System.Linq;
using System.Collections.Generic;
using System;
using System.Net.Http;
using System.Drawing;
using System.IO;
using System.Drawing.Imaging;
using Zadatak.Models;
using SkiaSharp;
namespace Zadatak.Controllers
{
    public class EmployController : Controller
    {

        private readonly TimeEntryServices _timeEntryService;
        private readonly string _apiKey;

        public EmployController(IConfiguration configuration)
        {
            _timeEntryService = new TimeEntryServices();
            _apiKey = configuration["ApiSettings:ApiKey"];
        }
        public async Task<IActionResult> Index()
        {
            var timeEntries = await _timeEntryService.GetEmployeeTimeEntries(_apiKey);
            return View(timeEntries);
        }


        public async Task<IActionResult> GeneratePieChart()
        {
            var entries = await _timeEntryService.GetEmployeeTimeEntries(_apiKey);

            var pngBytes = CreatePieChart(entries);
            return File(pngBytes, "image/png");
        }

        public byte[] CreatePieChart(List<EmployeeTimeEntry> entries)
        {
            using (var surface = SKSurface.Create(new SKImageInfo(600, 400)))
            {
                var canvas = surface.Canvas;
                canvas.Clear(SKColors.White); // Čistimo površinu

                // Ukupno vreme rada
                float total = (float)entries.Sum(e => e.TotalTimeWorked);
                float startAngle = 0;

                // Definišemo boje za grafikon
                var colors = new[] { SKColors.Red, SKColors.Blue, SKColors.Green, SKColors.Yellow, SKColors.Orange };

                for (int i = 0; i < entries.Count; i++)
                {
                    float sweepAngle = (float)(entries[i].TotalTimeWorked / total) * 360;
                    using (var paint = new SKPaint { Color = colors[i % colors.Length], IsAntialias = true })
                    {
                        // Istražujemo deo za pie grafikon
                        canvas.DrawArc(new SKRect(50, 50, 350, 350), startAngle, sweepAngle, true, paint);

                        // Izračunavamo procenat
                        float percentage = ((float)entries[i].TotalTimeWorked / total) * 100;

                        // Računamo sredinu gde ćemo staviti tekst
                        float midAngle = startAngle + (sweepAngle / 2);
                        float textX = 200 + (150 * (float)Math.Cos(midAngle * Math.PI / 180)); // 150 je radijus
                        float textY = 200 + (150 * (float)Math.Sin(midAngle * Math.PI / 180)); // 150 je radijus

                        // Koristimo SKPaint za stilizovanje teksta
                        using (var textPaint = new SKPaint { Color = SKColors.Black, IsAntialias = true, TextSize = 20 })
                        {
                            // Ispisujemo procenat kao tekst
                            canvas.DrawText($"{percentage:0.0}%", textX, textY, textPaint);
                        }
                    }

                    startAngle += sweepAngle; // Ažuriramo startni ugao
                }

                // Spremamo sliku u memoriji
                using (var stream = new MemoryStream())
                {
                    var image = surface.Snapshot();
                    var pngImage = image.Encode(SKEncodedImageFormat.Png, 100); // Kodiranje slike
                    pngImage.SaveTo(stream); // Čuvanje PNG u MemoryStream
                    return stream.ToArray(); // Vraćamo bajt niz
                }
            }
        }
    }
}
