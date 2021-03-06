﻿namespace Log4Net
{
    using System;

    using log4net;
    using log4net.Config;

    public static class Log4NetTets
    {
        private static readonly ILog Log = LogManager.GetLogger(typeof(Log4NetTets));

        public static void Main()
        {
            XmlConfigurator.Configure();
            Log.Info("Info logging");
            try
            {
                throw new Exception("Exception!");
            }
            catch (Exception e)
            {
                Log.Error("This is my error", e);
            }

            Console.WriteLine("[any key to exit]");
            Console.ReadKey();
        }
    }
}
