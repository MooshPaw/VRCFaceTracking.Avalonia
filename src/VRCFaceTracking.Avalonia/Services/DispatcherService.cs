﻿using System;
using Avalonia;
using Avalonia.Threading;
using VRCFaceTracking.Core.Contracts.Services;

namespace VRCFaceTracking.Services;

// Simple service to invoke actions on the UI thread from the Core project.
public class DispatcherService : IDispatcherService
{
    public void Run(Action action) => Dispatcher.UIThread.Post(action);
}
