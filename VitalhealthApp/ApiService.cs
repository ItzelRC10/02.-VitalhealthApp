using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net.Http;
using Newtonsoft.Json.Serialization;
using Microsoft.Extensions.Configuration;
using Microsoft.Maui.Controls;

namespace VitalhealthApp
{
    public class ApiService
    {
        private readonly HttpClient _httpClient;
        private readonly string _apiUrl;

        public ApiService(IConfiguration configuracion)
        {
            _httpClient = new HttpClient();
            _apiUrl = configuracion.GetValue<string>("ApiSettings:ApiUrl"); // Leer URL desde appsettings.json
            Console.WriteLine($"API URL: {_apiUrl}");
        }

        public async Task<bool> EnviarSMSVerificacion(string telefono, string mensaje)
        {
            bool Regresa = false;
            try
            {
                var url = $"http://192.168.0.7:5158/api/Autenticacion/send-verification";

                var payload = new
                {
                    numeroTelefono = telefono,
                    mensaje = mensaje
                };

                var content = new StringContent(JsonConvert.SerializeObject(payload), Encoding.UTF8, "application/json");

                var response = await _httpClient.PostAsync(url, content);

                try
                {
                    if (response.IsSuccessStatusCode)
                    {
                        Regresa = true;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Regresa = false;
            }
            return Regresa;
        }
    }
}
