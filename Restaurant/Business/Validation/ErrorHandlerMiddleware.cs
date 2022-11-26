using Microsoft.AspNetCore.Http;
using System;
using System.Net;
using System.Text.Json;
using System.Web.Mvc;


namespace Business.Validation
{
    public class ErrorHandlerMiddleware
    {
        private readonly RequestDelegate _next;

        public ErrorHandlerMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (Exception error)
            {
                var response = context.Response;                

                switch (error)
                {
                    case RestaurantException e:
                        // custom application error
                        response.StatusCode = (int)HttpStatusCode.BadRequest;
                        break;
                        
                    default:
                        // unhandled error
                        response.StatusCode = (int)HttpStatusCode.InternalServerError;
                        break;
                }

                var result = JsonSerializer.Serialize(new { message = error?.Message });


                context.Response.ContentType = "application/json";

                await context.Response.WriteAsync(result);                
            }
        }
    }
}
