// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Network.Models
{
    internal static partial class FirewallPolicyIdpsSignatureDirectionExtensions
    {
        public static FirewallPolicyIdpsSignatureDirection ToFirewallPolicyIdpsSignatureDirection(this int value)
        {
            if (value == 0) return FirewallPolicyIdpsSignatureDirection.Zero;
            if (value == 1) return FirewallPolicyIdpsSignatureDirection.One;
            if (value == 2) return FirewallPolicyIdpsSignatureDirection.Two;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown FirewallPolicyIdpsSignatureDirection value.");
        }
    }
}
