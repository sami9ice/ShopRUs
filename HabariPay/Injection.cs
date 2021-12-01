using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using NSwag;
using NSwag.Generation.Processors.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopRUsApi
{
    public static class Injection
    {
        public static void AddDocSwagger(this IServiceCollection service)
        {
            service.AddSwaggerDocument(x =>
            {


                x.GenerateXmlObjects = true;
                x.GenerateEnumMappingDescription = true;
                x.DocumentName = "ShopRus Apis";
                x.Title = "ShopRus";
                x.Description = "ShopRus Apis";
               

            });
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="app"></param>
        public static void UseDocSwagger(this IApplicationBuilder app)
        {
            app.UseOpenApi();
            app.UseSwaggerUi3(s =>
            {
                s.Path = "";
                s.DocumentTitle = "ShopRus Api";


            });
            app.UseReDoc(d =>
            {
                d.Path = "/redoc";

            });
        }
    }
}
