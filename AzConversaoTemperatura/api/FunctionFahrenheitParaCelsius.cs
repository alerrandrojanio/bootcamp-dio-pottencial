using System.Net;
using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace CoversaoTemperatura
{
    public class FunctionFahrenheitParaCelsius
    {
        private readonly ILogger<FunctionFahrenheitParaCelsius> _logger;

        public FunctionFahrenheitParaCelsius(ILogger<FunctionFahrenheitParaCelsius> log)
        {
            _logger = log;
        }

        [FunctionName("ConverterFahrenheitParaCelsius")]
        //[OpenApiOperation(operationId: "Run", Tags: new[] { "Conversão" })]
        //[OpenApiParameter(name: "fahrenheit", In = ParameterLocation.Path, Required = true, Type = typeof(double), Description = "O valor em **Fahrenheit")]
        //[OpenApiResponseWithBody(StatusCodeResult: HttpStatusCode.OK, contentType: "text/plain", BodyType: typeof(string), Description = "Retorna o valor em Celsius")]
        public async Task<IActionResult> Run(
            [HttpTrigger(
                AuthorizationLevel.Anonymous,
                "get",
                "post",
                Route = "ConverterFahrenheitParaCelsius/{fahrenheit}"
            )]
                HttpRequest req,
            double fahrenheit
        )
        {
            _logger.LogInformation($"Parâmetro recebido: {fahrenheit}", fahrenheit);

            var valorEmCelsius = (fahrenheit - 32) * 5 / 9;

            string responseMessage =
                $"O valor em Fahrenheit: {fahrenheit} em Celsius é: {valorEmCelsius}";

            _logger.LogInformation($"Conversão efetuada. Resultado: {valorEmCelsius}");

            return new OkObjectResult(responseMessage);
        }
    }
}
