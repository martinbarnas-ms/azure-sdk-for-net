// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> This enumerates the possible state of the disk. </summary>
    public readonly partial struct DiskState : IEquatable<DiskState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="DiskState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public DiskState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string UnattachedValue = "Unattached";
        private const string AttachedValue = "Attached";
        private const string ReservedValue = "Reserved";
        private const string ActiveSASValue = "ActiveSAS";
        private const string ReadyToUploadValue = "ReadyToUpload";
        private const string ActiveUploadValue = "ActiveUpload";

        /// <summary> The disk is not being used and can be attached to a VM. </summary>
        public static DiskState Unattached { get; } = new DiskState(UnattachedValue);
        /// <summary> The disk is currently mounted to a running VM. </summary>
        public static DiskState Attached { get; } = new DiskState(AttachedValue);
        /// <summary> The disk is mounted to a stopped-deallocated VM. </summary>
        public static DiskState Reserved { get; } = new DiskState(ReservedValue);
        /// <summary> The disk currently has an Active SAS Uri associated with it. </summary>
        public static DiskState ActiveSAS { get; } = new DiskState(ActiveSASValue);
        /// <summary> A disk is ready to be created by upload by requesting a write token. </summary>
        public static DiskState ReadyToUpload { get; } = new DiskState(ReadyToUploadValue);
        /// <summary> A disk is created for upload and a write token has been issued for uploading to it. </summary>
        public static DiskState ActiveUpload { get; } = new DiskState(ActiveUploadValue);
        /// <summary> Determines if two <see cref="DiskState"/> values are the same. </summary>
        public static bool operator ==(DiskState left, DiskState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="DiskState"/> values are not the same. </summary>
        public static bool operator !=(DiskState left, DiskState right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="DiskState"/>. </summary>
        public static implicit operator DiskState(string value) => new DiskState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is DiskState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(DiskState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
