namespace FormApp;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;


    public class ApiForm
    {
    private readonly HttpClient _httpClient;

    public ApiForm()
    {
        _httpClient = new HttpClient();
        _httpClient.BaseAddress = new Uri("https://insw-dev.ilcs.co.id/n/");
        _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
    }

    public async Task<string> GetCountryCode(string country)
    {
        var response = await _httpClient.GetAsync($"negara?ur_negara={country}");
        if (response.IsSuccessStatusCode)
        {
            var result = await response.Content.ReadAsStringAsync();
            // Parse hasil JSON jika perlu
            return result;
        }
        return null;
    }

    public async Task<string> GetPortCode(string countryCode, string port)
    {
        var response = await _httpClient.GetAsync($"pelabuhan?kd_negara={countryCode}&ur_pelabuhan={port}");
        if (response.IsSuccessStatusCode)
        {
            var result = await response.Content.ReadAsStringAsync();
            // Parse hasil JSON jika perlu
            return result;
        }
        return null;
    }

    public async Task<string> GetProductCode(string hsCode)
    {
        var response = await _httpClient.GetAsync($"barang?hs_code={hsCode}");
        if (response.IsSuccessStatusCode)
        {
            var result = await response.Content.ReadAsStringAsync();
            // Parse hasil JSON jika perlu
            return result;
        }
        return null;
    }

    public async Task<decimal> GetTariffRate(string hsCode)
    {
        var response = await _httpClient.GetAsync($"tarif?hs_code={hsCode}");
        if (response.IsSuccessStatusCode)
        {
            var result = await response.Content.ReadAsStringAsync();
            // Parse hasil JSON dan ambil tarif Bea Masuk
            // Misalnya, jika hasil JSON adalah {"tarif_bm": 0.1}
            // Anda bisa mengambil tarif_bm sebagai decimal
            return decimal.Parse(result);
        }
        return 0;
    }

    

    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            Application.EnableVisualStyles();
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
    }
