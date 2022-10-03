﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace Windows.Win32
{
    internal static partial class PInvoke
    {
        public static BOOL SetWindowPos<T1, T2>(in T1 hWnd, in T2 hWndInsertAfter, int X, int Y, int cx, int cy, SET_WINDOW_POS_FLAGS uFlags)
            where T1 : IHandle<HWND>
            where T2 : IHandle<HWND>
        {
            BOOL result = SetWindowPos(hWnd.Handle, hWndInsertAfter.Handle, X, Y, cx, cy, uFlags);
            GC.KeepAlive(hWnd.Wrapper);
            GC.KeepAlive(hWndInsertAfter.Wrapper);
            return result;
        }
    }
}
