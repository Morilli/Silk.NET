// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags]
    [NativeName("Name", "VkVideoEncodeH264RateControlFlagsKHR")]
    public enum VideoEncodeH264RateControlFlagsKHR : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"AttemptHrdComplianceBitKhr\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_H264_RATE_CONTROL_ATTEMPT_HRD_COMPLIANCE_BIT_KHR")]
        VideoEncodeH264RateControlAttemptHrdComplianceBitKhr = 1,
        [Obsolete("Deprecated in favour of \"RegularGopBitKhr\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_H264_RATE_CONTROL_REGULAR_GOP_BIT_KHR")]
        VideoEncodeH264RateControlRegularGopBitKhr = 2,
        [Obsolete("Deprecated in favour of \"ReferencePatternFlatBitKhr\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_H264_RATE_CONTROL_REFERENCE_PATTERN_FLAT_BIT_KHR")]
        VideoEncodeH264RateControlReferencePatternFlatBitKhr = 4,
        [Obsolete("Deprecated in favour of \"ReferencePatternDyadicBitKhr\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_H264_RATE_CONTROL_REFERENCE_PATTERN_DYADIC_BIT_KHR")]
        VideoEncodeH264RateControlReferencePatternDyadicBitKhr = 8,
        [Obsolete("Deprecated in favour of \"TemporalLayerPatternDyadicBitKhr\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_H264_RATE_CONTROL_TEMPORAL_LAYER_PATTERN_DYADIC_BIT_KHR")]
        VideoEncodeH264RateControlTemporalLayerPatternDyadicBitKhr = 16,
        [NativeName("Name", "VK_VIDEO_ENCODE_H264_RATE_CONTROL_ATTEMPT_HRD_COMPLIANCE_BIT_KHR")]
        AttemptHrdComplianceBitKhr = 1,
        [NativeName("Name", "VK_VIDEO_ENCODE_H264_RATE_CONTROL_REGULAR_GOP_BIT_KHR")]
        RegularGopBitKhr = 2,
        [NativeName("Name", "VK_VIDEO_ENCODE_H264_RATE_CONTROL_REFERENCE_PATTERN_FLAT_BIT_KHR")]
        ReferencePatternFlatBitKhr = 4,
        [NativeName("Name", "VK_VIDEO_ENCODE_H264_RATE_CONTROL_REFERENCE_PATTERN_DYADIC_BIT_KHR")]
        ReferencePatternDyadicBitKhr = 8,
        [NativeName("Name", "VK_VIDEO_ENCODE_H264_RATE_CONTROL_TEMPORAL_LAYER_PATTERN_DYADIC_BIT_KHR")]
        TemporalLayerPatternDyadicBitKhr = 16,
    }
}
