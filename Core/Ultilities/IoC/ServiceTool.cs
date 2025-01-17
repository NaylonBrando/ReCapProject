﻿using Microsoft.Extensions.DependencyInjection;
using System;

namespace Core.Ultilities.IoC
{
    public static class ServiceTool
    {
        public static IServiceProvider ServiceProvider { get; private set; }

        public static IServiceCollection Create(IServiceCollection services) //.netin servislerini al VE onlari kendin built et
        {
            ServiceProvider = services.BuildServiceProvider();
            return services;
        }
    }
}