﻿namespace LightInject.Mvc.Tests
{
    internal static class ContainerFactory
    {
        internal static IServiceContainer CreateContainer()
        {
            return new ServiceContainer();
        }

        internal static IServiceContainer CreateContainer(ContainerOptions options)
        {
            return new ServiceContainer(options);
        }
    }
}