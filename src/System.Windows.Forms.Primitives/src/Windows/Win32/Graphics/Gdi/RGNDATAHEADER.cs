﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace Windows.Win32.Graphics.Gdi
{
    internal partial struct RGNDATAHEADER
    {
        public unsafe static RECT[] GetRegionRects(RGNDATAHEADER* regionData)
        {
            if (regionData is null || regionData->nCount == 0)
            {
                return Array.Empty<RECT>();
            }

            // Region RECTs directly follow the header
            return new Span<RECT>((byte*)regionData + regionData->dwSize, (int)regionData->nCount).ToArray();
        }
    }
}
