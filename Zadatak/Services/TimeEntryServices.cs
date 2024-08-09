using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Zadatak.Models;
using System.Linq;
using System;
public class TimeEntryServices
{
    private readonly HttpClient _httpClient;

    public TimeEntryServices()
    {
        _httpClient = new HttpClient();
    }

    public async Task<List<EmployeeTimeEntry>> GetEmployeeTimeEntries(string apiKey)
    {
        var url = $"https://rc-vault-fap-live-1.azurewebsites.net/api/gettimeentries?code={apiKey}";
        var response = await _httpClient.GetStringAsync(url);

        var entries = JsonConvert.DeserializeObject<List<Employees>>(response);

        var summarizedEntries = entries
            .GroupBy(e => e.EmployeeName)
            .Select(g => new EmployeeTimeEntry()
            {
                EmployeeName = String.IsNullOrEmpty(g.Key) ? "nepoznat" : g.Key,
                TotalTimeWorked = Math.Round(g.Sum(x => (x.EndTimeUtc - x.StarTimeUtc).TotalHours < 0 ? 0 : (x.EndTimeUtc - x.StarTimeUtc).TotalHours))
            })
            .OrderByDescending(entry => entry.TotalTimeWorked)
            .ToList();

        return summarizedEntries;
    }
}