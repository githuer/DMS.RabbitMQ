﻿using System;

namespace DMS.RabbitMQ.Subscribe
{
    class Program
    {
        static void Main(string[] args)
        {
            //HostFactory.Run(config =>
            //{
            //    config.SetServiceName("serviceName".ValueOfAppSetting());

            //    config.Service<MainService>(ser =>
            //    {
            //        ser.ConstructUsing(name => new MainService());
            //        ser.WhenStarted((service, control) => service.Start());
            //        ser.WhenStopped((service, control) => service.Stop());
            //    });
            //});

            var service = new MainService();
            service.Start();
        }
    }
}
