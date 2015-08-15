﻿using EasyEventBus.Configuration;
using Ninject;

namespace EasyEventBus.TypeResolver.Ninject
{
    public static class ExtensionMethods
    {
        public static void UseNinjectTypeResolver(this IInMemoryStrategyConfig config, IKernel kernel)
        {
            config.SetTypeResolver(new NinjectTypeResolver(kernel));
        }
    }
}