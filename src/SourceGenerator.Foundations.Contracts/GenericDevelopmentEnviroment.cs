﻿using Serilog.Core;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace SGF
{
    /// <summary>
    /// A <see cref="IDevelopmentEnviroment"/> that does not do anything
    /// </summary>
    internal class GenericDevelopmentEnviroment : IDevelopmentEnviroment
    {
        /// <inheritdoc cref="IDevelopmentEnviroment"/>
        public bool AttachDebugger(int processId)
            => Debugger.Launch();

        /// <inheritdoc cref="IDevelopmentEnviroment"/>
        public IEnumerable<ILogEventSink> GetLogSinks()
            => Array.Empty<ILogEventSink>();
    }
}