﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace Windows.Win32.UI.Shell;

internal interface INativeGuid
{
    protected internal static abstract Guid Guid { get; }
}
