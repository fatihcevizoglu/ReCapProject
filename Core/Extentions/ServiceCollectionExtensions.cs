﻿using Core.Utilities.IoC;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Extentions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddDependencyResolvers(this IServiceCollection serviceColletion , ICoreModule[] modules)
        {
            foreach (var module in modules)
            {
                module.Load(serviceColletion);
            }

            return ServiceTool.Create(serviceColletion);
        }
    }
}
