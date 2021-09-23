﻿using System;
using System.IO;

namespace ContainerDesktop.Common.DesiredStateConfiguration
{
    public class FileConfigurationManifest : ConfigurationManifest
    {
        public FileConfigurationManifest(string fileName, IServiceProvider serviceProvider)
            : base(serviceProvider, File.OpenRead(fileName), new Uri(fileName))
        {
        }
    }
}
