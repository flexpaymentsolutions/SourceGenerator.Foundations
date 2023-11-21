﻿using Microsoft.CodeAnalysis;
using Newtonsoft.Json;
using SGF;
using SGF.Diagnostics;
using System;

namespace ConsoleApp.SourceGenerator
{
    [Generator]
    internal class ConsoleAppSourceGenerator : IncrementalGenerator
    {
        public class Payload
        {
            public string? Name { get; set; }
            public string? Version { get; set; }
        }

        public ConsoleAppSourceGenerator() : base("ConsoleApp")
        { }

        protected override void OnInitialize(SgfInitializationContext context)
        {
            Payload payload = new()
            {
                Name = "Newtonsoft.Json",
                Version = "13.0.1"
            };

            Logger.Information("This is the output from the sournce generator assembly ConsoleApp.SourceGenerator");
            Logger.Information("This generator references Newtonsoft.Json and it can just be referenced without any other boilerplate");
            Logger.Information(JsonConvert.SerializeObject(payload));
            Logger.Information("Having the log makes working with generators much simpler!");
        }

        protected override void OnException(Exception exception)
        {

            base.OnException(exception);
        }
    }
}
