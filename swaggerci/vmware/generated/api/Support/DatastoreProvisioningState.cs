// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Support
{

    /// <summary>The state of the datastore provisioning</summary>
    public partial struct DatastoreProvisioningState :
        System.IEquatable<DatastoreProvisioningState>
    {
        public static Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Support.DatastoreProvisioningState Cancelled = @"Cancelled";

        public static Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Support.DatastoreProvisioningState Deleting = @"Deleting";

        public static Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Support.DatastoreProvisioningState Failed = @"Failed";

        public static Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Support.DatastoreProvisioningState Succeeded = @"Succeeded";

        public static Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Support.DatastoreProvisioningState Updating = @"Updating";

        /// <summary>
        /// the value for an instance of the <see cref="DatastoreProvisioningState" /> Enum.
        /// </summary>
        private string _value { get; set; }

        /// <summary>Conversion from arbitrary object to DatastoreProvisioningState</summary>
        /// <param name="value">the value to convert to an instance of <see cref="DatastoreProvisioningState" />.</param>
        internal static object CreateFrom(object value)
        {
            return new DatastoreProvisioningState(global::System.Convert.ToString(value));
        }

        /// <summary>Creates an instance of the <see cref="DatastoreProvisioningState" Enum class./></summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private DatastoreProvisioningState(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Compares values of enum type DatastoreProvisioningState</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Support.DatastoreProvisioningState e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>Compares values of enum type DatastoreProvisioningState (override for Object)</summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is DatastoreProvisioningState && Equals((DatastoreProvisioningState)obj);
        }

        /// <summary>Returns hashCode for enum DatastoreProvisioningState</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>Returns string representation for DatastoreProvisioningState</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Implicit operator to convert string to DatastoreProvisioningState</summary>
        /// <param name="value">the value to convert to an instance of <see cref="DatastoreProvisioningState" />.</param>

        public static implicit operator DatastoreProvisioningState(string value)
        {
            return new DatastoreProvisioningState(value);
        }

        /// <summary>Implicit operator to convert DatastoreProvisioningState to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="DatastoreProvisioningState" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Support.DatastoreProvisioningState e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum DatastoreProvisioningState</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Support.DatastoreProvisioningState e1, Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Support.DatastoreProvisioningState e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum DatastoreProvisioningState</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Support.DatastoreProvisioningState e1, Microsoft.Azure.PowerShell.Cmdlets.VMwareSolutionApi.Support.DatastoreProvisioningState e2)
        {
            return e2.Equals(e1);
        }
    }
}