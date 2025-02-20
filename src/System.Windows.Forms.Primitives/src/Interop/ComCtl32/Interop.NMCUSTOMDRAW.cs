﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

internal static partial class Interop
{
    internal static partial class ComCtl32
    {
        public struct NMCUSTOMDRAW
        {
            public NMHDR nmcd;
            public CDDS dwDrawStage;
            public HDC hdc;
            public RECT rc;
            public IntPtr dwItemSpec;
            public CDIS uItemState;
            public IntPtr lItemlParam;
        }
    }
}
