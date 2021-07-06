// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Databricks.Support
{

    /// <summary>The status of the virtual network peering.</summary>
    public partial struct PeeringState :
        System.IEquatable<PeeringState>
    {
        public static Microsoft.Azure.PowerShell.Cmdlets.Databricks.Support.PeeringState Connected = @"Connected";

        public static Microsoft.Azure.PowerShell.Cmdlets.Databricks.Support.PeeringState Disconnected = @"Disconnected";

        public static Microsoft.Azure.PowerShell.Cmdlets.Databricks.Support.PeeringState Initiated = @"Initiated";

        /// <summary>the value for an instance of the <see cref="PeeringState" /> Enum.</summary>
        private string _value { get; set; }

        /// <summary>Conversion from arbitrary object to PeeringState</summary>
        /// <param name="value">the value to convert to an instance of <see cref="PeeringState" />.</param>
        internal static object CreateFrom(object value)
        {
            return new PeeringState(global::System.Convert.ToString(value));
        }

        /// <summary>Compares values of enum type PeeringState</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.Databricks.Support.PeeringState e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>Compares values of enum type PeeringState (override for Object)</summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is PeeringState && Equals((PeeringState)obj);
        }

        /// <summary>Returns hashCode for enum PeeringState</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>Creates an instance of the <see cref="PeeringState" Enum class./></summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private PeeringState(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Returns string representation for PeeringState</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Implicit operator to convert string to PeeringState</summary>
        /// <param name="value">the value to convert to an instance of <see cref="PeeringState" />.</param>

        public static implicit operator PeeringState(string value)
        {
            return new PeeringState(value);
        }

        /// <summary>Implicit operator to convert PeeringState to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="PeeringState" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.Databricks.Support.PeeringState e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum PeeringState</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.Databricks.Support.PeeringState e1, Microsoft.Azure.PowerShell.Cmdlets.Databricks.Support.PeeringState e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum PeeringState</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.Databricks.Support.PeeringState e1, Microsoft.Azure.PowerShell.Cmdlets.Databricks.Support.PeeringState e2)
        {
            return e2.Equals(e1);
        }
    }
}