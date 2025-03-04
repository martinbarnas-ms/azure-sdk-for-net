// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.ResourceManager;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> Certificate order action. </summary>
    public partial class CertificateOrderAction : ProxyOnlyResource
    {
        /// <summary> Initializes a new instance of CertificateOrderAction. </summary>
        public CertificateOrderAction()
        {
        }

        /// <summary> Initializes a new instance of CertificateOrderAction. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="kind"> Kind of resource. </param>
        /// <param name="actionType"> Action type. </param>
        /// <param name="createdAt"> Time at which the certificate action was performed. </param>
        internal CertificateOrderAction(ResourceIdentifier id, string name, ResourceType type, string kind, CertificateOrderActionType? actionType, DateTimeOffset? createdAt) : base(id, name, type, kind)
        {
            ActionType = actionType;
            CreatedAt = createdAt;
        }

        /// <summary> Action type. </summary>
        public CertificateOrderActionType? ActionType { get; }
        /// <summary> Time at which the certificate action was performed. </summary>
        public DateTimeOffset? CreatedAt { get; }
    }
}
