﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using RBot.Options;

namespace RBot
{
    public static class AppRuntime
    {
        public static OptionContainer Options { get; set; } = new OptionContainer()
        {
            OptionsFile = "rbot.cfg",
        };

        public static void Init()
        {
            Options.Options.AddRange(new List<IOption>()
            {
                new Option<bool>("proxy.enabled", "Proxy Enabled", "Enables the proxy used to load and patch the game's SWF files. This can cause loading/login issues."),
                new Option<int>("proxy.port", "Proxy Port", "The port that the patch proxy will bind to. Port 0 finds an available port."),
                new Option<bool>("proxy.cache.disable", "Disable Cache", "Disables caching of network responses when using the proxy.", true),
                new Option<bool>("updates.check", "Check for Updates", "When enabled, RBot will check for updates and notify you of new versions on launch.", true),
                new Option<bool>("updates.beta", "Check for Prereleases", "Update checks will also check for prerelease versions.", false)
            });

            Options.SetDefaults();
            Options.Load();
            Options.Save();
        }
    }
}
