// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Support
{

    /// <summary>Type of the managed identity</summary>
    public partial struct ManagedIdentityType :
        System.IEquatable<ManagedIdentityType>
    {
        public static Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Support.ManagedIdentityType None = @"None";

        public static Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Support.ManagedIdentityType SystemAssigned = @"SystemAssigned";

        public static Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Support.ManagedIdentityType SystemAssignedUserAssigned = @"SystemAssigned,UserAssigned";

        public static Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Support.ManagedIdentityType UserAssigned = @"UserAssigned";

        /// <summary>the value for an instance of the <see cref="ManagedIdentityType" /> Enum.</summary>
        private string _value { get; set; }

        /// <summary>Conversion from arbitrary object to ManagedIdentityType</summary>
        /// <param name="value">the value to convert to an instance of <see cref="ManagedIdentityType" />.</param>
        internal static object CreateFrom(object value)
        {
            return new ManagedIdentityType(global::System.Convert.ToString(value));
        }

        /// <summary>Compares values of enum type ManagedIdentityType</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Support.ManagedIdentityType e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>Compares values of enum type ManagedIdentityType (override for Object)</summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is ManagedIdentityType && Equals((ManagedIdentityType)obj);
        }

        /// <summary>Returns hashCode for enum ManagedIdentityType</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>Creates an instance of the <see cref="ManagedIdentityType" Enum class./></summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private ManagedIdentityType(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Returns string representation for ManagedIdentityType</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Implicit operator to convert string to ManagedIdentityType</summary>
        /// <param name="value">the value to convert to an instance of <see cref="ManagedIdentityType" />.</param>

        public static implicit operator ManagedIdentityType(string value)
        {
            return new ManagedIdentityType(value);
        }

        /// <summary>Implicit operator to convert ManagedIdentityType to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="ManagedIdentityType" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Support.ManagedIdentityType e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum ManagedIdentityType</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Support.ManagedIdentityType e1, Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Support.ManagedIdentityType e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum ManagedIdentityType</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Support.ManagedIdentityType e1, Microsoft.Azure.PowerShell.Cmdlets.AppPlatform.Support.ManagedIdentityType e2)
        {
            return e2.Equals(e1);
        }
    }
}