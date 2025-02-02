// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Direct3D11
{
    [StructLayout(LayoutKind.Explicit)]
    [NativeName("Name", "__AnonymousRecord_d3d11_L11668_C5")]
    public unsafe partial struct VideoDecoderOutputViewDescUnion
    {
        public VideoDecoderOutputViewDescUnion
        (
            Tex2DVdov? texture2D = null
        ) : this()
        {
            if (texture2D is not null)
            {
                Texture2D = texture2D.Value;
            }
        }


        [FieldOffset(0)]
        [NativeName("Type", "D3D11_TEX2D_VDOV")]
        [NativeName("Type.Name", "D3D11_TEX2D_VDOV")]
        [NativeName("Name", "Texture2D")]
        public Tex2DVdov Texture2D;
    }
}
